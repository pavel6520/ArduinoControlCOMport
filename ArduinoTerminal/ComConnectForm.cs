using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ArduinoTerminal
{
    public partial class ComConnectForm : Form
    {
        public bool[] MasPressedKeys;
        public delegate void ConsoleBoxAddText(int Key);
        public delegate void SendCaptureCommand(string INTSend);
        //public delegate void (int c);
        public ConsoleBoxAddText CBATdelegate; //delegate for add text in ConsoleBox
        public SendCaptureCommand SCCdelegate; //delegate for send command
        public Thread CapturedSend;

        /// <summary>
        /// Param: Int 0 - 127
        /// </summary>
        /// <param name="INTSend"></param>
        private void SendInt(string INTSend)
        {
            try
            {
                int SendInt = Convert.ToInt32(INTSend);
                if (SendInt >= 0 && SendInt <= 127)
                {
                    Program.ComPort.WriteCOMport(SendInt, false);
                    ConsoleBox.AppendText(SendInt + "\n");
                    ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
                    ConsoleBox.ScrollToCaret();
                }
                else
                {
                    MessageBox.Show("Error format. Enter number (0 - 127)");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Error format. Enter number (0 - 127)");
            }
        }

        private void SendString(string STRINGSend)
        {
            Program.ComPort.WriteCOMport(STRINGSend, Program.MainForm.SendTypeLine);
            ConsoleBox.AppendText(STRINGSend + "\n");
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            ConsoleBox.ScrollToCaret();
        }

        private void Send()
        {
            if (Program.MainForm.SendTypeString)
            {
                SendString(TextSend.Text);
            }
            else
            {
                SendInt(TextSend.Text);
            }
            TextSend.Text = "";
        }

        private void Read()
        {
            while (true)
            {
                if (!Program.MainForm.ThreadStart)
                {
                    return;
                }
                else
                {
                    int ReadInt = Program.ComPort.ReadCOMport();
                    if (ReadInt >= 0)
                    {
                        Invoke(CBATdelegate, ReadInt);
                    }
                    else if (ReadInt == -2)
                    {
                        MessageBox.Show("Error Read. COM port was disabled .\nReturn to settings...");
                        Program.MainForm.ConnectForm.Close();
                    }
                }
            }
        }

        public void ConsoleBox_AddChar(int CharRead)
        {
            if (Program.MainForm.ReadTypeChar)
            {

                ConsoleBox.AppendText(Convert.ToChar(CharRead) + "");
            }
            else
            {
                ConsoleBox.AppendText(CharRead + "\n");
            }
            ConsoleBox.Select(ConsoleBox.Text.Length - 1, ConsoleBox.Text.Length);
            ConsoleBox.SelectionColor = Color.YellowGreen;
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            ConsoleBox.ScrollToCaret();
        }

        public void CaptureKeyEvent(object eC)
        {
            KeyEventArgs e = (KeyEventArgs)eC;
            if (e.KeyCode == Keys.W)
            {
                Invoke(SCCdelegate, 1 + "");
            }
            if (e.KeyCode == Keys.S)
            {
                Invoke(SCCdelegate, 2 + "");
            }
            if (e.KeyCode == Keys.Space)
            {
                Invoke(SCCdelegate, 0 + "");
            }
            Thread.Sleep(50);
        }

        public ComConnectForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void ComConnect_Load(object sender, EventArgs e)
        {
            this.Text = Program.ComPort.GetCOMportName() + " " + Program.ComPort.GetCOMportBaud();
            this.Location = Program.MainForm.Location;
            Program.MainForm.ReadComPort = new Thread(Read);
            Program.MainForm.ReadComPort.Start();
            Program.MainForm.ThreadStart = true;
            CBATdelegate = new ConsoleBoxAddText(ConsoleBox_AddChar);
            if (Program.MainForm.CaptureMode)
            {
                SCCdelegate = new SendCaptureCommand(SendInt);
                CapturedSend = new Thread(CaptureKeyEvent);
                MasPressedKeys = new bool[222];
            }
        }

        private void TextSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;
            if (e.Handled)
            {
                Send();
            }
        }
        
        private void ConsoleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComConnectForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (ConsoleBox.Focused)
            {
                if (Program.MainForm.CaptureMode)
                {
                    if(CapturedSend.ThreadState == ThreadState.Stopped)
                    {
                        CapturedSend = new Thread(CaptureKeyEvent);
                    }
                    if(CapturedSend.ThreadState != ThreadState.WaitSleepJoin && CapturedSend.ThreadState != ThreadState.Running)
                    {
                        CapturedSend.Start(e);
                        TextSend.Text = "ALT=" + e.Alt + " CTRL=" + e.Control + " SHIFT=" + e.Shift + " key= " + e.KeyCode + "| " + e.KeyData + "| " + e.KeyValue;
                    }
                    
                }
            }
        }
    }
}
