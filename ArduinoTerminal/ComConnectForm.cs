using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ArduinoTerminal
{
    public partial class ComConnectForm : Form
    {
        public delegate void ConsoleBoxAddInt(int INTValue, Color color);
        public delegate void ConsoleBoxAddString(string STRINGValue, Color color);
        public delegate void ConsoleBoxAddChar(char CHARValue, Color color);
        public ConsoleBoxAddInt CBAI;
        public ConsoleBoxAddString CBAS;
        public ConsoleBoxAddChar CBAC;
        public bool []MasPressedKeys;
        public bool ReadState = false;
        
        private void ConsoleBox_Add(int INTValue, Color color)
        {
            ConsoleBox.AppendText(INTValue + "\n");
            ConsoleBox.Select(ConsoleBox.TextLength - ConsoleBox.Lines[ConsoleBox.Lines.Length - 2].Length - 1, ConsoleBox.TextLength);
            ConsoleBox.SelectionColor = color;
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            ConsoleBox.ScrollToCaret();
        }

        private void ConsoleBox_Add(string STRINGValue, Color color)
        {
            ConsoleBox.AppendText(STRINGValue + "\n");
            ConsoleBox.Select(ConsoleBox.TextLength - ConsoleBox.Lines[ConsoleBox.Lines.Length - 2].Length - 1, ConsoleBox.TextLength);
            ConsoleBox.SelectionColor = color;
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            ConsoleBox.ScrollToCaret();
        }

        public void ConsoleBox_Add(char CHARValue, Color color)
        {
            ConsoleBox.AppendText(CHARValue + "");
            ConsoleBox.Select(ConsoleBox.TextLength - 1, ConsoleBox.TextLength);
            ConsoleBox.SelectionColor = color;
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            ConsoleBox.ScrollToCaret();
        }

        private void Send()
        {
            if (Program.MainForm.SendTypeString)
            {
                ConsoleBox_Add(TextSend.Text, Color.Cyan);
                Program.ComPort.WriteCOMport(TextSend.Text, Program.MainForm.SendTypeLine);
            }
            else
            {
                int SendINT = 0;
                try
                {
                    SendINT = Convert.ToInt32(TextSend.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error format. Enter number (0 - 127)");
                    return;
                }
                if (SendINT >= 0 && SendINT <= 127)
                {
                    ConsoleBox_Add(TextSend.Text, Color.Cyan);
                    Program.ComPort.WriteCOMport(SendINT, false);
                }
                else
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
                    int ReadInt = -1;
                    try
                    {
                        ReadInt = Program.ComPort.ReadCOMport();
                    }
                    catch (ThreadAbortException)
                    {
                        ReadInt = -3;
                    }
                    if (ReadInt == 0)
                    {
                        ReadState = false;
                    }
                    if (ReadInt >= 0)
                    {
                        if (Program.MainForm.ReadTypeChar)
                        {
                            if (ReadInt > 0)
                            {
                                Invoke(CBAC, Convert.ToChar(ReadInt), Color.YellowGreen);
                                //CBAC?.Invoke(Convert.ToChar(ReadInt), Color.YellowGreen);
                            }
                        }
                        else
                        {
                            Invoke(CBAI, ReadInt, Color.YellowGreen);
                        }
                    }
                    else if (ReadInt == -2)
                    {
                        MessageBox.Show("Error Read. COM port was disabled .\nReturn to settings...");
                        Program.MainForm.ThreadStart = false;
                        return;
                    }
                    else if (ReadInt == -3)
                    {
                        return;
                    }
                }
            }
        }
        
        public void CaptureKey()
        {
            //int Key = 0;
            while (true)
            {
                
                if (!Program.MainForm.ThreadStart)
                {
                    return;
                }
                if (!ReadState)
                {
                    try
                    {
                        //Program.ComPort.WriteCOMport(127, false);
                        string send = "";
                        //WS
                        if (MasPressedKeys[87])
                        {
                            if (!MasPressedKeys[83])
                            {
                                Program.ComPort.WriteCOMport(1, false);
                                send += "1";
                            }
                            else
                            {
                                Program.ComPort.WriteCOMport(0, false);
                                send += "0";
                            }
                        }
                        else if (MasPressedKeys[83])
                        {
                            if (!MasPressedKeys[87])
                            {
                                Program.ComPort.WriteCOMport(2, false);
                                send += "2";
                            }
                            else
                            {
                                Program.ComPort.WriteCOMport(0, false);
                                send += "0";
                            }
                        }
                        else
                        {
                            Program.ComPort.WriteCOMport(0, false);
                            send += "0";
                        }
                        //AD
                        if (MasPressedKeys[65])
                        {
                            if (!MasPressedKeys[68])
                            {
                                Program.ComPort.WriteCOMport(1, false);
                                send += "1";
                            }
                            else
                            {
                                Program.ComPort.WriteCOMport(0, false);
                                send += "0";
                            }
                        }
                        else if (MasPressedKeys[68])
                        {
                            if (!MasPressedKeys[65])
                            {
                                Program.ComPort.WriteCOMport(2, false);
                                send += "2";
                            }
                            else
                            {
                                Program.ComPort.WriteCOMport(0, false);
                                send += "0";
                            }
                        }
                        else
                        {
                            Program.ComPort.WriteCOMport(0, false);
                            send += "0";
                        }
                        //E
                        if (MasPressedKeys[69])
                        {
                            Program.ComPort.WriteCOMport(1, false);
                            send += "1";
                        }
                        else
                        {
                            Program.ComPort.WriteCOMport(0, false);
                            send += "0";
                        }
                        Invoke(CBAS, send, Color.DarkBlue);
                        ReadState = true;
                        Thread.Sleep(100);
                    }
                    catch (ObjectDisposedException)
                    {
                        return;
                    }
                }
                /*for (int i = 1; i < 223; i++)
                {

                    if (!ReadState)
                    {
                        if (MasPressedKeys[i])
                        {
                            if (Program.FileSettings.KeyExists("Key" + i))
                            {
                                int CountVal = Convert.ToInt32(Program.FileSettings.ReadINI("Key" + i, "countVal"));
                            
                                for (int j = 0; j < CountVal; j++)
                                {
                                    int SendVal  = Convert.ToInt32(Program.FileSettings.ReadINI("Key" + i, "Val" + j));
                                    //MessageBox.Show(Count + " " + i + " " + Program.FileSettings.ReadINI("Key" + i, "countVal"));
                                    Program.ComPort.WriteCOMport(SendVal, false);
                                    //Invoke(CBAS, Program.FileSettings.ReadINI("Key" + i, "Val" + j), Color.DarkBlue);
                                }
                                ReadState = true;
                            }
                        }
                    }
                }*/
            }
        }

        public ComConnectForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void ComConnect_Load(object sender, EventArgs e)
        {
            Text = Program.ComPort.GetCOMportName() + " " + Program.ComPort.GetCOMportBaud();
            Location = Program.MainForm.Location;
            CBAI = new ConsoleBoxAddInt(ConsoleBox_Add);
            CBAS = new ConsoleBoxAddString(ConsoleBox_Add);
            CBAC = new ConsoleBoxAddChar(ConsoleBox_Add);
            if (Program.MainForm.CaptureMode)
            {
                MasPressedKeys = new bool[223];
                for (int i = 1; i < 223; i++)
                {
                    MasPressedKeys[i] = false;
                }
                Program.MainForm.CapturedSend = new Thread(CaptureKey);
                Program.MainForm.CapturedSend.Start();
            }
            Program.MainForm.ReadComPort = new Thread(Read);
            Program.MainForm.ReadComPort.Start();
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
            if (ConsoleBox.Focused && Program.MainForm.CaptureMode)
            {
                MasPressedKeys[e.KeyValue] = true;
            }
        }

        private void ComConnectForm_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (ConsoleBox.Focused && Program.MainForm.CaptureMode)
            {
                MasPressedKeys[e.KeyValue] = false;
            }
        }
    }
}
