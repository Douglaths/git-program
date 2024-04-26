using Npgsql;
namespace postgreSQL

{
    public partial class Form1 : Form
    {
        ConnectionPgsql connecting = new ConnectionPgsql();
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {

            connecting.Connect();
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            connecting.disConnect();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Name=null;
            Name= NameSearchTxt.Text;
            if (Name != "")
            {
                dataGridViewTB.DataSource=connecting.Search(NameSearchTxt.Text);
            }
            else
            {
                dataGridViewTB.DataSource=connecting.Search();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            connecting.Insert(txt_Nid.Text, txtName.Text, txtLastName.Text, txtCountry.Text, txtVisa.Text);

            dataGridViewTB.DataSource = connecting.Search(NameSearchTxt.Text);
            txt_Nid.Text= "";
            txtName.Text= "";
            txtLastName.Text= "";
            txtCountry.Text= "";
            txtVisa.Text= "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connecting.Delete(NameSearchTxt.Text);

            dataGridViewTB.DataSource = connecting.Search();

            NameSearchTxt.Text= "";
        }
    }
}
