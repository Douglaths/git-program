using Negocios;

namespace Gymwork_program
{
    public partial class Form1 : Form
    {
        ConnectionSQLnn cn = new ConnectionSQLnn();

        public Form1()
        {
            InitializeComponent();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txtUser.Text, txtPassword.Text) == 1)
            {
                MessageBox.Show("The user was been founded.");
            }
            else
            {
                MessageBox.Show("the user wasn't been founded");
            }
        }
    }
}
