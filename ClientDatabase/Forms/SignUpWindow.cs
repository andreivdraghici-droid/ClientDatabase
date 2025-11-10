using ClientDatabase.Model;
using System;
using System.Windows.Forms;

namespace ClientDatabase
{
    public partial class SignUpWindow : Form
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void SignUpClient()
        {
            if (textBoxClientName.Text.Length <= 0
                || textBoxClientPassword.Text.Length <= 0
                || textBoxClientEmail.Text.Length <= 0
                || textBoxClientAddress.Text.Length <= 0
                || textBoxClientCity.Text.Length <= 0
                || textBoxClientPostcode.Text.Length <= 0
                || textBoxClientPhone.Text.Length <= 0)
            {
                MessageBox.Show("Caractere insuficiente in una sau mai multe rubrici.");
                return;
            }

            Client clientNew = new Client(
                textBoxClientName.Text,
                textBoxClientPassword.Text,
                textBoxClientEmail.Text,
                textBoxClientAddress.Text,
                textBoxClientCity.Text,
                Int32.Parse(textBoxClientPostcode.Text),
                Int32.Parse(textBoxClientPhone.Text));

            ClientsDAO clientsDAO = new ClientsDAO();
            clientsDAO.AddNewClient(clientNew);

            this.Close();
        }

        private void ConfirmExitKeys(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SignUpClient();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SignUpClient();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
