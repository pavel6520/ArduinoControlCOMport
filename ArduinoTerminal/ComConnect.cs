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
        public delegate void ConsoleBoxAddText(int c);
        public ConsoleBoxAddText CBATdelegate;

        private void Send()
        {
            if (Program.MainForm.SendTypeString)
            {
                Program.ComPort.WriteCOMport(TextSend.Text, Program.MainForm.SendTypeLine);
                ConsoleBox.AppendText(TextSend.Text + "\n");
            }
            else
            {
                try
                {
                    int SendInt = Convert.ToInt32(TextSend.Text);
                    if (SendInt >= 0 && SendInt <= 127)
                    {
                        Program.ComPort.WriteCOMport(SendInt, false);
                        ConsoleBox.AppendText(TextSend.Text + "\n");
                    }
                    else
                    {
                        MessageBox.Show("Error format. Enter number (0 - 127)");
                    }
                }
                catch(FormatException e)
                {
                    MessageBox.Show("Error format. Enter number (0 - 127)");
                }
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

        public void ConsoleBox_AddText(int c)
        {
            if (Program.MainForm.ReadTypeChar)
            {

                ConsoleBox.AppendText(Convert.ToChar(c) + "");
            }
            else
            {
                ConsoleBox.AppendText(c + "\n");
            }
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            ConsoleBox.ScrollToCaret();
            ConsoleBox.Select(
                ConsoleBox.Text.Length - 1,
                ConsoleBox.Text.Length);
            ConsoleBox.SelectionColor = Color.YellowGreen;
        }

        public ComConnect()
        {
            InitializeComponent();
        }

        private void ComConnect_Load(object sender, EventArgs e)
        {
            Program.ComPort.SetConfCOMport();
            if (!Program.ComPort.OpenCOMport())
            {
                MessageBox.Show("Error open port " + Program.ComPort.GetCOMportName() + "\nReturn to Settings...");
                this.Close();
            }
            else
            {
                Program.MainForm.ReadComPort = new Thread(Read);
                Program.MainForm.ReadComPort.Start();
                Program.MainForm.ThreadStart = true;
            }
            CBATdelegate = new ConsoleBoxAddText(ConsoleBox_AddText);
            //action = c => ConsoleBox_AddText(c);
        }

        private void TextSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send();
            }
        }

        private void TextSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
