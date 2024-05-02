using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Gymwork_program
{
    public partial class Users : Form
    {
        ConnectionSQLnn cn= new ConnectionSQLnn();
        
        public Users()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultDGV();
        }

        private void CloseBtnV2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewUserBtnV2_Click(object sender, EventArgs e)
        {
            //id, name, lastname, phone, user, password
            cn.InsertUser(Convert.ToDecimal(txtIDV2.Text), txtNameV2.Text, txtLastnameV2.Text, Convert.ToDecimal(txtPhoneV2.Text), txtUserV2.Text, txtPasswordV2.Text);
            dataGridView1.DataSource = cn.ConsultDGV();
        }

        private void DeleteUserBtnV2_Click(object sender, EventArgs e)
        {
            cn.DeleteUser(Convert.ToDecimal(txtIDV2.Text));
            dataGridView1.DataSource = cn.ConsultDGV();

        }

        private void ModifyUserBtnV2_Click(object sender, EventArgs e)
        {
            cn.ModifyUser(Convert.ToDecimal(txtIDV2.Text), txtNameV2.Text, txtLastnameV2.Text, Convert.ToDecimal(txtPhoneV2.Text), txtUserV2.Text, txtPasswordV2.Text);
            dataGridView1.DataSource = cn.ConsultDGV();

        }
    }
}
