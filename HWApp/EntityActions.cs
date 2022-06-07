using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWApp;
using HWApp.Models;

namespace HWApp
{
    public class EntityActions
    {
        public static void CreateStudent()
        {
            Console.WriteLine("Entere name");
            string name = Console.ReadLine();

            Student student = new Student(name);

            using (var context = new SchoolContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
        public static void DeleteStudent()
        {
            Console.WriteLine("Entere id to remove");
            int id = int.Parse(Console.ReadLine());
            using (var context = new SchoolContext())
            {
                var student = context.Students.SingleOrDefault(X => X.StudentId == id);
                if (student != null)
                    context.Students.Remove(student);
                context.SaveChanges();

            }


        }
        public static void UpdateStudent()
        {
            Console.WriteLine("Enter the id of the student for update");
            int id = int.Parse(Console.ReadLine());
            using (var context = new SchoolContext())
            {
                var student = context.Students.SingleOrDefault(x => x.StudentId == id);
                Console.WriteLine("Enter the new name for the student");
                student.Name = Console.ReadLine();
                context.SaveChanges();
            }
        }
        public static void GetStudent()
        {
            Console.WriteLine("Enter the id of the student for getting details");
            int id = int.Parse(Console.ReadLine());
            using (var context = new SchoolContext())
            {
                var student = context.Students.SingleOrDefault(x => x.StudentId == id);
                Console.WriteLine(student.Name);

            }
        }
        public static void GetListStudents()
        {
            using (var context = new SchoolContext())
            {
                var students = context.Students.ToList();
                students.ForEach(x => Console.WriteLine("id: " + x.StudentId + " Name: " + x.Name));
            }
        }
    }
}
