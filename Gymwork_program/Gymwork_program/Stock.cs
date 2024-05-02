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
    public partial class Stock : Form
    {
        ConnectionSQLnn cn = new ConnectionSQLnn();


        public Stock()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultProducts();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            cn.AddProduct(Convert.ToDecimal(txtIDProduct.Text), txtProduct.Text, txtCategory.Text, Convert.ToSingle(txtPrices.Text), Convert.ToInt32(txtQuantity.Text));
            dataGridView1.DataSource = cn.ConsultProducts();
        }



        private void CloseBtnV3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModifyProductBtn_Click(object sender, EventArgs e)
        {
            cn.ModifyProduct(Convert.ToDecimal(txtIDProduct.Text), txtProduct.Text, txtCategory.Text, Convert.ToSingle(txtPrices.Text), Convert.ToInt32(txtQuantity.Text));
            dataGridView1.DataSource = cn.ConsultProducts();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            cn.DeleteProduct(Convert.ToDecimal(txtIDProduct.Text));
            dataGridView1.DataSource = cn.ConsultProducts();
        }
    }
}
