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
    public class ListStudentSQL : Connection
    {
        public void GetDataStudent(DataGridView dgListStudent)
        {
           /* int raStudent = -1;
            string name = String.Empty;
            string email = String.Empty;
            string cpf = String.Empty;
            int coffeCredit = 0;
            int lunchCredit = 0;
            int dinnerCredit = 0;
            string telephone = String.Empty;*/

            try
            {
                Connect();

                string select = "SELECT raStudent, name, email, cpf, coffeCredit, lunchCredit, " +
                                "dinnerCredit, telephone FROM students ORDER BY name";

                MySqlCommand cmd = new MySqlCommand(select, SqlConnection);

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int raStudent = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string email = reader.GetString(2);
                        string cpf = reader.GetString(3);
                        int coffeCredit = reader.GetInt32(4);
                        int lunchCredit = reader.GetInt32(5);
                        int dinnerCredit = reader.GetInt32(6);
                        string telephone = reader.IsDBNull(7) ? String.Empty : reader.GetString(7);

                        dgListStudent.Rows.Add(raStudent, name, email, cpf, telephone,
                                                coffeCredit, lunchCredit, dinnerCredit);
                    }

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw ex;
                return;
            }
            finally
            {
                Disconnect();
            }
        }

        public void GetDataByRa(DataGridView dgListStudent, int ra)
        {
            int raStudent = -1;
            string name = String.Empty;
            string email = String.Empty;
            string cpf = String.Empty;
            int coffeCredit = 0;
            int lunchCredit = 0;
            int dinnerCredit = 0;
            string telephone = String.Empty;

            try
            {
                Connect();

                string selectRa = "SELECT raStudent, name, email, cpf, coffeCredit, lunchCredit, " +
                                "dinnerCredit, telephone FROM students WHERE raStudent = @raStudent";

                MySqlCommand cmd = new MySqlCommand(selectRa, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", ra);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    raStudent = reader.GetInt32(0);
                    name = reader.GetString(1);
                    email = reader.GetString(2);
                    cpf = reader.GetString(3);
                    coffeCredit = reader.GetInt32(4);
                    lunchCredit = reader.GetInt32(5);
                    dinnerCredit = reader.GetInt32(6);
                    telephone = reader.IsDBNull(7) ? String.Empty : reader.GetString(7);
                }

                if(raStudent == -1)
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgListStudent.Rows.Add(raStudent, name, email, cpf, telephone, coffeCredit, 
                                                                lunchCredit, dinnerCredit);

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
                return;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
