using Negocios;

namespace Gymwork_program
{
    public partial class LoginGymwork : Form
    {
        ConnectionSQLnn cn = new ConnectionSQLnn();

        public LoginGymwork()
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
                this.Hide();
                VentanaPrincipal v1= new VentanaPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("the user wasn't been founded");
            }
        }
    }
}
