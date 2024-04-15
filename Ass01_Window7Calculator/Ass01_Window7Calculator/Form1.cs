namespace Ass01_Window7Calculator
{
    public partial class Form1 : Form
    {
        double memoryStorePlus;
        double memoryStoreMinus;
        double memoryStore;
        bool isOperator = false;
        string Operator;
        double firstdigit;
        string chuoitam = "";
        string ChuoiTam = "";
        char toantu;
        double[] toanhang = new double[2];
        double ketqua;
        int buoc = 1;
        double result;
        public Form1()
        {
            InitializeComponent();
        }
        private void NumberButtons(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if ((b == null) || (b.Text == "0" && chuoitam.Length == 0)) return;
            chuoitam += b.Text;
            txtScreen.Text = chuoitam;
        }
        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!chuoitam.Contains("."))
            {
                chuoitam = chuoitam + ".";
                txtScreen.Text = chuoitam;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

            int index = chuoitam.Length;
            index--;
            if (index >= 0)
            {
                chuoitam = chuoitam.Remove(index);
            }
            txtScreen.Text = chuoitam;
            if (txtScreen.Text == "" || (txtScreen.Text == "-"))
            {
                txtScreen.Text = "0";
                chuoitam = "";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            chuoitam = "";
            txtScreen.Text = "0";
            result = 0;
            txtChuoiTam.Text = "";
            ChuoiTam = "";
        }

        private void btnCongTru_Click(object sender, EventArgs e)
        {
            double result = double.Parse(chuoitam);
            result = result * (-1);
            chuoitam = result.ToString();
            txtScreen.Text = chuoitam;

            if (txtScreen.Text == "0" && txtChuoiTam.Text == "0")
            {
                MessageBox.Show("Nhập số trước mới được");
                //This code is still not working :)
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            /*
            if (txtScreen.Text != "0" && txtScreen.Text.Length != 0) 
            {
                txtScreen.Text = NumberButtons(chuoitam);
            cái này là muốn nếu chỉ bấm 1 số và bấm bằng, 
            thì txtScreen với txtChuoiTam cũng bằng với số vừa bấm
            mà hông biết sao hông được 
            => để sửa sau khi hoàn thành các chức năng khác
            }
            */

            if (chuoitam.Length != 0)
                toanhang[1] = Double.Parse(chuoitam);
            switch (toantu)
            {
                case '+':
                    ketqua = toanhang[0] + toanhang[1];
                    ChuoiTam = $"{toanhang[0]} + {toanhang[1]}";
                    break;
                case '-':
                    ketqua = toanhang[0] - toanhang[1];
                    ChuoiTam = $"{toanhang[0]} - {toanhang[1]}";
                    break;
                case '*':
                    ketqua = toanhang[0] * toanhang[1];
                    ChuoiTam = $"{toanhang[0]} * {toanhang[1]}";
                    break;
                case '/':
                    ketqua = toanhang[0] / toanhang[1];
                    ChuoiTam = $"{toanhang[0]} / {toanhang[1]}";
                    break;
            }
            txtChuoiTam.Text = ChuoiTam;
            txtScreen.Text = ketqua.ToString();
            //Gán lại giá trị ban đầu
            toanhang[0] = ketqua;
            buoc = 1;
            chuoitam = "";
        }
        private void Operations(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (buoc == 1)
                toantu = b.Text[0]; //Lấy ký hiệu toán tử hmm????
            if (chuoitam.Length == 0)
                toanhang[buoc - 1] = ketqua; //gì đây????????????
            else
                toanhang[buoc - 1] = Double.Parse(chuoitam);
            if (buoc == 2)
            {
                btnBang_Click(null, null);
                toantu = b.Text[0];
                toanhang[0] = ketqua;
                buoc = 2;
            }
            else
            {
                txtScreen.Text = toanhang[0].ToString();
                buoc++;
            }
            chuoitam = "";

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            chuoitam = "";
            txtScreen.Text = "0";
            result = 0;
            ChuoiTam = "";
        }

        private void btnCanBacHai_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtScreen.Text);
            double tempSqrt = Math.Sqrt(result);
            txtScreen.Text = tempSqrt.ToString();
            txtChuoiTam.Text = $"{btnCanBacHai.Text}({result})";
        }

        private void btnPhanSo_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtScreen.Text);
            double tempFraction = 1 / result;
            txtScreen.Text = tempFraction.ToString();
            txtChuoiTam.Text = $"1/{result}";
        }

        private void btnPhanTram_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtScreen.Text);
            double tempPercent = result / 100;
            txtScreen.Text = tempPercent.ToString();
            txtChuoiTam.Text = $"{result}%";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 0)
            {
                memoryStore = double.Parse(txtScreen.Text);
                MessageBox.Show("Memory stored!");
            }
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if (memoryStore != 0)
            {
                txtScreen.Text = memoryStore.ToString();
                chuoitam = memoryStore.ToString();
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            if (memoryStore != 0)
            {
                memoryStore = 0;
                MessageBox.Show("Memory cleared!");
            }
        }

        private void btnMCong_Click(object sender, EventArgs e)
        {
            if (memoryStore != 0)
            {
                memoryStorePlus = memoryStore + double.Parse(txtScreen.Text);
            }
            memoryStore = memoryStorePlus;
        }

        private void btnMTru_Click(object sender, EventArgs e)
        {
            if (memoryStore != 0)
            {
                memoryStoreMinus = memoryStore - double.Parse(txtScreen.Text);
            }
            memoryStore = memoryStoreMinus;
        }
    }
}
