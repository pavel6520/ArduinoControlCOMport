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
    public partial class ArduinoControl : Form
    {
        public ComConnect ConnectForm;
        public Thread ReadComPort;
        private int count;
        public bool SendTypeString = true;
        public bool SendTypeLine = true;
        public bool ReadTypeChar = true;
        public bool ThreadStart = false;

        public int ComNamesUpdate()
        {
            BoxComNames.Items.Clear();
            count = Program.ComPort.PortsNamesUpdate();
            for (int i = 0; i < count; i++)
            {
                BoxComNames.Items.Insert(i, Program.ComPort.GetPortsName(i));
            }
            if (count == 0)
            {
                ComStartConnect.Enabled = false;
            }
            else
            {
                BoxComNames.SelectedIndex = 0;
                ComStartConnect.Enabled = true;
            }
            return 0;
        }

        public ArduinoControl()
        {
            InitializeComponent();
            BoxComNames.SelectedIndexChanged += BoxComNames_SelectedIndexChanged;
            BoxComNames.DropDown += BoxComNames_DropDown;
            BoxBaudRate.SelectedIndexChanged += BoxBaudRate_SelectedIndexChanged;
        }

        private void ArduinoControl_Load(object sender, EventArgs e)
        {
            ComNamesUpdate();
            for (int i = 0; i < 9; i++)
            {
                BoxBaudRate.Items.Insert(i, Program.ComPort.GetBaud(i + 1));
            }
            BoxBaudRate.SelectedIndex = 3;
        }

        private void ButtonStartConnect_Click(object sender, EventArgs e)
        {
            ConnectForm = new ComConnect();
            this.Visible = false;
            ConnectForm.FormClosed += (obj, arg) =>
            {
                if (ThreadStart)
                {
                    ThreadStart = false;
                    while (ReadComPort.ThreadState != ThreadState.Stopped) ;
                    Program.ComPort.CloseCOMport();
                }
                this.Visible = true;
            };
            
            ConnectForm.Show();
        }

        private void BoxComNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.ComPort.SetPortName(Program.ComPort.GetPortsName(Convert.ToInt32(BoxComNames.SelectedIndex.ToString())));
            Program.ComPort.InitCOMport();
        }

        private void BoxComNames_DropDown(object sender, EventArgs e)
        {
            ComNamesUpdate();
        }

        private void BoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.ComPort.SetPortBaud(Program.ComPort.GetBaud(BoxBaudRate.SelectedIndex + 1));
        }

        private void TypeSendString_CheckedChanged(object sender, EventArgs e)
        {
            SendTypeString = TypeSendString.Checked;
            if (SendTypeString)
            {
                TypeSendNewLine.Enabled = true;
            }
            else
            {
                TypeSendNewLine.Enabled = false;
            }
        }

        private void TypeSendNewLine_CheckedChanged(object sender, EventArgs e)
        {
            SendTypeLine = !TypeSendNewLine.Checked;
        }

        private void TypeReadChar_CheckedChanged(object sender, EventArgs e)
        {
            ReadTypeChar = TypeReadChar.Checked;
        }
    }
}
