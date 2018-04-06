﻿namespace ArduinoTerminal
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.ComStartConnect = new System.Windows.Forms.Button();
            this.BoxComNames = new System.Windows.Forms.ComboBox();
            this.LabelComPort = new System.Windows.Forms.Label();
            this.LabelBaudRate = new System.Windows.Forms.Label();
            this.BoxBaudRate = new System.Windows.Forms.ComboBox();
            this.toolTrip = new System.Windows.Forms.ToolTip(this.components);
            this.CaptureModeCheckBox = new System.Windows.Forms.CheckBox();
            this.TypeSend = new System.Windows.Forms.GroupBox();
            this.TypeSendNewLine = new System.Windows.Forms.CheckBox();
            this.TypeSendInt = new System.Windows.Forms.RadioButton();
            this.TypeSendString = new System.Windows.Forms.RadioButton();
            this.TypeRead = new System.Windows.Forms.GroupBox();
            this.TypeReadInt = new System.Windows.Forms.RadioButton();
            this.TypeReadChar = new System.Windows.Forms.RadioButton();
            this.ButtonKeySettings = new System.Windows.Forms.Button();
            this.TypeSend.SuspendLayout();
            this.TypeRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComStartConnect
            // 
            this.ComStartConnect.Location = new System.Drawing.Point(11, 80);
            this.ComStartConnect.Margin = new System.Windows.Forms.Padding(2);
            this.ComStartConnect.Name = "ComStartConnect";
            this.ComStartConnect.Size = new System.Drawing.Size(89, 24);
            this.ComStartConnect.TabIndex = 0;
            this.ComStartConnect.Text = "Connect";
            this.ComStartConnect.UseVisualStyleBackColor = true;
            this.ComStartConnect.Click += new System.EventHandler(this.ButtonStartConnect_Click);
            // 
            // BoxComNames
            // 
            this.BoxComNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxComNames.FormattingEnabled = true;
            this.BoxComNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BoxComNames.Location = new System.Drawing.Point(73, 5);
            this.BoxComNames.Margin = new System.Windows.Forms.Padding(2);
            this.BoxComNames.Name = "BoxComNames";
            this.BoxComNames.Size = new System.Drawing.Size(120, 21);
            this.BoxComNames.TabIndex = 1;
            this.toolTrip.SetToolTip(this.BoxComNames, "Active Port Names\r\nThe list is updated when opened");
            // 
            // LabelComPort
            // 
            this.LabelComPort.AutoEllipsis = true;
            this.LabelComPort.Location = new System.Drawing.Point(2, 8);
            this.LabelComPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelComPort.Name = "LabelComPort";
            this.LabelComPort.Size = new System.Drawing.Size(67, 13);
            this.LabelComPort.TabIndex = 2;
            this.LabelComPort.Text = "COM port:";
            // 
            // LabelBaudRate
            // 
            this.LabelBaudRate.AutoSize = true;
            this.LabelBaudRate.Location = new System.Drawing.Point(2, 35);
            this.LabelBaudRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBaudRate.Name = "LabelBaudRate";
            this.LabelBaudRate.Size = new System.Drawing.Size(58, 13);
            this.LabelBaudRate.TabIndex = 3;
            this.LabelBaudRate.Text = "BaudRate:";
            // 
            // BoxBaudRate
            // 
            this.BoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxBaudRate.FormattingEnabled = true;
            this.BoxBaudRate.Location = new System.Drawing.Point(73, 32);
            this.BoxBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.BoxBaudRate.Name = "BoxBaudRate";
            this.BoxBaudRate.Size = new System.Drawing.Size(120, 21);
            this.BoxBaudRate.TabIndex = 4;
            this.toolTrip.SetToolTip(this.BoxBaudRate, "Connection speed in Baudes\r\nSelect from the list or enter your own value");
            // 
            // toolTrip
            // 
            this.toolTrip.AutoPopDelay = 5000;
            this.toolTrip.InitialDelay = 300;
            this.toolTrip.ReshowDelay = 100;
            // 
            // CaptureModeCheckBox
            // 
            this.CaptureModeCheckBox.AutoSize = true;
            this.CaptureModeCheckBox.Location = new System.Drawing.Point(12, 58);
            this.CaptureModeCheckBox.Name = "CaptureModeCheckBox";
            this.CaptureModeCheckBox.Size = new System.Drawing.Size(111, 17);
            this.CaptureModeCheckBox.TabIndex = 7;
            this.CaptureModeCheckBox.Text = "CaptureKey Mode";
            this.toolTrip.SetToolTip(this.CaptureModeCheckBox, "For start capturing the key, activate (press) the text output box.\r\n");
            this.CaptureModeCheckBox.UseVisualStyleBackColor = true;
            this.CaptureModeCheckBox.CheckedChanged += new System.EventHandler(this.CaptureModeCheckBox_CheckedChanged);
            // 
            // TypeSend
            // 
            this.TypeSend.Controls.Add(this.TypeSendNewLine);
            this.TypeSend.Controls.Add(this.TypeSendInt);
            this.TypeSend.Controls.Add(this.TypeSendString);
            this.TypeSend.Location = new System.Drawing.Point(198, 8);
            this.TypeSend.Name = "TypeSend";
            this.TypeSend.Size = new System.Drawing.Size(95, 94);
            this.TypeSend.TabIndex = 5;
            this.TypeSend.TabStop = false;
            this.TypeSend.Text = "Send Type";
            this.toolTrip.SetToolTip(this.TypeSend, "The COM port passes characters between devices.\r\nIf you translate a character int" +
        "o a numeric representation,\r\nyou will get a number from 0 to 127.");
            // 
            // TypeSendNewLine
            // 
            this.TypeSendNewLine.AutoSize = true;
            this.TypeSendNewLine.Checked = true;
            this.TypeSendNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeSendNewLine.Location = new System.Drawing.Point(8, 68);
            this.TypeSendNewLine.Name = "TypeSendNewLine";
            this.TypeSendNewLine.Size = new System.Drawing.Size(68, 17);
            this.TypeSendNewLine.TabIndex = 2;
            this.TypeSendNewLine.Text = "NewLine";
            this.toolTrip.SetToolTip(this.TypeSendNewLine, "Indicates whether a carriage return character is sent each time the line is sent." +
        "");
            this.TypeSendNewLine.UseVisualStyleBackColor = true;
            this.TypeSendNewLine.CheckedChanged += new System.EventHandler(this.TypeSendNewLine_CheckedChanged);
            // 
            // TypeSendInt
            // 
            this.TypeSendInt.AutoSize = true;
            this.TypeSendInt.Location = new System.Drawing.Point(8, 44);
            this.TypeSendInt.Name = "TypeSendInt";
            this.TypeSendInt.Size = new System.Drawing.Size(79, 17);
            this.TypeSendInt.TabIndex = 1;
            this.TypeSendInt.Text = "Int (0 - 127)";
            this.toolTrip.SetToolTip(this.TypeSendInt, "The program will receive the number you entered (0 - 127) and send it to the COM " +
        "port as a symbol.\r\nThe processing of the transmitted number is on the receiving " +
        "device.");
            this.TypeSendInt.UseVisualStyleBackColor = true;
            // 
            // TypeSendString
            // 
            this.TypeSendString.AutoSize = true;
            this.TypeSendString.Checked = true;
            this.TypeSendString.Location = new System.Drawing.Point(8, 20);
            this.TypeSendString.Name = "TypeSendString";
            this.TypeSendString.Size = new System.Drawing.Size(52, 17);
            this.TypeSendString.TabIndex = 0;
            this.TypeSendString.TabStop = true;
            this.TypeSendString.Text = "String";
            this.toolTrip.SetToolTip(this.TypeSendString, "The program receives the line you typed and sends it to the COM port.");
            this.TypeSendString.UseVisualStyleBackColor = true;
            this.TypeSendString.CheckedChanged += new System.EventHandler(this.TypeSendString_CheckedChanged);
            // 
            // TypeRead
            // 
            this.TypeRead.Controls.Add(this.TypeReadInt);
            this.TypeRead.Controls.Add(this.TypeReadChar);
            this.TypeRead.Location = new System.Drawing.Point(299, 8);
            this.TypeRead.Name = "TypeRead";
            this.TypeRead.Size = new System.Drawing.Size(94, 94);
            this.TypeRead.TabIndex = 6;
            this.TypeRead.TabStop = false;
            this.TypeRead.Text = "Read Type";
            this.toolTrip.SetToolTip(this.TypeRead, "The COM port passes characters between devices.\r\nIf you translate a character int" +
        "o a numeric representation,\r\nyou will get a number from 0 to 127.");
            // 
            // TypeReadInt
            // 
            this.TypeReadInt.AutoSize = true;
            this.TypeReadInt.Location = new System.Drawing.Point(6, 43);
            this.TypeReadInt.Name = "TypeReadInt";
            this.TypeReadInt.Size = new System.Drawing.Size(79, 17);
            this.TypeReadInt.TabIndex = 2;
            this.TypeReadInt.Text = "Int (0 - 127)";
            this.toolTrip.SetToolTip(this.TypeReadInt, "The program will receive a number (0 - 127) from the COM port and display it.");
            this.TypeReadInt.UseVisualStyleBackColor = true;
            // 
            // TypeReadChar
            // 
            this.TypeReadChar.AutoSize = true;
            this.TypeReadChar.Checked = true;
            this.TypeReadChar.Location = new System.Drawing.Point(6, 19);
            this.TypeReadChar.Name = "TypeReadChar";
            this.TypeReadChar.Size = new System.Drawing.Size(47, 17);
            this.TypeReadChar.TabIndex = 1;
            this.TypeReadChar.TabStop = true;
            this.TypeReadChar.Text = "Char";
            this.toolTrip.SetToolTip(this.TypeReadChar, "The program reads 1 character from the COM port and displays it on the screen.\r\nT" +
        "he transition to a new line is carried out only when the carriage return charact" +
        "er is received.");
            this.TypeReadChar.UseVisualStyleBackColor = true;
            this.TypeReadChar.CheckedChanged += new System.EventHandler(this.TypeReadChar_CheckedChanged);
            // 
            // ButtonKeySettings
            // 
            this.ButtonKeySettings.Enabled = false;
            this.ButtonKeySettings.Location = new System.Drawing.Point(106, 80);
            this.ButtonKeySettings.Name = "ButtonKeySettings";
            this.ButtonKeySettings.Size = new System.Drawing.Size(75, 23);
            this.ButtonKeySettings.TabIndex = 8;
            this.ButtonKeySettings.Text = "Key Settings";
            this.toolTrip.SetToolTip(this.ButtonKeySettings, "Configure the data sent by keystrokes\r\n");
            this.ButtonKeySettings.UseVisualStyleBackColor = true;
            this.ButtonKeySettings.Click += new System.EventHandler(this.ButtonKeySettings_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(404, 110);
            this.Controls.Add(this.ButtonKeySettings);
            this.Controls.Add(this.CaptureModeCheckBox);
            this.Controls.Add(this.TypeRead);
            this.Controls.Add(this.TypeSend);
            this.Controls.Add(this.BoxBaudRate);
            this.Controls.Add(this.LabelBaudRate);
            this.Controls.Add(this.LabelComPort);
            this.Controls.Add(this.BoxComNames);
            this.Controls.Add(this.ComStartConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArduinoControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.ArduinoControl_Load);
            this.TypeSend.ResumeLayout(false);
            this.TypeSend.PerformLayout();
            this.TypeRead.ResumeLayout(false);
            this.TypeRead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComStartConnect;
        private System.Windows.Forms.ComboBox BoxComNames;
        private System.Windows.Forms.Label LabelComPort;
        private System.Windows.Forms.Label LabelBaudRate;
        private System.Windows.Forms.ComboBox BoxBaudRate;
        private System.Windows.Forms.ToolTip toolTrip;
        private System.Windows.Forms.GroupBox TypeSend;
        private System.Windows.Forms.GroupBox TypeRead;
        private System.Windows.Forms.RadioButton TypeSendInt;
        private System.Windows.Forms.RadioButton TypeSendString;
        private System.Windows.Forms.RadioButton TypeReadInt;
        private System.Windows.Forms.RadioButton TypeReadChar;
        private System.Windows.Forms.CheckBox TypeSendNewLine;
        private System.Windows.Forms.CheckBox CaptureModeCheckBox;
        private System.Windows.Forms.Button ButtonKeySettings;
    }
}

