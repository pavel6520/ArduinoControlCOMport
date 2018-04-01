namespace ArduinoTerminal
{
    partial class KeySettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySettingsForm));
            this.LabelKeyPressed = new System.Windows.Forms.Label();
            this.TextBoxKeyValSettings = new System.Windows.Forms.RichTextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelKeyPressed
            // 
            this.LabelKeyPressed.Location = new System.Drawing.Point(119, 9);
            this.LabelKeyPressed.Name = "LabelKeyPressed";
            this.LabelKeyPressed.Size = new System.Drawing.Size(100, 13);
            this.LabelKeyPressed.TabIndex = 0;
            this.LabelKeyPressed.Text = "Press the key to set";
            // 
            // TextBoxKeyValSettings
            // 
            this.TextBoxKeyValSettings.Enabled = false;
            this.TextBoxKeyValSettings.Location = new System.Drawing.Point(15, 12);
            this.TextBoxKeyValSettings.Name = "TextBoxKeyValSettings";
            this.TextBoxKeyValSettings.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxKeyValSettings.Size = new System.Drawing.Size(100, 237);
            this.TextBoxKeyValSettings.TabIndex = 1;
            this.TextBoxKeyValSettings.Text = "";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(122, 226);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Enabled = false;
            this.ButtonCancel.Location = new System.Drawing.Point(203, 226);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // KeySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxKeyValSettings);
            this.Controls.Add(this.LabelKeyPressed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeySettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Settings";
            this.Load += new System.EventHandler(this.KeySettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySettingsForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelKeyPressed;
        private System.Windows.Forms.RichTextBox TextBoxKeyValSettings;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
    }
}