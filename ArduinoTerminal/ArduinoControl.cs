using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoTerminal
{
    public partial class ArduinoControl : Form
    {
        int count;

        public int ComNamesUpdate()
        {
            BoxComNames.Items.Clear();
            count = Program.ComPort.PortsNamesUpdate();
            for (int i = 0; i < count; i++)
            {
                BoxComNames.Items.Insert(i, Program.ComPort.GetPortsName(i));
            }
            BoxComNames.SelectedIndex = 0;
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
            for (int i = 1; i < 10; i++)
            {
                BoxBaudRate.Items.Insert(i - 1, Program.ComPort.GetBaud(i));
            }
            BoxBaudRate.SelectedIndex = 3;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ComConnect ConnectForm = new ComConnect();
            this.BackColor = Color.DimGray;
            this.Enabled = false;
            ConnectForm.FormClosed += (obj, arg) =>
            {
                this.BackColor = Color.WhiteSmoke;
                this.Enabled = true;
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
            MessageBox.Show(Convert.ToString(Program.ComPort.GetBaud(BoxBaudRate.SelectedIndex + 1)));
        }
    }
}
