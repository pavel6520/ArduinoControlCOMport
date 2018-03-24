namespace ArduinoTerminal
{
    partial class ArduinoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArduinoControl));
            this.ComStartConnect = new System.Windows.Forms.Button();
            this.BoxComNames = new System.Windows.Forms.ComboBox();
            this.LabelComPort = new System.Windows.Forms.Label();
            this.LabelBaudRate = new System.Windows.Forms.Label();
            this.BoxBaudRate = new System.Windows.Forms.ComboBox();
            this.toolTripComPortName = new System.Windows.Forms.ToolTip(this.components);
            this.TypeSend = new System.Windows.Forms.GroupBox();
            this.TypeRead = new System.Windows.Forms.GroupBox();
            this.TypeSendString = new System.Windows.Forms.RadioButton();
            this.SendTypeInt = new System.Windows.Forms.RadioButton();
            this.TypeReadString = new System.Windows.Forms.RadioButton();
            this.TypeReadInt = new System.Windows.Forms.RadioButton();
            this.TypeSend.SuspendLayout();
            this.TypeRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComStartConnect
            // 
            this.ComStartConnect.Location = new System.Drawing.Point(11, 239);
            this.ComStartConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComStartConnect.Name = "ComStartConnect";
            this.ComStartConnect.Size = new System.Drawing.Size(102, 24);
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
            this.BoxComNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxComNames.Name = "BoxComNames";
            this.BoxComNames.Size = new System.Drawing.Size(120, 21);
            this.BoxComNames.TabIndex = 1;
            this.toolTripComPortName.SetToolTip(this.BoxComNames, "Active Port Names\r\nThe list is updated when opened");
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
            this.BoxBaudRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxBaudRate.Name = "BoxBaudRate";
            this.BoxBaudRate.Size = new System.Drawing.Size(120, 21);
            this.BoxBaudRate.TabIndex = 4;
            this.toolTripComPortName.SetToolTip(this.BoxBaudRate, "Connection speed in Baudes\r\nSelect from the list or enter your own value");
            // 
            // TypeSend
            // 
            this.TypeSend.Controls.Add(this.SendTypeInt);
            this.TypeSend.Controls.Add(this.TypeSendString);
            this.TypeSend.Location = new System.Drawing.Point(5, 58);
            this.TypeSend.Name = "TypeSend";
            this.TypeSend.Size = new System.Drawing.Size(95, 69);
            this.TypeSend.TabIndex = 5;
            this.TypeSend.TabStop = false;
            this.TypeSend.Text = "Send Type";
            // 
            // TypeRead
            // 
            this.TypeRead.Controls.Add(this.TypeReadInt);
            this.TypeRead.Controls.Add(this.TypeReadString);
            this.TypeRead.Location = new System.Drawing.Point(106, 58);
            this.TypeRead.Name = "TypeRead";
            this.TypeRead.Size = new System.Drawing.Size(94, 69);
            this.TypeRead.TabIndex = 6;
            this.TypeRead.TabStop = false;
            this.TypeRead.Text = "Type Read";
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
            this.TypeSendString.UseVisualStyleBackColor = true;
            // 
            // SendTypeInt
            // 
            this.SendTypeInt.AutoSize = true;
            this.SendTypeInt.Location = new System.Drawing.Point(8, 44);
            this.SendTypeInt.Name = "SendTypeInt";
            this.SendTypeInt.Size = new System.Drawing.Size(79, 17);
            this.SendTypeInt.TabIndex = 1;
            this.SendTypeInt.Text = "Int (0 - 127)";
            this.SendTypeInt.UseVisualStyleBackColor = true;
            // 
            // TypeReadString
            // 
            this.TypeReadString.AutoSize = true;
            this.TypeReadString.Checked = true;
            this.TypeReadString.Location = new System.Drawing.Point(6, 19);
            this.TypeReadString.Name = "TypeReadString";
            this.TypeReadString.Size = new System.Drawing.Size(52, 17);
            this.TypeReadString.TabIndex = 1;
            this.TypeReadString.TabStop = true;
            this.TypeReadString.Text = "String";
            this.TypeReadString.UseVisualStyleBackColor = true;
            // 
            // TypeReadInt
            // 
            this.TypeReadInt.AutoSize = true;
            this.TypeReadInt.Location = new System.Drawing.Point(6, 43);
            this.TypeReadInt.Name = "TypeReadInt";
            this.TypeReadInt.Size = new System.Drawing.Size(79, 17);
            this.TypeReadInt.TabIndex = 2;
            this.TypeReadInt.Text = "Int (0 - 127)";
            this.TypeReadInt.UseVisualStyleBackColor = true;
            // 
            // ArduinoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(513, 274);
            this.Controls.Add(this.TypeRead);
            this.Controls.Add(this.TypeSend);
            this.Controls.Add(this.BoxBaudRate);
            this.Controls.Add(this.LabelBaudRate);
            this.Controls.Add(this.LabelComPort);
            this.Controls.Add(this.BoxComNames);
            this.Controls.Add(this.ComStartConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ArduinoControl";
            this.Text = "ArduinoControl";
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
        private System.Windows.Forms.ToolTip toolTripComPortName;
        private System.Windows.Forms.GroupBox TypeSend;
        private System.Windows.Forms.GroupBox TypeRead;
        private System.Windows.Forms.RadioButton SendTypeInt;
        private System.Windows.Forms.RadioButton TypeSendString;
        private System.Windows.Forms.RadioButton TypeReadInt;
        private System.Windows.Forms.RadioButton TypeReadString;
    }
}

