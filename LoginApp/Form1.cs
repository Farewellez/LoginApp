namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
        }
        private void namaPetualang_value_Enter(object sender, EventArgs e)
        {
            if (namaPetualang_value.Text == "ISI CODE NAME MU PETUALANG")
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
                namaPetualang_value.Text = "ISI CODE NAME MU PETUALANG";
                namaPetualang_value.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            namaPetualang_value.Text = "ISI NAMA MU PETUALANG!!!";
            namaPetualang_value.ForeColor = Color.Red;
        }
    }
}
