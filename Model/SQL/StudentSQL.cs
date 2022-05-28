using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRefeitorio.Model.Entities;
using System.Windows.Forms;

namespace SistemaRefeitorio.Model.SQL
{
    public class StudentSQL : Connection
    {
      public int Insert(Student student)
      {     
            try
            {
                Connect();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO students (raStudent, name, email, cpf, telephone) VALUES " +
                    "('" + student.RaStudent + "', '" + student.Name + "', '" + student.Email + "', '" + student.Cpf + "', '" + student.Telephone + "');", SqlConnection);

                cmd.ExecuteReader();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            } 
            finally
            {
                Disconnect();
            }
      
      }
    }
}
