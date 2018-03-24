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
            this.SuspendLayout();
            // 
            // ComStartConnect
            // 
            this.ComStartConnect.Location = new System.Drawing.Point(12, 59);
            this.ComStartConnect.Name = "ComStartConnect";
            this.ComStartConnect.Size = new System.Drawing.Size(102, 23);
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
            this.BoxComNames.Name = "BoxComNames";
            this.BoxComNames.Size = new System.Drawing.Size(121, 21);
            this.BoxComNames.TabIndex = 1;
            this.toolTripComPortName.SetToolTip(this.BoxComNames, "Active Port Names\r\nThe list is updated when opened");
            // 
            // LabelComPort
            // 
            this.LabelComPort.AutoEllipsis = true;
            this.LabelComPort.Location = new System.Drawing.Point(3, 8);
            this.LabelComPort.Name = "LabelComPort";
            this.LabelComPort.Size = new System.Drawing.Size(67, 13);
            this.LabelComPort.TabIndex = 2;
            this.LabelComPort.Text = "COM port:";
            // 
            // LabelBaudRate
            // 
            this.LabelBaudRate.AutoSize = true;
            this.LabelBaudRate.Location = new System.Drawing.Point(3, 35);
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
            this.BoxBaudRate.Name = "BoxBaudRate";
            this.BoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.BoxBaudRate.TabIndex = 4;
            this.toolTripComPortName.SetToolTip(this.BoxBaudRate, "Connection speed in Baudes\r\nSelect from the list or enter your own value");
            // 
            // ArduinoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(285, 140);
            this.Controls.Add(this.BoxBaudRate);
            this.Controls.Add(this.LabelBaudRate);
            this.Controls.Add(this.LabelComPort);
            this.Controls.Add(this.BoxComNames);
            this.Controls.Add(this.ComStartConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ArduinoControl";
            this.Text = "ArduinoControl";
            this.Load += new System.EventHandler(this.ArduinoControl_Load);
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
    }
}

