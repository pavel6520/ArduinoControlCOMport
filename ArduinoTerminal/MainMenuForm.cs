using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ArduinoTerminal
{
    public partial class MainMenuForm : Form
    {
        public ComConnectForm ConnectForm;
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

        public static void SaveLocation(Form form)
        {
            int x = form.Location.X, y = form.Location.Y;
            while (x < 0 || x > Screen.PrimaryScreen.Bounds.Size.Width)
            {
                if (x < 0)
                {
                    x += Screen.PrimaryScreen.Bounds.Size.Width;
                }
                else
                {
                    x -= Screen.PrimaryScreen.Bounds.Size.Width;
                }
            }
            while (y < 0 || y > Screen.PrimaryScreen.Bounds.Size.Height)
            {
                if (y < 0)
                {
                    y += Screen.PrimaryScreen.Bounds.Size.Height;
                }
                else
                {
                    y -= Screen.PrimaryScreen.Bounds.Size.Height;
                }
            }
            Program.FileSettings.WriteINI("AppLocation", "X", "" + x);
            Program.FileSettings.WriteINI("AppLocation", "Y", "" + y);
        }

        public MainMenuForm()
        {
            InitializeComponent();
            BoxComNames.SelectedIndexChanged += BoxComNames_SelectedIndexChanged;
            BoxComNames.DropDown += BoxComNames_DropDown;
            BoxBaudRate.SelectedIndexChanged += BoxBaudRate_SelectedIndexChanged;
        }

        private void ArduinoControl_Load(object sender, EventArgs e)
        {
            ComNamesUpdate();
            if (Program.FileSettings.KeyExists("AppLocation", "X") && Program.FileSettings.KeyExists("AppLocation", "Y"))
            {
                this.Location = new Point(Convert.ToInt32(Program.FileSettings.ReadINI("AppLocation", "X")), Convert.ToInt32(Program.FileSettings.ReadINI("AppLocation", "Y")));
            }
            else
            {
                SaveLocation(this);
            }
            for (int i = 0; i < 9; i++)
            {
                BoxBaudRate.Items.Insert(i, Program.ComPort.GetBaud(i + 1));
            }
            BoxBaudRate.SelectedIndex = 3;
        }

        private void ButtonStartConnect_Click(object sender, EventArgs e)
        {
            Program.ComPort.SetConfCOMport();
            if (!Program.ComPort.OpenCOMport())
            {
                MessageBox.Show("Error open port " + Program.ComPort.GetCOMportName() + "\nReturn to Settings...");
            }
            else
            {
                ConnectForm = new ComConnectForm();
                Program.FileSettings.WriteINI("AppLocation", "X", "" + this.Location.X);
                Program.FileSettings.WriteINI("AppLocation", "Y", "" + this.Location.Y);
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

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLocation(this);
        }
    }
}
