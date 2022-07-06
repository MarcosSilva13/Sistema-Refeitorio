using MySqlConnector;
using System;
using SistemaRefeitorio.Model.Entities;
using System.Windows.Forms;

namespace SistemaRefeitorio.Model.SQL
{
    public class CreditSQL : Connection
    {
        public Student GetDataCredit(Student student)
        {
            int raStudent = -1;
            string name = String.Empty;
            string email = String.Empty;
            string cpf = String.Empty;
            int coffeCredit = 0;
            int lunchCredit = 0;
            int dinnerCredit = 0;
            string telephone = String.Empty;
            byte[] picture = null;

            try
            {
                Connect();

                string select = "SELECT raStudent, name, email, cpf, coffeCredit, lunchCredit, " +
                                "dinnerCredit, telephone, picture, OCTET_LENGTH(picture)" +
                                "FROM students WHERE raStudent = @raStudent";

                MySqlCommand cmd = new MySqlCommand(select, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);

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
                    if (reader.IsDBNull(9) == false)
                    {
                        int sizeImage = reader.GetInt32(9);
                        picture = new byte[sizeImage];
                        reader.GetBytes(8, 0, picture, 0, sizeImage);
                    }
                }

                if (raStudent == -1)
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                Student studentF = new Student(raStudent, name, email, cpf, telephone, coffeCredit, lunchCredit, dinnerCredit, picture);

                reader.Close();

                return studentF;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw ex;
                return null;
            }
            finally
            {
                Disconnect();
            }

        }

        public int UpdateCredit(Student student)
        {
            if(student.CoffeCredit < 0 || student.LunchCredit < 0 || student.DinnerCredit < 0)
            {
                MessageBox.Show("Não é permitido valores negativos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            Connect();

            MySqlTransaction mySqlTransaction = SqlConnection.BeginTransaction();

            try
            {
                string update = "UPDATE students SET coffeCredit = @coffeCredit, lunchCredit = @lunchCredit," +
                                "dinnerCredit = @dinnerCredit WHERE raStudent = @raStudent;";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@coffeCredit", student.CoffeCredit);
                cmd.Parameters.AddWithValue("@lunchCredit", student.LunchCredit);
                cmd.Parameters.AddWithValue("@dinnerCredit", student.DinnerCredit);

                cmd.Transaction = mySqlTransaction;

                cmd.ExecuteNonQuery();

                mySqlTransaction.Commit();

                return 1;
            }
            catch (Exception ex)
            {
                mySqlTransaction.Rollback();
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
                //throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
