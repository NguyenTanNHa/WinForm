namespace UserControl_đồng_hồ_đếm_ngược
{
    partial class Form1
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
            ucDongHoDemNguoc2 = new UCDongHoDemNguoc();
            SuspendLayout();
            // 
            // ucDongHoDemNguoc2
            // 
            ucDongHoDemNguoc2.BackColor = SystemColors.Info;
            ucDongHoDemNguoc2.Location = new Point(66, 12);
            ucDongHoDemNguoc2.Name = "ucDongHoDemNguoc2";
            ucDongHoDemNguoc2.Size = new Size(450, 400);
            ucDongHoDemNguoc2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 418);
            Controls.Add(ucDongHoDemNguoc2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private UCDongHoDemNguoc ucDongHoDemNguoc1;
        private UCDongHoDemNguoc ucDongHoDemNguoc2;
    }
}
