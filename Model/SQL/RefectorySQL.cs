using MySqlConnector;
using System;
using SistemaRefeitorio.Model.Entities;
using System.Windows.Forms;

namespace SistemaRefeitorio.Model.SQL
{
    public class RefectorySQL : Connection
    {
        public Student GetData(Student student)
        {
            int raStudent = -1;
            string name = String.Empty;
            string cpf = String.Empty;
            byte[] picture = null;
            int coffeCredit = 0;
            int lunchCredit = 0;
            int dinnerCredit = 0;

            try
            {
                Connect();

                string select = "SELECT raStudent, name, cpf, picture, OCTET_LENGTH(picture)," +
                                "coffeCredit, lunchCredit, dinnerCredit FROM students WHERE cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(select, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@cpf", student.Cpf);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    raStudent = reader.GetInt32(0);
                    name = reader.GetString(1);
                    cpf = reader.GetString(2);
                    if (reader.IsDBNull(4) == false)
                    {
                        int sizeImage = reader.GetInt32(4);
                        picture = new byte[sizeImage];
                        reader.GetBytes(3, 0, picture, 0, sizeImage);
                    }
                    coffeCredit = reader.GetInt32(5);
                    lunchCredit = reader.GetInt32(6);
                    dinnerCredit = reader.GetInt32(7);
                }

                if (raStudent == -1 || cpf.Equals(String.Empty))
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                Student studentF = new Student(raStudent, name, cpf, picture, coffeCredit, lunchCredit, dinnerCredit);

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

        public int UpdateCoffeSQL(Student student)
        {
            if(student.CoffeCredit <= 0)
            {
                return 0;
            }

            Connect();

            MySqlTransaction mySqlTransaction = SqlConnection.BeginTransaction();

            try
            {
                string update = "UPDATE students SET coffeCredit = @coffeCredit " +
                                "WHERE cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@coffeCredit", student.CoffeCredit - 1);

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

        public int UpdateLunchSQL(Student student)
        {
            if (student.LunchCredit <= 0)
            {
                return 0;
            }

            Connect();

            MySqlTransaction mySqlTransaction = SqlConnection.BeginTransaction();

            try
            {
                string update = "UPDATE students SET lunchCredit = @lunchCredit " +
                                "WHERE cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@lunchCredit", student.LunchCredit - 1);

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

        public int UpdateDinnerSQL(Student student)
        {
            if (student.DinnerCredit <= 0)
            {
                return 0;
            }

            Connect();

            MySqlTransaction mySqlTransaction = SqlConnection.BeginTransaction();

            try
            {
                string update = "UPDATE students SET dinnerCredit = @dinnerCredit " +
                                "WHERE cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@dinnerCredit", student.DinnerCredit - 1);

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
