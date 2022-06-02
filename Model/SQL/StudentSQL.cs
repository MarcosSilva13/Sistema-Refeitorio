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

                string insert = "INSERT INTO students (raStudent, name, email, cpf, telephone) VALUES " +
                    "(@raStudent, @name, @email, @cpf, @telephone)";

                MySqlCommand cmd = new MySqlCommand(insert, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@telephone", student.Telephone);

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return 0;
                throw ex;
            } 
            finally
            {
                Disconnect();
            }
      
        }

        public Student GetData(Student student)
        {
            int raStudent = 0;
            string name = "";
            string email = "";
            string cpf = "";
            string telephone = "";

            try
            {
                
                Connect();

                string select = "SELECT raStudent, name, email, cpf, telephone FROM students WHERE raStudent = @raStudent";

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
                    
                }

                if(raStudent == 0)
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso");
                    return null;
                }

                Student studentF = new Student(raStudent, name, email, cpf, telephone);

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

        public int Update(Student student)
        {
            try
            {
                Connect();

                string update = "UPDATE students SET name = @name, email = @email, cpf = @cpf, telephone = @telephone " +
                    "WHERE raStudent = @raStudent;";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@cpf", student.Cpf);
                cmd.Parameters.AddWithValue("@telephone", student.Telephone);

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
