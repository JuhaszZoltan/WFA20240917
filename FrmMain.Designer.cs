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
            lblTime = new Label();
            lblCatches = new Label();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.AutoSize = true;
            pnlMain.BackColor = Color.Gainsboro;
            pnlMain.Controls.Add(btnClickMe);
            pnlMain.Location = new Point(12, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(481, 363);
            pnlMain.TabIndex = 0;
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = Color.IndianRed;
            btnClickMe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClickMe.ForeColor = Color.White;
            btnClickMe.Location = new Point(3, 3);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(100, 100);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click me!";
            btnClickMe.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.Font = new Font("Consolas", 20F, FontStyle.Bold);
            lblTime.Location = new Point(330, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(163, 48);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCatches
            // 
            lblCatches.Font = new Font("Consolas", 20F, FontStyle.Bold);
            lblCatches.Location = new Point(12, 9);
            lblCatches.Name = "lblCatches";
            lblCatches.Size = new Size(209, 48);
            lblCatches.TabIndex = 1;
            lblCatches.Text = "catches: 00";
            lblCatches.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 516);
            Controls.Add(lblCatches);
            Controls.Add(lblTime);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(400, 400);
            Name = "FrmMain";
            Text = "Catch me!";
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private Button btnClickMe;
        private Label lblTime;
        private Label lblCatches;
    }
}
