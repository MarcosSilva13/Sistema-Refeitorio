using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRefeitorio.Model
{
    public class Connection
    {
        protected MySqlConnection SqlConnection { get; private set; }
        private const string CONNECTION_STRING = "DATABASE=refeitorio; port=3306; SERVER=localhost; username=root; password=''";

        protected async Task Connect()
        {
            try
            {
                SqlConnection = new MySqlConnection(CONNECTION_STRING);
                await SqlConnection.OpenAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected async Task Disconnect()
        {
            try
            {
                await SqlConnection.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
