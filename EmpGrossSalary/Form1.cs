namespace EmpGrossSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        double sal, etf, epf, etfamount, epfamount, gsal, allow, nsal;

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            sal = Double.Parse(txtsal.Text);

            if (chkeft.Checked == true)
            {
                etfamount = sal * 10 / 100;
            }

            if (chkepf.Checked == true)
            {
                epfamount = sal * 5 / 100;
            }

            txtetf.Text = etfamount.ToString();
            txtepf.Text = epfamount.ToString();

            gsal = sal - etfamount + etfamount;

            txtgsal.Text = gsal.ToString();

            if (sal > 50000)
            {
                allow = 2000;
            }
            else if (sal > 30000)
            {
                allow = 1000;
            }
            else
            {
                allow = 0;
            }

            txtallowance.Text = allow.ToString();
            nsal = gsal + allow;
            txtnsal.Text = nsal.ToString();



        }

        private void txtepf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtetf_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkepf_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
