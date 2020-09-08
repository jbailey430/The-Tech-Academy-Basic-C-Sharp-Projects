using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var x = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Jake" };

                x.Students.Add(stud);
                x.SaveChanges();

                Console.Write("Student saved successfully!");
            }
        }
    }

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        { 
        
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
    }

    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
