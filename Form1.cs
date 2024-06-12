namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister=new FormRegister();
            formRegister.ShowDialog();
        }
    }
}