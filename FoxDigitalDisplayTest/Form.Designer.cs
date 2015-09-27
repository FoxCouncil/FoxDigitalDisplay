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
            this.foxDigitalDisplay2 = new com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay();
            this.SuspendLayout();
            // 
            // foxDigitalDisplay2
            // 
            this.foxDigitalDisplay2.DisplayHeight = 1;
            this.foxDigitalDisplay2.DisplayWidth = 42;
            this.foxDigitalDisplay2.DrawDepth = 2;
            this.foxDigitalDisplay2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foxDigitalDisplay2.Location = new System.Drawing.Point(12, 12);
            this.foxDigitalDisplay2.Name = "foxDigitalDisplay2";
            this.foxDigitalDisplay2.Size = new System.Drawing.Size(840, 28);
            this.foxDigitalDisplay2.TabIndex = 0;
            this.foxDigitalDisplay2.Text = "Hello World 420";
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(861, 50);
            this.Controls.Add(this.foxDigitalDisplay2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fox Digital Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private com.FoxCouncil.FoxDigitalDisplay.FoxDigitalDisplay foxDigitalDisplay2;
    }
}

