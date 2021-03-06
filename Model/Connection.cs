using MySqlConnector;
using System;
using System.Windows.Forms;

namespace SistemaRefeitorio.Model
{
    public abstract class Connection
    {
        protected MySqlConnection SqlConnection { get; private set; }
        private const string CONNECTION_STRING = "DATABASE=refeitorio; port=3306; SERVER=localhost; username=root; password=Kurorotepshi_13";

        protected void Connect()
        {
            try
            {
                SqlConnection = new MySqlConnection(CONNECTION_STRING);
                SqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        protected void Disconnect()
        {
            try
            {
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
