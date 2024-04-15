using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace MyPaint
{
    public partial class Paint : Form
    {
        public Point x = new Point();
        public Point y = new Point();
        public Pen p = new Pen(Color.Black, 2);



        private PointF currentPosition;
        private ShapeEntity currentShape;
        private bool isDrawing = false;
        private Point startPosition;
        private List<ShapeEntity> shapes = new List<ShapeEntity>();
        private bool isButton1Clicked = false;
        private bool isButton2Clicked = false;
        private bool isButton3Clicked = false;
        private bool isButton4Clicked = false;
        private bool isButton5Clicked = false;
	    private bool isButton6Clicked = false;

        public List<Point> Points { get; set; }


        public Paint()
        {
            InitializeComponent();
            shapes = new List<ShapeEntity>();
            Points = new List<Point>(); 
            panelCanvas.MouseDown += panelCanvas_MouseDown;
            panelCanvas.Paint += panelCanvas_Paint;
            panelCanvas.MouseMove += panelCanvas_MouseMove;
            panelCanvas.MouseUp += panelCanvas_MouseUp;
            bm = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            g = Graphics.FromImage(bm);
              
        }
        Color BorderColor = Color.Black;
        Color FillColor = Color.Black;
        Point startPoint = Point.Empty;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point py, px;
       
        Pen erase = new Pen(Color.White, 10);
        int index;
      
        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointTo(e.Location);
            label1.Text = string.Format("{0}, {1}", e.Location.X, e.Location.Y);
            label2.Text = string.Format("{0}, {1}", currentPosition.X, currentPosition.Y);

        }

        private PointF PointTo(Point point)
        {
            return new PointF(point.X, point.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = true;
            isButton2Clicked = false;
            isButton3Clicked = false;
            isButton4Clicked = false;
            isButton5Clicked = false;
            isButton6Clicked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = false;
            isButton2Clicked = true;
            isButton3Clicked = false;
            isButton4Clicked = false;
            isButton5Clicked = false;
            isButton6Clicked = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            { p.Color = cd.Color; }
        }

        private void Pen_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = false;
            isButton2Clicked = false;
            isButton3Clicked = true;
            isButton4Clicked = false;
            isButton5Clicked = false;
            isButton6Clicked = false;
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = false;
            isButton2Clicked = false;
            isButton3Clicked = false;
            isButton4Clicked = true;
            isButton5Clicked = false;
            isButton6Clicked = false;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = false;
            isButton2Clicked = false;
            isButton3Clicked = false;
            isButton4Clicked = false;
            isButton5Clicked = true;
            isButton6Clicked = false;
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = false;
            isButton2Clicked = false;
            isButton3Clicked = false;
            isButton4Clicked = false;
            isButton5Clicked = false;
            isButton6Clicked = true;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                startPosition = e.Location;

                if (isButton1Clicked)
                {
                    currentShape = new RectangleShape(startPosition);
                }
                else if (isButton2Clicked)
                {
                    currentShape = new CircleShape(startPosition);
                }
                else if (isButton3Clicked)
                {
                    currentShape = new AnyShape(startPosition);
                }
                if (isButton4Clicked)
                {
                    p.Width = 2;
                    g = panelCanvas.CreateGraphics();
                }
                else if (isButton5Clicked)
                {
                    p.Width = 4;
                    g = panelCanvas.CreateGraphics();
                }
                else if (isButton6Clicked)
                {
                    p.Width = 6;
                    g = panelCanvas.CreateGraphics();
                }
            }
            else
            {
                foreach (var shape in shapes)
                {
                    if (shape.Contains(e.Location))
                    {
                        shape.IsSelected = true;
                    }
                    else
                    {
                        shape.IsSelected = false;
                    }
                }
                panelCanvas.Invalidate();
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentShape != null)
            {
                currentShape.UpdateSize(e.Location);
                panelCanvas.Invalidate();

            }

        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentShape != null)
            {
                currentShape.UpdateSize(e.Location);
                shapes.Add(currentShape);
                panelCanvas.Invalidate();

                isDrawing = false;
                currentShape = null;

            }
            var endPoint = e.Location;
            Graphics g = panelCanvas.CreateGraphics();
            float borderSize = float.Parse(NudBorderSize.Value.ToString());
            Point diemVe = new Point
            {
                X = Math.Min(startPoint.X, endPoint.X),
                Y = Math.Min(startPoint.Y, endPoint.Y),
            };
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);

            Pen pen = new Pen(BorderColor, borderSize);

            switch (CboType.SelectedIndex)
            {
                case 0://DrawLine
                    g.DrawLine(new Pen(BorderColor, borderSize), startPoint, endPoint);
                    break;
                case 1://Rectangle					
                    g.DrawRectangle(new Pen(BorderColor, borderSize), diemVe.X, diemVe.Y, width, height);
                    break;
                case 2: //Fill Rectangle					
                    g.FillRectangle(new SolidBrush(FillColor), diemVe.X, diemVe.Y, width, height);
                    break;
                case 3: //Ellipse					
                    g.DrawEllipse(new Pen(BorderColor, borderSize), diemVe.X, diemVe.Y, width, height);
                    break;
                case 4: //Fill Ellipse
                    g.FillEllipse(new SolidBrush(FillColor), diemVe.X, diemVe.Y, width, height);
                    break;
                case 5: //Triangle
                    Point[] points = new Point[3];
                    points[0] = new Point(startPoint.X + width / 2, startPoint.Y);
                    points[1] = new Point(startPoint.X, endPoint.Y);
                    points[2] = new Point(endPoint.X, endPoint.Y);
                    drawTriangle(g, new Pen(BorderColor, borderSize), points);
                    break;
                case 6: //Fill Triangle
                    Point[] points2 = new Point[3];
                    points2[0] = new Point(startPoint.X + width / 2, startPoint.Y);
                    points2[1] = new Point(startPoint.X, endPoint.Y);
                    points2[2] = new Point(endPoint.X, endPoint.Y);
                    fillTriangle(g, new SolidBrush(FillColor), points2);
                    break;
                case 7: //Square
                    g.DrawRectangle(new Pen(BorderColor, borderSize), diemVe.X, diemVe.Y, width, width);
                    break;
                case 8: //Fill Square
                    g.FillRectangle(new SolidBrush(FillColor), diemVe.X, diemVe.Y, width, width);
                    break;
                case 9: //Parallelogram
                    int skew = width / 2;

                    Point[] parallelogramPoints = {
                        new Point(startPoint.X + skew, startPoint.Y),
                        new Point(endPoint.X + skew, startPoint.Y),
                        new Point(endPoint.X - skew, endPoint.Y),
                        new Point(startPoint.X - skew, endPoint.Y)
                    };
                    drawParallelogram(g, new Pen(BorderColor, borderSize), parallelogramPoints);
                    break;
                case 10: //Fill Parallelogram
                    Point[] fillParallelogramPoints = {
                        startPoint,
                        new Point(startPoint.X + width, startPoint.Y),
                        new Point(endPoint.X, endPoint.Y),
                        new Point(endPoint.X - width, endPoint.Y)
                    };
                    using (Brush brush = new SolidBrush(FillColor))
                    {
                        g.FillPolygon(brush, fillParallelogramPoints);
                    }
                    break;
            }
        }

        private void drawTriangle(Graphics g, Pen pen, Point[] points)
        {
            g.DrawPolygon(pen, points);
        }

        private void fillTriangle(Graphics g, Brush brush, Point[] points)
        {
            g.FillPolygon(brush, points);
        }

        private void drawParallelogram(Graphics g, Pen pen, Point[] points)
        {
            g.DrawPolygon(pen, points);
        }

        private void fillParallelogram(Graphics g, Brush brush, Point[] points)
        {
            g.FillPolygon(brush, points);
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);

                if (shape.IsSelected)
                {
                    shape.Draw(e.Graphics);
                }
            }

            if (currentShape != null)
            {
                currentShape.Draw(e.Graphics);
            }

        }
        //

        private void bMPPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
                saveFileDialog.DefaultExt = "bmp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SavePanelContentAsBmp(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp BMP: " + ex.Message);
            }
        }

        public void SavePanelContentAsBmp(string filePath)
        {
            Bitmap bitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            panelCanvas.DrawToBitmap(bitmap, new Rectangle(0, 0, panelCanvas.Width, panelCanvas.Height));

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionNone);

            bitmap.Save(filePath, GetBmpEncoder(), encoderParams);
            bitmap.Dispose();
        }

        private ImageCodecInfo GetBmpEncoder()
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == ImageFormat.Bmp.Guid)
                    return codec;
            }
            return null;
        }

        private void pNGPỉctureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG files (*.png)|*.png";
                saveFileDialog.DefaultExt = "png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SavePanelContentAsPng(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp PNG: " + ex.Message);
            }
        }

        public void SavePanelContentAsPng(string filePath)
        {
            Bitmap bitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            panelCanvas.DrawToBitmap(bitmap, new Rectangle(0, 0, panelCanvas.Width, panelCanvas.Height));

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionNone);

            bitmap.Save(filePath, GetPngEncoder(), encoderParams);
            bitmap.Dispose();
        }

        private ImageCodecInfo GetPngEncoder()
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == ImageFormat.Png.Guid)
                    return codec;
            }
            return null;
        }

        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG files (*.jpeg)|*.jpeg";
                saveFileDialog.DefaultExt = "jpeg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SavePanelContentAsJpeg(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp JPEG: " + ex.Message);
            }
        }

        public void SavePanelContentAsJpeg(string filePath)
        {
            Bitmap bitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            panelCanvas.DrawToBitmap(bitmap, new Rectangle(0, 0, panelCanvas.Width, panelCanvas.Height));

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionNone);

            bitmap.Save(filePath, GetJpegEncoder(), encoderParams);
            bitmap.Dispose();
        }

        private ImageCodecInfo GetJpegEncoder()
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == ImageFormat.Jpeg.Guid)
                    return codec;
            }
            return null;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo một cửa sổ mới để hiển thị thông tin "About"
            Form aboutForm = new Form();
            aboutForm.Text = "About";
            aboutForm.Size = new Size(600, 300);

            // Tạo các điều khiển trong cửa sổ "About"
            Label titleLabel = new Label();
            titleLabel.Text = "Paint ";
            titleLabel.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            titleLabel.Location = new Point(20, 20);
            titleLabel.AutoSize = true;

            Label descriptionLabel = new Label();
            descriptionLabel.Text =
                "1. Công cụ vẽ: Paint cung cấp các công cụ vẽ cơ bản như bút, cọ, hình chữ nhật, hình tròn, v.v. \nNgười dùng có thể chọn kích thước và màu sắc của công cụ vẽ để tạo ra các hình ảnh và hình vẽ đơn giản.\n" +
                "2. Định dạng hình ảnh: Paint hỗ trợ nhiều định dạng tệp hình ảnh phổ biến như PNG, JPEG, BMP, . \nNgười dùng có thể lưu hình ảnh dưới dạng các tệp tin này để chia sẻ hoặc sử dụng trong các ứng dụng khác.\n" +
                "3. Hiệu ứng và bảng màu: Người dùng có thể tùy chỉnh màu sắc và áp dụng các \nhiệu ứng này để tạo ra hình ảnh độc đáo.\n" +
                "4. Lớp và sự tương tác: Một tính năng mở rộng của Paint là khả năng tạo và quản lý các lớp hình ảnh. \nNgười dùng có thể tạo ra các lớp riêng biệt và điều chỉnh thứ tự và \ntương tác giữa chúng để tạo hiệu ứng đa lớp trên hình ảnh.\n";

            descriptionLabel.Location = new Point(20, 60);
            descriptionLabel.AutoSize = true;

            Label authorsLabel = new Label();
            authorsLabel.Text =
                "Student1: Nguyễn Tấn Nhã, Mssv: 2100005929\n" +
                "Student2: Lê Tiến Phát, Mssv: 2000003649\n" +
                "Student3: Nguyễn Triệu Vỹ, Mssv: 2000000740\n";
            authorsLabel.Location = new Point(20, 190);
            authorsLabel.AutoSize = true;

            // Thêm các điều khiển vào cửa sổ "About"
            aboutForm.Controls.Add(titleLabel);
            aboutForm.Controls.Add(descriptionLabel);
            aboutForm.Controls.Add(authorsLabel);

            // Hiển thị cửa sổ "About"
            aboutForm.ShowDialog();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.FullOpen = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                BorderColor = cd.Color;
                BtnBorderColor.BackColor = cd.Color;
            }
        }

        private void panelCanvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.Location;
                g.DrawLine(p, x, y);
                y = x;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            shapes.Clear(); 
            panelCanvas.Invalidate(); 
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFillColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.FullOpen = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                FillColor = cd.Color;
                BtnFillColor.BackColor = cd.Color;
            }
        }  
    }

}
