using MySqlConnector;
using System;
using SistemaRefeitorio.Model.Entities;
using System.Windows.Forms;

namespace SistemaRefeitorio.Model.SQL
{
    public class StudentSQL : Connection
    {
        public int Insert(Student student)
        {
            Connect();

            MySqlTransaction mySqlTransaction = SqlConnection.BeginTransaction();

            try
            {
                string insert = "INSERT INTO students (raStudent, name, email, cpf, telephone, picture, " +
                                "picturePath) VALUES " +
                                "(@raStudent, @name, @email, @cpf, @telephone, @picture, @picturePath)";

                MySqlCommand cmd = new MySqlCommand(insert, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@telephone", student.Telephone);
                cmd.Parameters.AddWithValue("@picture", student.Picture);
                cmd.Parameters.AddWithValue("@picturePath", student.PicturePath);

                cmd.Transaction = mySqlTransaction;
                
                cmd.ExecuteNonQuery();
                
                mySqlTransaction.Commit();

                return 1;
            }
            catch (Exception ex)
            {
                mySqlTransaction.Rollback();

                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw ex;
                return 0;
                
            } 
            finally
            {
                Disconnect();
            }
      
        }

        public Student GetData(Student student)
        {
            int raStudent = -1;
            string name = String.Empty;
            string email = String.Empty;
            string cpf = String.Empty;
            string telephone = String.Empty;
            byte[] picture = null;
            string picturePath = String.Empty;

            try
            {
                Connect();

                string select = "SELECT raStudent, name, email, cpf, telephone, picture, picturePath, " +
                                "OCTET_LENGTH(picture) FROM students WHERE raStudent = @raStudent";

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
                    telephone = reader.IsDBNull(4) ? String.Empty : reader.GetString(4);
                    picturePath = reader.IsDBNull(6) ? String.Empty : reader.GetString(6);
                    if(reader.IsDBNull(7) == false)
                    {
                        int sizeImage = reader.GetInt32(7);
                        picture = new byte[sizeImage];
                        reader.GetBytes(5, 0, picture, 0, sizeImage);
                    }
                   
                }

                if(raStudent == -1)
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                Student studentF = new Student(raStudent, name, email, cpf, telephone, picture, picturePath);

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

        public int Update(Student student)
        {
            Connect();

            MySqlTransaction mySqlTransaction = SqlConnection.BeginTransaction();

            try
            {
                string update = "UPDATE students SET name = @name, email = @email, cpf = @cpf," +
                                "telephone = @telephone, picture = @picture, picturePath = @picturePath " +
                                "WHERE raStudent = @raStudent;";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@telephone", student.Telephone);
                cmd.Parameters.AddWithValue("@picture", student.Picture);
                cmd.Parameters.AddWithValue("@picturePath", student.PicturePath);

                cmd.Transaction = mySqlTransaction;

                cmd.ExecuteNonQuery();

                mySqlTransaction.Commit();

                return 1;
            }
            catch (Exception ex)
            {
                mySqlTransaction.Rollback();
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw ex;
                return 0;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
