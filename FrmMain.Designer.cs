namespace WFA20240917
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            btnClickMe = new Button();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.AutoSize = true;
            pnlMain.BackColor = Color.Gainsboro;
            pnlMain.Controls.Add(btnClickMe);
            pnlMain.Location = new Point(12, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(860, 837);
            pnlMain.TabIndex = 0;
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = Color.IndianRed;
            btnClickMe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClickMe.ForeColor = Color.White;
            btnClickMe.Location = new Point(0, 0);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(100, 100);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click me!";
            btnClickMe.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "Form1";
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private Button btnClickMe;
    }
}
