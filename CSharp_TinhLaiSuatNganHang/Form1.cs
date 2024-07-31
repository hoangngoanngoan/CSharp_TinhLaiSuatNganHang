namespace CSharp_TinhLaiSuatNganHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double tienVon;
        private double tienLai;
        private short namGui;
        private double laiSuat;

        private void GetInfo()
        {
            
            errorProvider1.Clear();
            if (!double.TryParse(txtMoney.Text, out _))
            {
                errorProvider1.SetError(txtMoney, "Phải nhập số");
                return;
            }
            if (string.IsNullOrEmpty(txtMoney.Text))
            {
                errorProvider1.SetError(txtMoney, "Không được bỏ trống");
                return;
            }

            if (!short.TryParse(txtYear.Text, out _))
            {
                errorProvider1.SetError(txtYear, "Phải nhập số");
                return;
            }
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                errorProvider1.SetError(txtYear, "Không được bỏ trống");
                return ;
            }

            if (!double.TryParse(txtRate.Text, out _))
            {
                errorProvider1.SetError(txtRate, "Phải nhập số");
                return;
            }
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                errorProvider1.SetError(txtRate, "Không được bỏ trống");
                return;
            }

            tienVon = Convert.ToDouble(txtMoney.Text);
            namGui = Convert.ToInt16(txtYear.Text);
            laiSuat = Convert.ToDouble(txtRate.Text);
            tienLai = 0;
        }
        private void butSubmit_Click(object sender, EventArgs e)
        {
            
            GetInfo();
            for (int i = 0; i<namGui; i++)
            {
                tienVon += tienLai;
                tienLai = tienVon * laiSuat;
                lbKQ.Items.Add($"- Tiền vốn: {tienVon} - Tiền lãi: {tienLai}\n");
            }
        }
    }
}
