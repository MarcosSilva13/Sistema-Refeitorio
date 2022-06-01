﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRefeitorio.Model.Entities;
using System.Windows.Forms;

namespace SistemaRefeitorio.Model.SQL
{
    public class CreditSQL : Connection
    {
        public Student GetDataCredit(Student student)
        {
            int raStudent = 0;
            string name = "";
            string email = "";
            string cpf = "";
            int coffeCredit = 0;
            int lunchCredit = 0;
            int dinnerCredit = 0;
            string telephone = "";

            try
            {

                Connect();

                //string sql = "SELECT raStudent, name, email, cpf, telephone FROM students WHERE raStudent = " + student.RaStudent;

                string select = "SELECT raStudent, name, email, cpf, coffeCredit, lunchCredit, dinnerCredit, telephone FROM students WHERE raStudent = @raStudent";

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

                }

                if (raStudent == 0)
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso");
                    return null;
                }

                Student sf = new Student(raStudent, name, email, cpf, telephone, coffeCredit, lunchCredit, dinnerCredit);

                reader.Close();

                return sf;

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

        public int UpdateCredit(Student student)
        {
            try
            {
                Connect();

                string update = "UPDATE students SET coffeCredit = @coffeCredit, lunchCredit = @lunchCredit, dinnerCredit = @dinnerCredit " +
                    "WHERE raStudent = @raStudent;";

                MySqlCommand cmd = new MySqlCommand(update, SqlConnection);

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@raStudent", student.RaStudent);
                cmd.Parameters.AddWithValue("@coffeCredit", student.CoffeCredit);
                cmd.Parameters.AddWithValue("@lunchCredit", student.LunchCredit);
                cmd.Parameters.AddWithValue("@dinnerCredit", student.DinnerCredit);

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
