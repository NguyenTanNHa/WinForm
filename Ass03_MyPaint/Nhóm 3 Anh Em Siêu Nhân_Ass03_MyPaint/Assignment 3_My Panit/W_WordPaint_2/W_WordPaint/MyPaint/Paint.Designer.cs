using System.Windows.Forms;

namespace MyPaint
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnFillColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NudBorderSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBorderColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGPỉctureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIFPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsDesktopBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInCtrlPageUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutCtrlPageDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thumbnailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBorderSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.BtnXoa);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.rd2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rd1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CboType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Pen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.BtnXoa, "BtnXoa");
            this.BtnXoa.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnFillColor);
            this.groupBox3.Controls.Add(this.label8);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // BtnFillColor
            // 
            this.BtnFillColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.BtnFillColor, "BtnFillColor");
            this.BtnFillColor.Name = "BtnFillColor";
            this.BtnFillColor.UseVisualStyleBackColor = false;
            this.BtnFillColor.Click += new System.EventHandler(this.BtnFillColor_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NudBorderSize);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnBorderColor);
            this.groupBox2.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // NudBorderSize
            // 
            resources.ApplyResources(this.NudBorderSize, "NudBorderSize");
            this.NudBorderSize.Name = "NudBorderSize";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // BtnBorderColor
            // 
            this.BtnBorderColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.BtnBorderColor, "BtnBorderColor");
            this.BtnBorderColor.Name = "BtnBorderColor";
            this.BtnBorderColor.UseVisualStyleBackColor = false;
            this.BtnBorderColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // CboType
            // 
            this.CboType.FormattingEnabled = true;
            this.CboType.Items.AddRange(new object[] {
            resources.GetString("CboType.Items"),
            resources.GetString("CboType.Items1"),
            resources.GetString("CboType.Items2"),
            resources.GetString("CboType.Items3"),
            resources.GetString("CboType.Items4"),
            resources.GetString("CboType.Items5"),
            resources.GetString("CboType.Items6"),
            resources.GetString("CboType.Items7"),
            resources.GetString("CboType.Items8"),
            resources.GetString("CboType.Items9"),
            resources.GetString("CboType.Items10")});
            resources.ApplyResources(this.CboType, "CboType");
            this.CboType.Name = "CboType";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Pen
            // 
            this.Pen.BackgroundImage = global::MyPaint.Properties.Resources.pen;
            resources.ApplyResources(this.Pen, "Pen");
            this.Pen.Name = "Pen";
            this.Pen.UseVisualStyleBackColor = true;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::MyPaint.Properties.Resources.circle1;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MyPaint.Properties.Resources.square2;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem4,
            this.recentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.sendToolStripMenuItem,
            this.setAsDesktopBackgroundToolStripMenuItem,
            this.imagePropertiesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::MyPaint.Properties.Resources.file;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::MyPaint.Properties.Resources.folder_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAFileToolStripMenuItem});
            this.toolStripMenuItem4.Image = global::MyPaint.Properties.Resources.add_image__1_;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // fromAFileToolStripMenuItem
            // 
            this.fromAFileToolStripMenuItem.Name = "fromAFileToolStripMenuItem";
            resources.ApplyResources(this.fromAFileToolStripMenuItem, "fromAFileToolStripMenuItem");
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Image = global::MyPaint.Properties.Resources.recent;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            resources.ApplyResources(this.recentToolStripMenuItem, "recentToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::MyPaint.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNGPỉctureToolStripMenuItem,
            this.jPEGToolStripMenuItem,
            this.bMPPictureToolStripMenuItem,
            this.gIFPictureToolStripMenuItem,
            this.otherFormatToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::MyPaint.Properties.Resources.diskette1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // pNGPỉctureToolStripMenuItem
            // 
            this.pNGPỉctureToolStripMenuItem.Name = "pNGPỉctureToolStripMenuItem";
            resources.ApplyResources(this.pNGPỉctureToolStripMenuItem, "pNGPỉctureToolStripMenuItem");
            this.pNGPỉctureToolStripMenuItem.Click += new System.EventHandler(this.pNGPỉctureToolStripMenuItem_Click);
            // 
            // jPEGToolStripMenuItem
            // 
            this.jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem";
            resources.ApplyResources(this.jPEGToolStripMenuItem, "jPEGToolStripMenuItem");
            this.jPEGToolStripMenuItem.Click += new System.EventHandler(this.jPEGToolStripMenuItem_Click);
            // 
            // bMPPictureToolStripMenuItem
            // 
            this.bMPPictureToolStripMenuItem.Name = "bMPPictureToolStripMenuItem";
            resources.ApplyResources(this.bMPPictureToolStripMenuItem, "bMPPictureToolStripMenuItem");
            this.bMPPictureToolStripMenuItem.Click += new System.EventHandler(this.bMPPictureToolStripMenuItem_Click);
            // 
            // gIFPictureToolStripMenuItem
            // 
            this.gIFPictureToolStripMenuItem.Name = "gIFPictureToolStripMenuItem";
            resources.ApplyResources(this.gIFPictureToolStripMenuItem, "gIFPictureToolStripMenuItem");
            // 
            // otherFormatToolStripMenuItem
            // 
            this.otherFormatToolStripMenuItem.Name = "otherFormatToolStripMenuItem";
            resources.ApplyResources(this.otherFormatToolStripMenuItem, "otherFormatToolStripMenuItem");
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::MyPaint.Properties.Resources.print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Image = global::MyPaint.Properties.Resources.paper_plane_top;
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            resources.ApplyResources(this.sendToolStripMenuItem, "sendToolStripMenuItem");
            // 
            // setAsDesktopBackgroundToolStripMenuItem
            // 
            this.setAsDesktopBackgroundToolStripMenuItem.Image = global::MyPaint.Properties.Resources.add_image;
            this.setAsDesktopBackgroundToolStripMenuItem.Name = "setAsDesktopBackgroundToolStripMenuItem";
            resources.ApplyResources(this.setAsDesktopBackgroundToolStripMenuItem, "setAsDesktopBackgroundToolStripMenuItem");
            // 
            // imagePropertiesToolStripMenuItem
            // 
            this.imagePropertiesToolStripMenuItem.Image = global::MyPaint.Properties.Resources.file_download;
            this.imagePropertiesToolStripMenuItem.Name = "imagePropertiesToolStripMenuItem";
            resources.ApplyResources(this.imagePropertiesToolStripMenuItem, "imagePropertiesToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MyPaint.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutCtrlXToolStripMenuItem,
            this.copyCtrlCToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // cutCtrlXToolStripMenuItem
            // 
            this.cutCtrlXToolStripMenuItem.Image = global::MyPaint.Properties.Resources.scissors1;
            this.cutCtrlXToolStripMenuItem.Name = "cutCtrlXToolStripMenuItem";
            resources.ApplyResources(this.cutCtrlXToolStripMenuItem, "cutCtrlXToolStripMenuItem");
            // 
            // copyCtrlCToolStripMenuItem
            // 
            this.copyCtrlCToolStripMenuItem.Image = global::MyPaint.Properties.Resources.copy1;
            this.copyCtrlCToolStripMenuItem.Name = "copyCtrlCToolStripMenuItem";
            resources.ApplyResources(this.copyCtrlCToolStripMenuItem, "copyCtrlCToolStripMenuItem");
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Image = global::MyPaint.Properties.Resources.paste1;
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            resources.ApplyResources(this.pasteCtrlVToolStripMenuItem, "pasteCtrlVToolStripMenuItem");
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.rulersToolStripMenuItem,
            this.gridlinesToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.thumbnailToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.zoomInCtrlPageUpToolStripMenuItem,
            this.zoomOutCtrlPageDownToolStripMenuItem,
            this.fitToWindowToolStripMenuItem});
            this.zoomToolStripMenuItem.Image = global::MyPaint.Properties.Resources.zoom_in;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            resources.ApplyResources(this.zoomToolStripMenuItem, "zoomToolStripMenuItem");
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            resources.ApplyResources(this.sToolStripMenuItem, "sToolStripMenuItem");
            // 
            // zoomInCtrlPageUpToolStripMenuItem
            // 
            this.zoomInCtrlPageUpToolStripMenuItem.Name = "zoomInCtrlPageUpToolStripMenuItem";
            resources.ApplyResources(this.zoomInCtrlPageUpToolStripMenuItem, "zoomInCtrlPageUpToolStripMenuItem");
            // 
            // zoomOutCtrlPageDownToolStripMenuItem
            // 
            this.zoomOutCtrlPageDownToolStripMenuItem.Name = "zoomOutCtrlPageDownToolStripMenuItem";
            resources.ApplyResources(this.zoomOutCtrlPageDownToolStripMenuItem, "zoomOutCtrlPageDownToolStripMenuItem");
            // 
            // fitToWindowToolStripMenuItem
            // 
            this.fitToWindowToolStripMenuItem.Name = "fitToWindowToolStripMenuItem";
            resources.ApplyResources(this.fitToWindowToolStripMenuItem, "fitToWindowToolStripMenuItem");
            // 
            // rulersToolStripMenuItem
            // 
            this.rulersToolStripMenuItem.Name = "rulersToolStripMenuItem";
            resources.ApplyResources(this.rulersToolStripMenuItem, "rulersToolStripMenuItem");
            // 
            // gridlinesToolStripMenuItem
            // 
            this.gridlinesToolStripMenuItem.Name = "gridlinesToolStripMenuItem";
            resources.ApplyResources(this.gridlinesToolStripMenuItem, "gridlinesToolStripMenuItem");
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            resources.ApplyResources(this.statusBarToolStripMenuItem, "statusBarToolStripMenuItem");
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Image = global::MyPaint.Properties.Resources.expand;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            // 
            // thumbnailToolStripMenuItem
            // 
            this.thumbnailToolStripMenuItem.Image = global::MyPaint.Properties.Resources.images;
            this.thumbnailToolStripMenuItem.Name = "thumbnailToolStripMenuItem";
            resources.ApplyResources(this.thumbnailToolStripMenuItem, "thumbnailToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.panelCanvas, "panelCanvas");
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove_1);
            // 
            // rd3
            // 
            resources.ApplyResources(this.rd3, "rd3");
            this.rd3.Name = "rd3";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.Click += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // rd2
            // 
            resources.ApplyResources(this.rd2, "rd2");
            this.rd2.Name = "rd2";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.Click += new System.EventHandler(this.rd2_CheckedChanged);
            // 
            // rd1
            // 
            resources.ApplyResources(this.rd1, "rd1");
            this.rd1.Name = "rd1";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.Click += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // Paint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBorderSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button Pen;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button BtnFillColor;
        private Label label8;
        private GroupBox groupBox2;
        private NumericUpDown NudBorderSize;
        private Label label6;
        private Button BtnBorderColor;
        private Label label5;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox CboType;
        private Label label3;
        private Button button3;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem fromAFileToolStripMenuItem;
        private ToolStripMenuItem recentToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem pNGPỉctureToolStripMenuItem;
        private ToolStripMenuItem jPEGToolStripMenuItem;
        private ToolStripMenuItem bMPPictureToolStripMenuItem;
        private ToolStripMenuItem gIFPictureToolStripMenuItem;
        private ToolStripMenuItem otherFormatToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem setAsDesktopBackgroundToolStripMenuItem;
        private ToolStripMenuItem imagePropertiesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutCtrlXToolStripMenuItem;
        private ToolStripMenuItem copyCtrlCToolStripMenuItem;
        private ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem zoomInCtrlPageUpToolStripMenuItem;
        private ToolStripMenuItem zoomOutCtrlPageDownToolStripMenuItem;
        private ToolStripMenuItem fitToWindowToolStripMenuItem;
        private ToolStripMenuItem rulersToolStripMenuItem;
        private ToolStripMenuItem gridlinesToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem fullScreenToolStripMenuItem;
        private ToolStripMenuItem thumbnailToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Panel panelCanvas;
        private Button BtnXoa;
        private RadioButton rd3;
        private RadioButton rd2;
        private RadioButton rd1;
    }
}

