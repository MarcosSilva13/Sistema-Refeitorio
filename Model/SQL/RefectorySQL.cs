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
    public class RefectorySQL : Connection
    {
        public Student GetData(Student student)
        {
            int raStudent = 0;
            string name = "";
            string cpf = "";
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

                if (raStudent == 0 || cpf.Equals(""))
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso");
                    return null;
                }

                Student studentF = new Student(raStudent,
                                               name,
                                               cpf,
                                               picture,
                                               coffeCredit,
                                               lunchCredit,
                                               dinnerCredit);

                reader.Close();

                return studentF;
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

        public int UpdateCoffeSQL(Student student)
        {
            if(student.CoffeCredit <= 0)
            {
                return 0;
            }

            try
            {
                Connect();

                string update = "UPDATE students SET coffeCredit = @coffeCredit " +
                                "WHERE raStudent = @raStudent OR cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@coffeCredit", student.CoffeCredit-1);
                

                cmd.ExecuteNonQuery();

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

        public int UpdateLunchSQL(Student student)
        {
            if (student.LunchCredit <= 0)
            {
                return 0;
            }

            try
            {
                Connect();

                string update = "UPDATE students SET lunchCredit = @lunchCredit " +
                                "WHERE raStudent = @raStudent OR cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@lunchCredit", student.LunchCredit - 1);


                cmd.ExecuteNonQuery();

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

        public int UpdateDinnerSQL(Student student)
        {
            if (student.DinnerCredit <= 0)
            {
                return 0;
            }

            try
            {
                Connect();

                string update = "UPDATE students SET dinnerCredit = @dinnerCredit " +
                                "WHERE raStudent = @raStudent OR cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@dinnerCredit", student.DinnerCredit - 1);


                cmd.ExecuteNonQuery();

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
