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
    public partial class ComConnect : Form
    {
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
        }

        private void TextSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Program.ComPort.WriteCOMport(TextSend.Text, true);
                ConsoleBox.AppendText(TextSend.Text + "\n");
                TextSend.Text = "";
                
            }
        }

        private void TextSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;
        }
    }
}
