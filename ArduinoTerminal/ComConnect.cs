using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ArduinoTerminal
{
    public partial class ComConnect : Form
    {
        public delegate void ConsoleBoxAddText(int Key);
        public delegate void SendCaptureCommand(int IntSend);
        //public delegate void (int c);
        public ConsoleBoxAddText CBATdelegate;

        /// <summary>
        /// Param: Int 0 - 127
        /// </summary>
        /// <param name="INTSend"></param>
        private void SendInt(string INTSend)
        {
            try
            {
                int SendInt = Convert.ToInt32(TextSend.Text);
                if (SendInt >= 0 && SendInt <= 127)
                {
                    Program.ComPort.WriteCOMport(SendInt, false);
                    ConsoleBox.AppendText(TextSend.Text + "\n");
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
            Program.ComPort.WriteCOMport(TextSend.Text, Program.MainForm.SendTypeLine);
            ConsoleBox.AppendText(TextSend.Text + "\n");
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
                        /*if (Program.MainForm.ReadTypeChar)
                        {
                            ConsoleBox.AppendText(Convert.ToChar(ReadInt) + "");
                        }
                        else
                        {
                            ConsoleBox.AppendText(ReadInt + "\n");
                        }*/
                    }
                    else if (ReadInt == -2)
                    {
                        MessageBox.Show("Error Read. COM port was disabled .\nReturn to settings...");
                        Program.MainForm.ConnectForm.Close();
                    }
                }
            }
        }

        public void ConsoleBox_AddText(int CharRead)
        {
            if (Program.MainForm.ReadTypeChar)
            {

                ConsoleBox.AppendText(Convert.ToChar(CharRead) + "");
            }
            else
            {
                ConsoleBox.AppendText(CharRead + "\n");
            }
            ConsoleBox.Select(
                ConsoleBox.Text.Length - 1,
                ConsoleBox.Text.Length);
            ConsoleBox.SelectionColor = Color.YellowGreen;
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            ConsoleBox.ScrollToCaret();
        }

        public ComConnect()
        {
            InitializeComponent();
        }

        private void ComConnect_Load(object sender, EventArgs e)
        {
            Program.MainForm.ReadComPort = new Thread(Read);
            Program.MainForm.ReadComPort.Start();
            Program.MainForm.ThreadStart = true;
            CBATdelegate = new ConsoleBoxAddText(ConsoleBox_AddText);
            //action = c => ConsoleBox_AddText(c);
        }

        private void TextSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;
            if (e.KeyChar == (char)Keys.Enter)
            {
                Send();
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
