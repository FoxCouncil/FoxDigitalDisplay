namespace FoxDigitalDisplayTest
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.foxDigitalDisplay1 = new com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay();
            this.foxDigitalDisplay2 = new com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay();
            this.foxDigitalDisplay3 = new com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay();
            this.foxDigitalDisplay4 = new com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // foxDigitalDisplay1
            // 
            this.foxDigitalDisplay1.BackColor = System.Drawing.Color.Black;
            this.foxDigitalDisplay1.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.foxDigitalDisplay1.DisplayForeColor = System.Drawing.Color.Red;
            this.foxDigitalDisplay1.DisplayHeight = 1;
            this.foxDigitalDisplay1.DisplayWidth = 52;
            this.foxDigitalDisplay1.DrawDepth = 2;
            this.foxDigitalDisplay1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foxDigitalDisplay1.Location = new System.Drawing.Point(12, 12);
            this.foxDigitalDisplay1.Name = "foxDigitalDisplay1";
            this.foxDigitalDisplay1.PixelPadding = 1;
            this.foxDigitalDisplay1.Size = new System.Drawing.Size(832, 22);
            this.foxDigitalDisplay1.TabIndex = 0;
            this.foxDigitalDisplay1.Text = "Hello World";
            // 
            // foxDigitalDisplay2
            // 
            this.foxDigitalDisplay2.BackColor = System.Drawing.Color.Black;
            this.foxDigitalDisplay2.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.foxDigitalDisplay2.DisplayForeColor = System.Drawing.Color.Red;
            this.foxDigitalDisplay2.DisplayHeight = 1;
            this.foxDigitalDisplay2.DisplayWidth = 24;
            this.foxDigitalDisplay2.DrawDepth = 2;
            this.foxDigitalDisplay2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foxDigitalDisplay2.Location = new System.Drawing.Point(12, 46);
            this.foxDigitalDisplay2.Name = "foxDigitalDisplay2";
            this.foxDigitalDisplay2.PixelPadding = 1;
            this.foxDigitalDisplay2.Size = new System.Drawing.Size(384, 22);
            this.foxDigitalDisplay2.TabIndex = 1;
            this.foxDigitalDisplay2.Text = resources.GetString("foxDigitalDisplay2.Text");
            // 
            // foxDigitalDisplay3
            // 
            this.foxDigitalDisplay3.BackColor = System.Drawing.Color.Black;
            this.foxDigitalDisplay3.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.foxDigitalDisplay3.DisplayForeColor = System.Drawing.Color.Red;
            this.foxDigitalDisplay3.DisplayHeight = 1;
            this.foxDigitalDisplay3.DisplayWidth = 26;
            this.foxDigitalDisplay3.DrawDepth = 2;
            this.foxDigitalDisplay3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foxDigitalDisplay3.Location = new System.Drawing.Point(428, 46);
            this.foxDigitalDisplay3.Name = "foxDigitalDisplay3";
            this.foxDigitalDisplay3.PixelPadding = 1;
            this.foxDigitalDisplay3.Size = new System.Drawing.Size(416, 22);
            this.foxDigitalDisplay3.TabIndex = 2;
            this.foxDigitalDisplay3.Text = resources.GetString("foxDigitalDisplay3.Text");
            // 
            // foxDigitalDisplay4
            // 
            this.foxDigitalDisplay4.BackColor = System.Drawing.Color.Black;
            this.foxDigitalDisplay4.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.foxDigitalDisplay4.DisplayForeColor = System.Drawing.Color.Red;
            this.foxDigitalDisplay4.DisplayHeight = 1;
            this.foxDigitalDisplay4.DisplayWidth = 52;
            this.foxDigitalDisplay4.DrawDepth = 2;
            this.foxDigitalDisplay4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foxDigitalDisplay4.Location = new System.Drawing.Point(12, 81);
            this.foxDigitalDisplay4.Name = "foxDigitalDisplay4";
            this.foxDigitalDisplay4.PixelPadding = 1;
            this.foxDigitalDisplay4.Size = new System.Drawing.Size(832, 22);
            this.foxDigitalDisplay4.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(861, 115);
            this.Controls.Add(this.foxDigitalDisplay4);
            this.Controls.Add(this.foxDigitalDisplay3);
            this.Controls.Add(this.foxDigitalDisplay2);
            this.Controls.Add(this.foxDigitalDisplay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fox Digital Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay foxDigitalDisplay1;
        private com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay foxDigitalDisplay2;
        private com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay foxDigitalDisplay3;
        private com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay foxDigitalDisplay4;
        private System.Windows.Forms.Timer timer1;
    }
}

