namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load += new EventHandler(Form1_Load);
        }
        public string default_name = "HIMMEL SANG PAHLAWAN";
        public string default_code = "6358ASJBXXXX";

        // Event Handler untuk nama petualang
        private void namaPetualang_value_Enter(object sender, EventArgs e)
        {
            if (namaPetualang_value.Text == "ISI CODE NAME MU PETUALANG!!!")
            {
                namaPetualang_value.Text = "";
                namaPetualang_value.ForeColor = Color.Black;
            }
        }
        private void nama_petualang_value_TextChanged(object sender, EventArgs e)
        {
            if (namaPetualang_value.Text != "")
            {
                namaPetualang_value.ForeColor = Color.Black;
            }
        }

        private void namaPetualang_value_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaPetualang_value.Text))
            {
                namaPetualang_value.Text = "ISI CODE NAME MU PETUALANG!!!";
                namaPetualang_value.ForeColor = Color.Red;
            }
            if (namaPetualang_value.Text == default_name)
            {
                namaPetualang_value.Text = "ISI CODE NAME MU PETUALANG!!!";
                namaPetualang_value.ForeColor = Color.Red;
            }
        }

        // Event Handler untuk code petualang
        private void codeRahasia_value_Enter(object sender, EventArgs e)
        {
            if (codeRahasia_value.Text == "6358ASJBXXXX")
            {
                codeRahasia_value.Text = "";
                codeRahasia_value.ForeColor = Color.Black;
                codeRahasia_value.UseSystemPasswordChar = !LihatPassword.Checked;
            }
            if (codeRahasia_value.Text == "CODE MINIMAL 5 KARAKTER!!!")
            {
                codeRahasia_value.Text = "";
                codeRahasia_value.ForeColor = Color.Black;
                codeRahasia_value.UseSystemPasswordChar = !LihatPassword.Checked;
            }
        }
        private void codeRahasia_value_Leave(object sender, EventArgs e)
        {
            if (codeRahasia_value.Text.Length < 5)
            {
                codeRahasia_value.Text = "CODE MINIMAL 5 KARAKTER!!!";
                codeRahasia_value.UseSystemPasswordChar = false;
                codeRahasia_value.ForeColor = Color.Red;
            }
        }
        private void codeRahasia_value_TextChanged(object sender, EventArgs e)
        {
            if (codeRahasia_value.Text != "")
            {
                codeRahasia_value.ForeColor = Color.Black;
                codeRahasia_value.UseSystemPasswordChar = !LihatPassword.Checked;
            }
        }
        private void LihatPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (LihatPassword.Checked)
            {
                codeRahasia_value.UseSystemPasswordChar = false;
            }
            else
            {
                codeRahasia_value.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            namaPetualang_value.Text = default_name;
            namaPetualang_value.ForeColor = Color.Red;

            codeRahasia_value.Text = default_code;
            codeRahasia_value.UseSystemPasswordChar = false;
            codeRahasia_value.ForeColor = Color.Red;
        }
    }
}
