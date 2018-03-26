namespace ArduinoTerminal
{
    partial class ComConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComConnect));
            this.TextSend = new System.Windows.Forms.TextBox();
            this.ConsoleBox = new System.Windows.Forms.RichTextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextSend
            // 
            this.TextSend.AllowDrop = true;
            this.TextSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSend.BackColor = System.Drawing.Color.Black;
            this.TextSend.ForeColor = System.Drawing.Color.Cyan;
            this.TextSend.Location = new System.Drawing.Point(0, 239);
            this.TextSend.Margin = new System.Windows.Forms.Padding(4);
            this.TextSend.Name = "TextSend";
            this.TextSend.Size = new System.Drawing.Size(323, 21);
            this.TextSend.TabIndex = 0;
            this.TextSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSend_KeyPress);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleBox.BackColor = System.Drawing.Color.Black;
            this.ConsoleBox.DetectUrls = false;
            this.ConsoleBox.ForeColor = System.Drawing.Color.Cyan;
            this.ConsoleBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ConsoleBox.Size = new System.Drawing.Size(386, 240);
            this.ConsoleBox.TabIndex = 1;
            this.ConsoleBox.Text = "";
            // 
            // ButtonSend
            // 
            this.ButtonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSend.Location = new System.Drawing.Point(321, 239);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(65, 21);
            this.ButtonSend.TabIndex = 2;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // ComConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.TextSend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "ComConnect";
            this.Text = "ComConnect";
            this.Load += new System.EventHandler(this.ComConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSend;
        private System.Windows.Forms.RichTextBox ConsoleBox;
        private System.Windows.Forms.Button ButtonSend;
    }
}