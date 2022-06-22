using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRefeitorio.Model.Entities
{
    public class Student
    {
        public int RaStudent { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }        public string Cpf { get; set; }        public string Telephone { get; set; }        public int CoffeCredit { get; set; }        public int LunchCredit { get; set; }        public int DinnerCredit { get; set; }        public byte[] Picture { get; set; }        public string PicturePath { get; set; }        public Student(){ }        public Student(int raStudent)
        {
            RaStudent = raStudent;
        }        public Student(string cpf)
        {
            Cpf = cpf;
        }        public Student(int raStudent, int coffeCredit, int lunchCredit, int dinnerCredit)
        {
            RaStudent = raStudent;
            CoffeCredit = coffeCredit;
            LunchCredit = lunchCredit;
            DinnerCredit = dinnerCredit;
        }        public Student(int raStudent, string name, string cpf, byte[] picture, int coffeCredit, int lunchCredit, int dinnerCredit)
        {
            RaStudent = raStudent;
            Name = name;
            Cpf = cpf;
            Picture = picture;
            CoffeCredit = coffeCredit;
            LunchCredit = lunchCredit;
            DinnerCredit = dinnerCredit;
        }        public Student(int raStudent, string name, string email, string cpf, string telephone, byte[] picture, string picturePath)
        {
            RaStudent = raStudent;
            Name = name;
            Email = email;
            Cpf = cpf;
            Telephone = telephone;
            Picture = picture;
            PicturePath = picturePath;
        }        public Student(int raStudent, string name, string email, string cpf, string telephone, int coffeCredit, int lunchCredit, int dinnerCredit, byte[] picture)
        {
            RaStudent = raStudent;
            Name = name;
            Email = email;
            Cpf = cpf;
            Telephone = telephone;
            CoffeCredit = coffeCredit;
            LunchCredit = lunchCredit;
            DinnerCredit = dinnerCredit;
            Picture = picture;
        }    }   
}
