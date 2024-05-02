using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocios;

namespace Gymwork_program
{
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;
        ConnectionSQLnn cn = new ConnectionSQLnn();
        private double subtotal = 0;
        public VentanaPrincipal()
        {
            InitializeComponent();
            txtTaxesEdit.Text="0";
            txtDiscountEdit.Text= "0";
            double IntSalesTax = double.Parse(txtTaxesEdit.Text) * 100;
            double IntDiscount = double.Parse(txtDiscountEdit.Text) * 100;
            txtSalesTax.Text= (IntSalesTax*100).ToString();
            txtDiscount.Text= (IntDiscount*100).ToString();
            double IntSalesTaxEdit = 0.19;
            double IntDiscountEdit = 0;
            txtTaxesEdit.Text= IntSalesTaxEdit.ToString();
            txtDiscountEdit.Text= IntDiscountEdit.ToString();

            dt=new DataTable();
            dt.Columns.Add("IdProduct");
            dt.Columns.Add("Product");
            dt.Columns.Add("Price by unit");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("TotalPrice");
            dataGridView1.DataSource=dt;

            txtBillNumber.Text = cn.SearchBill();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users v1 = new Users();
            v1.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock v1 = new Stock();
            v1.Show();
        }

        private void TaxesAndDiscountChanged(Object sender, EventArgs e)
        {
            {
                // Verificar si el TextBox txtTaxesEdit no está vacío antes de intentar la conversión
                if (!string.IsNullOrEmpty(txtTaxesEdit.Text))
                {
                    // Obtener el valor de impuesto del TextBox y convertirlo a número
                    double taxes = double.Parse(txtTaxesEdit.Text);

                    // Convertir el valor de impuesto a porcentaje y actualizar el TextBox correspondiente
                    txtSalesTax.Text = (taxes * 100).ToString("0") + "%";
                }
                else
                {
                    // Si el TextBox está vacío, asignar un valor predeterminado de 0 al TextBox de impuesto
                    txtSalesTax.Text = "0%";
                }

                // Verificar si el TextBox txtDiscountEdit no está vacío antes de intentar la conversión
                if (!string.IsNullOrEmpty(txtDiscountEdit.Text))
                {
                    // Obtener el valor de descuento del TextBox y convertirlo a número
                    double discount = double.Parse(txtDiscountEdit.Text);

                    // Convertir el valor de descuento a porcentaje y actualizar el TextBox correspondiente
                    txtDiscount.Text = (discount * 100).ToString("0") + "%";
                }
                else
                {
                    // Si el TextBox está vacío, asignar un valor predeterminado de 0 al TextBox de descuento
                    txtDiscount.Text = "0%";
                }
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var result1 = cn.SearchStock(txtIDProductSearch.Text);

            DataRow row = dt.NewRow();
            row["IdProduct"] = txtIDProductSearch.Text;
            row["Product"] = result1.Item1;
            row["Price by unit"] = result1.Item2;
            row["Quantity"] = txtQuantity.Text;
            row["Discount"] = txtDiscount.Text;
            row["TotalPrice"] = double.Parse(txtQuantity.Text) * double.Parse(result1.Item2);

            dt.Rows.Add(row);

            subtotal = subtotal + (Int32.Parse(txtQuantity.Text) * double.Parse(result1.Item2));
            txtSubtotalPrice.Text = subtotal.ToString();
            txtTotalPrice.Text = (subtotal + (subtotal * double.Parse(txtTaxesEdit.Text))).ToString();

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtSalesTax_TextChanged(object sender, EventArgs e)
        {
            txtSalesTax.Text = txtSalesTax.Text;
        }
    }
}
