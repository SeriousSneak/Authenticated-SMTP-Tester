/*----------------------------------------------------------------------------
 * Programmer: Andrew Stobart (Microsoft)
 * Initial release date: June 24, 2015
 * 
 * Description:  This program is used to test Authenticated SMTP. Office 365 offers Authenticated SMTP, but
 *               TLS is required, which is much harder to do (if possible) over a regular Telnet Session. This app allows
 *               toggling of TLS on or off to test Authenticated SMTP. The app launches by default with Office 365
 *               settings (ie. The endpoint is set to smtp.office365.com), although any end point can be entered.
 * 
 * 
 * Versions:
 *   1.1 (June 24, 2015):    - Andrew's initial release of the program.
 *   
 *   1.2.2 (July 23, 2015):  - Previously, you would see RST (reset) in the WireShark capture after the server socket test, and after the app
 *                             was closed. This was becuase the socket test and message send didn't gracefully teardown the connection. When the
 *                             app was closed, it would send a RST (reset) to pull down the connection. App now properly closes the connection 
 *                             and you'll see the proer [FIN, ACK] sequence in a WireShark capture.
 *                            
 *   1.2.3 (Sept 24, 2015):  - added a link to the help form pointing to the usage instructions document which is hosted on CodeBox
 *   
 *   1.3.0 (March 21, 2019): - error messages now appear in a new window, allowing the error text to be easily copied
 *                           - hitting tab now no longer stops on the MessageID box which is read only
 *                           - Text validation is now performed on the Port text box. An error will appear if this box contains anything other than an integer 
 *                           - Due to processing order, a non-sensical error (Error: A request to send or receive data was disallowed because the socket is not connected and (when sending on 
 *                             a datagram socket using a sendto call) no address was supplied) would previously appear if you could not reach the recipient server on port 25. This error has 
 *                             now been cleaned up.
 *                           - the code that detects if an end point is reachable has been optimized and better calls out a connection issue if the end point cannot be reached 
 *                           
 *   1.4.0 (Sept 18 2019):   - code migrated to Mimekit and Mailkit
 *                           - With Mailkit, the application now generates an SMTP log file which can be opened with the new "SMTP log" button
 *                           
 *   2.0.0 (July 2020):      - You can now specify a different sending mailbox. The account that you authenticate with must have Send As permissions on the
 *                             mailbox that you are specifying as being the sender.
 *                           - Put a group box around Username and Password called Authentication Credentials
 *                           - Tab order updated to flow from top to bottom with the newly added controls
 *                           - Mailkit upgraded from 2.3.1.6 to 2.7.0. Mimekit upgraded from 2.3.1 to 2.8.0. BouncyCastle upgraded from 1.8.5 to 1.8.6.1.
 *                           - Ctrl-A will now select all text in a message box. Previously, you would have to manually select the text in a message box if you wanted to copy it.
 *                           - About popup and error popup will now appear on top of the main app window (as opposed to popping up on a secondary monitor) 
 *  
 *   2.0.1 (August 2020):    - launch on GitHub!
 *                           - code cleanup (comments, redundant lines, formatting)
 *                           
 *   2.1.0 (Jan 08, 2021)    - Application will no longer crash if smtp.log is locked by another application
 *                           - Button added to open windows explorer to the location where smtp.log is located 
 *                           - input validation added to Username and Password text boxes
 *                           - error text box is now larger and no longer has a "close button." The button was redundant as the window can be closed with the X
 *                             in the upper right-hand corner
 *                           - tab index for controls fixed so that hitting tab progresses from top to bottom through the controls
 *                           - application renamed from Authenticated SMTP Tester to Supa Awesome Authenticated SMTP Tester   
 *                           - the installer now creates a desktop shortcut
 *                           - Minor UI updates to buttons
 *                           - Added a button that opens windows explorer to the directory where smtp.log resides
 *                           - MailKit and MimeKit updated to version 2.10.1
 *                           - BouncyCastle updated to version 1.8.9
 *
 *  2.1.1 (August 2, 2022)   - .Net updated from 4.6 to 4.8
 *                           - Updated MailKit and MimeKit from 2.10.1 to 3.3.0
 *                           - Added a sentance to the About page noting that the application only supports Basic Auth and not Modern Auth
 *
 *----------------------------------------------------------------------------*/


using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using MailKit;
using System.IO;
using System.Diagnostics;

namespace Authenticated_SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            //disable the send button so it cannot be clicked multiple times
            textMessageID.Text = "";
            bSend.Enabled = false;
            
            //Generate a Message-ID
            Guid gui = new Guid();
            gui = Guid.NewGuid();
            String messageID = "<" + gui.ToString() + "@smtpt.local>";


            /* -----------------------------------
             * SMTP LOGGING TO SMTP.LOG
             * -----------------------------------*/
            //smtp.log file will be created in the same directly that the executable is launched from
            string logPath = "smtp.log";
            FileInfo log = new FileInfo(logPath);

            SmtpClient client;

            //enable logging if either smtp.log isn't locked, or if it does not exist
            if (IsFileLocked(log) == false || File.Exists(logPath) == false)
            {
                client = new SmtpClient(new ProtocolLogger(logPath));
            }
            else
            {
                client = new SmtpClient();
                MessageBox.Show("The file smtp.log is currently in use by another application and will not be written to. The log within the application will still be written to.", "SMTP Log");
            }

            MimeMessage mail = new MimeMessage();

            try
            {

                /*Input validation for Port*/
                int n = 0;
                bool isNumber = int.TryParse(textPort.Text, out n);
                if (!isNumber)
                {
                    throw new ApplicationException("The port is set to \"" + textPort.Text + "\" but must be an integer.");
                }

                //User name and Password validation
                if (textUserName.Text == "" || textPassword.Text == "")
                {
                    throw new ApplicationException("Please enter both a User name and Password");
                }

                /* -----------------------------------
                 * IS SERVER REACHABLE?
                 * If server is not rechable, the timeout period in the Windows network stack can sometimes take excessive
                 * time to return an error. This code will check the server before attempting to send a message to it. I can
                 * manually set the timeout here.
                 * -----------------------------------
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IAsyncResult result = socket.BeginConnect(textReceivingServer.Text, Convert.ToInt32(textPort.Text), null, null);
                bool success = result.AsyncWaitHandle.WaitOne(3000, true); //wait 3 seconds

                if (socket.Connected == false)
                {
                    socket.Close();
                    throw new ApplicationException("Failed to connect to " + textReceivingServer.Text + " on port " + textPort.Text + ".");
                }
                else
                {
                    socket.Disconnect(true);
                }
                */

                //the following is the same code from SupaAwesomeMailflowTester (Aug 10, 2020)
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IAsyncResult result = socket.BeginConnect(textReceivingServer.Text, Convert.ToInt32(textPort.Text), null, null);
                bool success = result.AsyncWaitHandle.WaitOne(3000, true); //wait 3 seconds
                if (socket.Connected == false)
                {
                    socket.Close();
                    throw new ApplicationException("Failed to connect to " + textReceivingServer.Text + " on port " + textPort.Text + ".");
                }
                else
                {
                    socket.Disconnect(true);  //close this socket
                }

                client.Timeout = 10000; //10 second timeout                

                if (checkDifferentSender.Checked == true)
                {
                    mail.From.Add(new MailboxAddress(textFromName.Text, textDifferentAddress.Text));
                }
                else
                {
                    //I want to use the same format here as above but need a name to put in for the sender
                    mail.From.Add(new MailboxAddress(textFromName.Text, textUserName.Text));
                }

                mail.To.Add(new MailboxAddress(textTo.Text, textTo.Text));
                mail.Subject = textSubject.Text;
                mail.MessageId = messageID;

                BodyBuilder builder = new BodyBuilder();
                builder.TextBody = textBody.Text;
                mail.Body = builder.ToMessageBody();

                if (checkForceTLS.Checked == true)
                {
                    client.Connect(textReceivingServer.Text, Convert.ToInt32(textPort.Text), SecureSocketOptions.StartTls);
                }
                else
                {
                    client.Connect(textReceivingServer.Text, Convert.ToInt32(textPort.Text), SecureSocketOptions.None);
                }

                //client.Connect needs to take place before client.Authenticate. Otherwise you will see the error "The SmtpClient must be connected before you can authenticate."
                client.Authenticate(textUserName.Text, textPassword.Text);

                client.Send(mail);

                client.Disconnect(true);
                client.ProtocolLogger.Dispose(); //without this, smtp.log will remain open by the process and subsequent mail sends will be unable to write to the file


                textMessageID.Text = messageID; //displays the message ID if the message was sent
                MessageBox.Show("The message was sent!", "Sweet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                client.Disconnect(true);
                client.ProtocolLogger.Dispose(); //without this, smtp.log will remain open by the process and subsequent mail sends will be unable to write to the file

                string errorMessage = "Error: " + ex.Message;
                Forms.MessagesForm mf = new Forms.MessagesForm(errorMessage, "Error (╯°□°)╯︵ ┻━┻", "Close");
                mf.ShowDialog(); //will prevent the form from losing focus
            }

            bSend.Enabled = true;
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog(); //will prevent the form from losing focus
            e.Cancel = true; //this stops the question mark on the mouse curser from showing after the about box is closed
        }

        private void BLog_Click(object sender, EventArgs e)
        {
            if (File.Exists("smtp.log") == true)
            {
                Process.Start("notepad.exe", "smtp.log");
            }
            else
            {
                MessageBox.Show("Log file not yet created. Please send a message first.", "SMTP Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bLogLocation_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }

        private void checkDifferentSender_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDifferentSender.Checked == true)
            {
                textDifferentAddress.Enabled = true;
            }
            if (checkDifferentSender.Checked == false)
            {
                textDifferentAddress.Enabled = false;
            }
        }

        private void textMessageID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && (e.KeyCode == Keys.A || e.KeyCode == Keys.A))
            {
                textMessageID.SelectAll();
            }
        }

        protected virtual bool IsFileLocked(FileInfo file)  //https://stackoverflow.com/questions/876473/is-there-a-way-to-check-if-a-file-is-in-use
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }

    }
}