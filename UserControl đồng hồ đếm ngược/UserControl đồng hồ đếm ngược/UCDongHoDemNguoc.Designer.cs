namespace UserControl_đồng_hồ_đếm_ngược
{
    partial class UCDongHoDemNguoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(172, 318);
            button1.Name = "button1";
            button1.Size = new Size(99, 39);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.CausesValidation = false;
            textBox1.Font = new Font("Symbol", 30F, FontStyle.Bold);
            textBox1.Location = new Point(122, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 57);
            textBox1.TabIndex = 1;
            textBox1.Text = "00:00:00";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 27);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(296, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(120, 27);
            comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label1.Location = new Point(188, 46);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 4;
            label1.Text = "Minites";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label2.Location = new Point(322, 46);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 5;
            label2.Text = "Seconds";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label3.Location = new Point(53, 46);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 6;
            label3.Text = "Hours";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            comboBox3.FormattingEnabled = true;
            comboBox3.ImeMode = ImeMode.NoControl;
            comboBox3.Location = new Point(24, 68);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(120, 27);
            comboBox3.TabIndex = 7;
            // 
            // UCDongHoDemNguoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "UCDongHoDemNguoc";
            Size = new Size(450, 400);
            Load += UCDongHoDemNguoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private ComboBox comboBox3;
    }
}
