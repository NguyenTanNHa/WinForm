using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Thêm sự kiện cho ToolStripMenuItem "About"
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // Thêm sự kiện cho ToolStripMenuItem "Find"
            findToolStripMenuItem1.Click += findToolStripMenuItem1_Click;

            // Thêm sự kiện cho ToolStripMenuItem "Replace"
            replaceToolStripMenuItem.Click += replaceToolStripMenuItem_Click;
            // Kết nối sự kiện Click của ToolStripMenuItem "None" với phương thức xử lý noneToolStripMenuItem_Click
            noneToolStripMenuItem.Click += new EventHandler(noneToolStripMenuItem_Click);



        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập các giá trị mặc định ban đầu khi form được load
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.Font = new Font("Arial", 12);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng tạo mới document
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng mở file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.EndsWith(".rtf"))
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng lưu file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.EndsWith(".rtf"))
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void paseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // Chức năng căn giữa
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng căn giữa
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng căn phải
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // Chức năng căn phải
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            Font newFont = new Font("Arial", 12, FontStyle.Bold);

            // Thiết lập font mới cho vùng chọn
            richTextBox1.SelectionFont = newFont;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {// Chức năng in nghiêng
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {// Chức năng gạch chân
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = FontStyle.Underline;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Chức năng chọn màu chữ
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            // Chức năng chọn màu nền
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chọn ảnh từ máy tính
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc ảnh từ đường dẫn đã chọn
                    Image image = Image.FromFile(openFileDialog1.FileName);

                    // Chèn ảnh vào RichTextBox
                    Clipboard.SetImage(image);
                    richTextBox1.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể chèn ảnh: " + ex.Message);
                }
            }
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng gạch chân
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = FontStyle.Underline;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng in nghiêng
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng in đậm
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            Font newFont = new Font("Arial", 12, FontStyle.Bold);

            // Thiết lập font mới cho vùng chọn
            richTextBox1.SelectionFont = newFont;
        }

        private void addBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }

        private void removeBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = false;
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent += 5;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 0;
        }

        private void ptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent += 10;
        }

        private void ptToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent += 15;
        }

        private void ptToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent += 20;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor -= 0.1f;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 0.1f;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại chọn font
            FontDialog fontDialog = new FontDialog();

            // Thiết lập font ban đầu cho hộp thoại
            fontDialog.Font = richTextBox1.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy font được chọn từ hộp thoại
                Font selectedFont = fontDialog.Font;

                // Áp dụng font được chọn cho vùng chọn trong RichTextBox
                richTextBox1.SelectionFont = selectedFont;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Chức năng lưu file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.EndsWith(".rtf"))
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Chức năng mở file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.EndsWith(".rtf"))
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            saveFileDialog.Title = "Save As";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu nội dung của RichTextBox vào file đã chọn
                string fileName = saveFileDialog.FileName;
                string fileExtension = Path.GetExtension(fileName);

                try
                {
                    if (fileExtension.ToLower() == ".txt")
                    {
                        // Lưu dưới định dạng plain text
                        richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                    }
                    else if (fileExtension.ToLower() == ".rtf")
                    {
                        // Lưu dưới định dạng Rich Text Format
                        richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("File saved successfully.", "Save As", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khởi tạo hộp thoại PageSetupDialog
            PageSetupDialog pageSetupDialog = new PageSetupDialog();

            // Thiết lập các thiết lập in mặc định
            pageSetupDialog.PageSettings = new System.Drawing.Printing.PageSettings();

            // Hiển thị hộp thoại Page Setup
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                // Thực hiện các thiết lập in ấn đã chọn
                // Ví dụ: lấy kích thước giấy
                PaperSize paperSize = pageSetupDialog.PageSettings.PaperSize;
                MessageBox.Show($"Paper Size: {paperSize.PaperName} - Width: {paperSize.Width} - Height: {paperSize.Height}",
                                "Page Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng PrintDocument
            PrintDocument printDocument = new PrintDocument();

            // Khởi tạo hộp thoại PrintPreviewDialog
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            // Gắn sự kiện PrintPage cho PrintDocument
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Gắn PrintDocument cho PrintPreviewDialog
            printPreviewDialog.Document = printDocument;

            // Hiển thị hộp thoại Print Preview
            printPreviewDialog.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Đưa nội dung của RichTextBox lên trang in
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 100);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị form AboutForm khi ToolStripMenuItem được nhấp
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chọn toàn bộ văn bản trong RichTextBox
            richTextBox1.SelectAll();
        }

        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Hiển thị form tìm kiếm
            using (FindForm findForm = new FindForm())
            {
                if (findForm.ShowDialog() == DialogResult.OK)
                {
                    string searchText = findForm.SearchText;
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        int index = richTextBox1.Find(searchText);
                        if (index >= 0)
                        {
                            richTextBox1.Select(index, searchText.Length);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chuỗi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị form thay thế
            using (ReplaceForm replaceForm = new ReplaceForm())
            {
                if (replaceForm.ShowDialog() == DialogResult.OK)
                {
                    string searchText = replaceForm.SearchText;
                    string replaceText = replaceForm.ReplaceText;

                    if (!string.IsNullOrEmpty(searchText) && !string.IsNullOrEmpty(replaceText))
                    {
                        richTextBox1.Text = richTextBox1.Text.Replace(searchText, replaceText);
                    }
                }
            }
        }

      

        

        private void remoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo(); // Làm lại thao tác chỉnh sửa đã hoàn tác
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo(); // Hoàn tác thao tác chỉnh sửa gần nhất
        }
        private void ApplyNormalStyle()
        {
            // Lấy vị trí hiện tại của con trỏ trong RichTextBox
            int selectionStart = richTextBox1.SelectionStart;

            // Xóa bỏ các định dạng đặc biệt của văn bản tại vị trí con trỏ
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionBackColor = Color.White;

            // Đặt lại vị trí con trỏ sau khi xử lý
            richTextBox1.Select(selectionStart, 0);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyNormalStyle();
        }

        private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Tạo một FontDialog mới
            FontDialog fontDialog = new FontDialog();

            // Thiết lập font hiện tại của RichTextBox làm font mặc định cho FontDialog
            fontDialog.Font = richTextBox1.SelectionFont;

            // Mở FontDialog để cho người dùng chọn font chữ
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Áp dụng font chữ đã chọn vào văn bản tại vị trí con trỏ
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chức năng chọn màu nền
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
