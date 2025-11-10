using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDatabase.Forms
{
    public partial class StartWindow : Form
    {
        BindingSource clientsBindingSource = new BindingSource();

        public StartWindow()
        {
            InitializeComponent();
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            buttonResetTable.Enabled = false;
        }

        private async void SearchClients()
        {
            buttonSearchDatabase.Enabled = false;
            buttonResetTable.Enabled = true;

            ClientsDAO clientsDAO = new ClientsDAO();
            await Task.Factory.StartNew(() => clientsBindingSource.DataSource = clientsDAO.GetAllClients(textBoxSearchDatabase.Text).Result); // Get client list from database

            dataGridViewClients.DataSource = clientsBindingSource.DataSource;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            buttonSearchDatabase.Enabled = true;
        }

        private void buttonRegisterClient_Click(object sender, EventArgs e)
        {
            SignUpWindow signup = new SignUpWindow();
            signup.StartPosition = FormStartPosition.CenterScreen;
            signup.Show();
        }

        private void labelSearchDatabase_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchDatabase_Click(object sender, EventArgs e)
        {
            SearchClients();
        }

        private void buttonResetTable_Click(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = null;
            buttonSearchDatabase.Enabled = true;
            buttonResetTable.Enabled = false;
        }
    }
}
