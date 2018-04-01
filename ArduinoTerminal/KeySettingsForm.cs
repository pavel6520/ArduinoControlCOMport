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
    public partial class KeySettingsForm : Form
    {
        private int countVal;
        private int KeyPressed;

        public KeySettingsForm()
        {
            InitializeComponent();
        }

        private void KeySettingsForm_Load(object sender, EventArgs e)
        {
            this.Location = Program.MainForm.Location;
        }

        private void KeySettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (!TextBoxKeyValSettings.Enabled)
            {
                ButtonSave.Enabled = true;
                ButtonCancel.Enabled = true;
                TextBoxKeyValSettings.Enabled = true;
                LabelKeyPressed.Text = "Selected key: " + e.KeyCode;
                KeyPressed = e.KeyValue;
                if (Program.FileSettings.KeyExists("Key" + KeyPressed, "countVal") && Program.FileSettings.ReadINI("Key" + KeyPressed, "countVal").Length > 0)
                {
                    countVal = Convert.ToInt32(Program.FileSettings.ReadINI("Key" + KeyPressed, "countVal"));
                    for (int i = 0; i < countVal; i++)
                    {
                        TextBoxKeyValSettings.AppendText(Program.FileSettings.ReadINI("Key" + KeyPressed, "Val" + i));
                        if (countVal - 1 != i)
                        {
                            TextBoxKeyValSettings.AppendText("\n");
                        }
                    }
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            countVal = TextBoxKeyValSettings.Lines.Length;
            for (int i = 0; i < countVal; i++)
            {
                try
                {
                    if(Convert.ToInt32(TextBoxKeyValSettings.Lines[i].ToString()) < 0 || Convert.ToInt32(TextBoxKeyValSettings.Lines[i].ToString()) > 127)
                    {
                        MessageBox.Show("Error in line " + (i + 1) + ": " + TextBoxKeyValSettings.Lines[i].ToString() + "\nError value. Format: 0 - 127");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error in line " + (i + 1) + ": " + TextBoxKeyValSettings.Lines[i].ToString() + "\nError value. Format: 0 - 127");
                    return;
                }
            }
            if(countVal > 0)
            {
                Program.FileSettings.DeleteSection("Key" + KeyPressed);
                Program.FileSettings.WriteINI("Key" + KeyPressed, "countVal", countVal + "");
                for (int i = 0; i < countVal; i++)
                {
                    Program.FileSettings.WriteINI("Key" + KeyPressed, "Val" + i, TextBoxKeyValSettings.Lines[i].ToString());
                }
                TextBoxKeyValSettings.Text = "";
            }
            else
            {
                Program.FileSettings.DeleteSection("Key" + KeyPressed);
            }
            TextBoxKeyValSettings.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonCancel.Enabled = false;
            LabelKeyPressed.Text = "Press the key to set";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            countVal = 0;
            TextBoxKeyValSettings.Text = "";
            TextBoxKeyValSettings.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonCancel.Enabled = false;
            LabelKeyPressed.Text = "Press the key to set";
        }
    }
}
