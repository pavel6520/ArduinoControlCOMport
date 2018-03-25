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
        private void Send()
        {
            if (Program.MainForm.SendTypeString)
            {
                Program.ComPort.WriteCOMport(TextSend.Text, !Program.MainForm.SendTypeLine);
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

        private static void Read()
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
                        if (Program.MainForm.ReadTypeChar)
                        {
                            Program.MainForm.ConnectForm.ConsoleBox.AppendText(Convert.ToChar(ReadInt) + "");
                        }
                        else
                        {
                            Program.MainForm.ConnectForm.ConsoleBox.AppendText(ReadInt + "\n");
                        }
                    }
                    else if (ReadInt == -2)
                    {
                        MessageBox.Show("Error Read. COM port was disabled .\nReturn to settings...");
                        //Program.MainForm.ConnectForm.Close();
                    }
                }
            }
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
                Program.MainForm.ReadComPort = new Thread(ComConnect.Read);
                Program.MainForm.ReadComPort.Start();
                Program.MainForm.ThreadStart = true;
            }
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
