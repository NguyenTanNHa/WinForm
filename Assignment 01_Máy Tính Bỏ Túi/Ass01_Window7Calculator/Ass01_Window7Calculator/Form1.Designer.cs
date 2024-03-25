namespace Ass01_Window7Calculator
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            txtScreen = new TextBox();
            btnMC = new Button();
            btnMR = new Button();
            btnMS = new Button();
            btnMCong = new Button();
            btnMTru = new Button();
            btnBackspace = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnCongTru = new Button();
            btnCanBacHai = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnChia = new Button();
            btnPhanTram = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnNhan = new Button();
            btnPhanSo = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnTru = new Button();
            btnBang = new Button();
            btn0 = new Button();
            btnCham = new Button();
            btnCong = new Button();
            groupBox1 = new GroupBox();
            txtChuoiTam = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(427, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(65, 29);
            fileToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // txtScreen
            // 
            txtScreen.BorderStyle = BorderStyle.None;
            txtScreen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScreen.Location = new Point(12, 66);
            txtScreen.Multiline = true;
            txtScreen.Name = "txtScreen";
            txtScreen.ReadOnly = true;
            txtScreen.Size = new Size(394, 40);
            txtScreen.TabIndex = 1;
            txtScreen.Text = "0";
            txtScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMC
            // 
            btnMC.BackColor = SystemColors.ControlLight;
            btnMC.FlatAppearance.BorderColor = Color.Black;
            btnMC.Font = new Font("Microsoft Sans Serif", 12F);
            btnMC.Location = new Point(12, 112);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(74, 65);
            btnMC.TabIndex = 2;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = false;
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.BackColor = SystemColors.ControlLight;
            btnMR.FlatAppearance.BorderColor = Color.Black;
            btnMR.Font = new Font("Microsoft Sans Serif", 12F);
            btnMR.Location = new Point(92, 112);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(74, 65);
            btnMR.TabIndex = 2;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = false;
            btnMR.Click += btnMR_Click;
            // 
            // btnMS
            // 
            btnMS.BackColor = SystemColors.ControlLight;
            btnMS.FlatAppearance.BorderColor = Color.Black;
            btnMS.Font = new Font("Microsoft Sans Serif", 12F);
            btnMS.Location = new Point(172, 112);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(74, 65);
            btnMS.TabIndex = 2;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = false;
            btnMS.Click += btnMS_Click;
            // 
            // btnMCong
            // 
            btnMCong.BackColor = SystemColors.ControlLight;
            btnMCong.FlatAppearance.BorderColor = Color.Black;
            btnMCong.Font = new Font("Microsoft Sans Serif", 12F);
            btnMCong.Location = new Point(252, 112);
            btnMCong.Name = "btnMCong";
            btnMCong.Size = new Size(74, 65);
            btnMCong.TabIndex = 2;
            btnMCong.Text = "M+";
            btnMCong.UseVisualStyleBackColor = false;
            btnMCong.Click += btnMCong_Click;
            // 
            // btnMTru
            // 
            btnMTru.BackColor = SystemColors.ControlLight;
            btnMTru.FlatAppearance.BorderColor = Color.Black;
            btnMTru.Font = new Font("Microsoft Sans Serif", 12F);
            btnMTru.Location = new Point(332, 112);
            btnMTru.Name = "btnMTru";
            btnMTru.Size = new Size(74, 65);
            btnMTru.TabIndex = 2;
            btnMTru.Text = "M-";
            btnMTru.UseVisualStyleBackColor = false;
            btnMTru.Click += btnMTru_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.ControlLight;
            btnBackspace.FlatAppearance.BorderColor = Color.Black;
            btnBackspace.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackspace.Location = new Point(12, 183);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(74, 65);
            btnBackspace.TabIndex = 2;
            btnBackspace.Text = "←";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.ControlLight;
            btnCE.FlatAppearance.BorderColor = Color.Black;
            btnCE.Font = new Font("Microsoft Sans Serif", 12F);
            btnCE.Location = new Point(92, 183);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(74, 65);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.ControlLight;
            btnC.FlatAppearance.BorderColor = Color.Black;
            btnC.Font = new Font("Microsoft Sans Serif", 12F);
            btnC.Location = new Point(172, 183);
            btnC.Name = "btnC";
            btnC.Size = new Size(74, 65);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCongTru
            // 
            btnCongTru.BackColor = SystemColors.ControlLight;
            btnCongTru.FlatAppearance.BorderColor = Color.Black;
            btnCongTru.Font = new Font("Microsoft Sans Serif", 16F);
            btnCongTru.Location = new Point(252, 183);
            btnCongTru.Name = "btnCongTru";
            btnCongTru.Size = new Size(74, 65);
            btnCongTru.TabIndex = 2;
            btnCongTru.Text = "±";
            btnCongTru.UseVisualStyleBackColor = false;
            btnCongTru.Click += btnCongTru_Click;
            // 
            // btnCanBacHai
            // 
            btnCanBacHai.BackColor = SystemColors.ControlLight;
            btnCanBacHai.FlatAppearance.BorderColor = Color.Black;
            btnCanBacHai.Font = new Font("Microsoft Sans Serif", 12F);
            btnCanBacHai.Location = new Point(332, 183);
            btnCanBacHai.Name = "btnCanBacHai";
            btnCanBacHai.Size = new Size(74, 65);
            btnCanBacHai.TabIndex = 2;
            btnCanBacHai.Text = "√";
            btnCanBacHai.UseVisualStyleBackColor = false;
            btnCanBacHai.Click += btnCanBacHai_Click;
            // 
            // btn7
            // 
            btn7.FlatAppearance.BorderColor = Color.Black;
            btn7.Font = new Font("Segoe UI", 20F);
            btn7.Location = new Point(12, 254);
            btn7.Name = "btn7";
            btn7.Size = new Size(74, 65);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButtons;
            // 
            // btn8
            // 
            btn8.FlatAppearance.BorderColor = Color.Black;
            btn8.Font = new Font("Segoe UI", 20F);
            btn8.Location = new Point(92, 254);
            btn8.Name = "btn8";
            btn8.Size = new Size(74, 65);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButtons;
            // 
            // btn9
            // 
            btn9.FlatAppearance.BorderColor = Color.Black;
            btn9.Font = new Font("Segoe UI", 20F);
            btn9.Location = new Point(172, 254);
            btn9.Name = "btn9";
            btn9.Size = new Size(74, 65);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButtons;
            // 
            // btnChia
            // 
            btnChia.BackColor = SystemColors.ControlLight;
            btnChia.FlatAppearance.BorderColor = Color.Black;
            btnChia.Font = new Font("Microsoft Sans Serif", 16F);
            btnChia.Location = new Point(252, 254);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(74, 65);
            btnChia.TabIndex = 2;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = false;
            btnChia.Click += Operations;
            // 
            // btnPhanTram
            // 
            btnPhanTram.BackColor = SystemColors.ControlLight;
            btnPhanTram.FlatAppearance.BorderColor = Color.Black;
            btnPhanTram.Font = new Font("Microsoft Sans Serif", 12F);
            btnPhanTram.Location = new Point(332, 254);
            btnPhanTram.Name = "btnPhanTram";
            btnPhanTram.Size = new Size(74, 65);
            btnPhanTram.TabIndex = 2;
            btnPhanTram.Text = "%";
            btnPhanTram.UseVisualStyleBackColor = false;
            btnPhanTram.Click += btnPhanTram_Click;
            // 
            // btn4
            // 
            btn4.FlatAppearance.BorderColor = Color.Black;
            btn4.Font = new Font("Segoe UI", 20F);
            btn4.Location = new Point(12, 325);
            btn4.Name = "btn4";
            btn4.Size = new Size(74, 65);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButtons;
            // 
            // btn5
            // 
            btn5.FlatAppearance.BorderColor = Color.Black;
            btn5.Font = new Font("Segoe UI", 20F);
            btn5.Location = new Point(92, 325);
            btn5.Name = "btn5";
            btn5.Size = new Size(74, 65);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButtons;
            // 
            // btn6
            // 
            btn6.FlatAppearance.BorderColor = Color.Black;
            btn6.Font = new Font("Segoe UI", 20F);
            btn6.Location = new Point(172, 325);
            btn6.Name = "btn6";
            btn6.Size = new Size(74, 65);
            btn6.TabIndex = 2;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButtons;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = SystemColors.ControlLight;
            btnNhan.FlatAppearance.BorderColor = Color.Black;
            btnNhan.Font = new Font("Microsoft Sans Serif", 16F);
            btnNhan.Location = new Point(252, 325);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(74, 65);
            btnNhan.TabIndex = 2;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += Operations;
            // 
            // btnPhanSo
            // 
            btnPhanSo.BackColor = SystemColors.ControlLight;
            btnPhanSo.FlatAppearance.BorderColor = Color.Black;
            btnPhanSo.Font = new Font("Microsoft Sans Serif", 12F);
            btnPhanSo.Location = new Point(332, 325);
            btnPhanSo.Name = "btnPhanSo";
            btnPhanSo.Size = new Size(74, 65);
            btnPhanSo.TabIndex = 2;
            btnPhanSo.Text = "1/x";
            btnPhanSo.UseVisualStyleBackColor = false;
            btnPhanSo.Click += btnPhanSo_Click;
            // 
            // btn1
            // 
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.Font = new Font("Segoe UI", 20F);
            btn1.Location = new Point(12, 396);
            btn1.Name = "btn1";
            btn1.Size = new Size(74, 65);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButtons;
            // 
            // btn2
            // 
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn2.Font = new Font("Segoe UI", 20F);
            btn2.Location = new Point(92, 396);
            btn2.Name = "btn2";
            btn2.Size = new Size(74, 65);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButtons;
            // 
            // btn3
            // 
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn3.Font = new Font("Segoe UI", 20F);
            btn3.Location = new Point(172, 396);
            btn3.Name = "btn3";
            btn3.Size = new Size(74, 65);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButtons;
            // 
            // btnTru
            // 
            btnTru.BackColor = SystemColors.ControlLight;
            btnTru.FlatAppearance.BorderColor = Color.Black;
            btnTru.Font = new Font("Microsoft Sans Serif", 16F);
            btnTru.Location = new Point(252, 396);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(74, 65);
            btnTru.TabIndex = 2;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += Operations;
            // 
            // btnBang
            // 
            btnBang.BackColor = SystemColors.ControlLight;
            btnBang.FlatAppearance.BorderColor = Color.Black;
            btnBang.Font = new Font("Microsoft Sans Serif", 16F);
            btnBang.Location = new Point(332, 396);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(74, 136);
            btnBang.TabIndex = 2;
            btnBang.Text = "=";
            btnBang.UseVisualStyleBackColor = false;
            btnBang.Click += btnBang_Click;
            // 
            // btn0
            // 
            btn0.FlatAppearance.BorderColor = Color.Black;
            btn0.Font = new Font("Segoe UI", 20F);
            btn0.Location = new Point(12, 467);
            btn0.Name = "btn0";
            btn0.Size = new Size(154, 65);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButtons;
            // 
            // btnCham
            // 
            btnCham.FlatAppearance.BorderColor = Color.Black;
            btnCham.Font = new Font("Microsoft Sans Serif", 16F);
            btnCham.Location = new Point(172, 467);
            btnCham.Name = "btnCham";
            btnCham.Size = new Size(74, 65);
            btnCham.TabIndex = 2;
            btnCham.Text = ".";
            btnCham.UseVisualStyleBackColor = true;
            btnCham.Click += btnCham_Click;
            // 
            // btnCong
            // 
            btnCong.BackColor = SystemColors.ControlLight;
            btnCong.FlatAppearance.BorderColor = Color.Black;
            btnCong.Font = new Font("Microsoft Sans Serif", 16F);
            btnCong.Location = new Point(252, 467);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(74, 65);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += Operations;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChuoiTam);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 70);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txtChuoiTam
            // 
            txtChuoiTam.BorderStyle = BorderStyle.None;
            txtChuoiTam.Location = new Point(0, 0);
            txtChuoiTam.Name = "txtChuoiTam";
            txtChuoiTam.ReadOnly = true;
            txtChuoiTam.Size = new Size(394, 24);
            txtChuoiTam.TabIndex = 0;
            txtChuoiTam.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(427, 551);
            Controls.Add(btnBang);
            Controls.Add(btnPhanSo);
            Controls.Add(btnPhanTram);
            Controls.Add(btnCanBacHai);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnMTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnCongTru);
            Controls.Add(btnCham);
            Controls.Add(btn3);
            Controls.Add(btnMCong);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnC);
            Controls.Add(btn2);
            Controls.Add(btnMS);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btnCE);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btnMR);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnBackspace);
            Controls.Add(btnMC);
            Controls.Add(txtScreen);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox txtScreen;
        private Button btnMC;
        private Button btnMR;
        private Button btnMS;
        private Button btnMCong;
        private Button btnMTru;
        private Button btnBackspace;
        private Button btnCE;
        private Button btnC;
        private Button btnCongTru;
        private Button btnCanBacHai;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnChia;
        private Button btnPhanTram;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnNhan;
        private Button btnPhanSo;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnTru;
        private Button btnBang;
        private Button btn0;
        private Button btnCham;
        private Button btnCong;
        private GroupBox groupBox1;
        private TextBox txtChuoiTam;
    }
}
