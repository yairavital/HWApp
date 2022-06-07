using HWApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HWApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new SchoolContext())
            //{
            //    var students = new List<string> { "David", "Elie" }.Select(x => new Student() { Name = x }).ToList();
            //    context.Students.AddRange(students);
            //    context.SaveChanges();
            //    var studentsFromDb = context.Students.ToList();
            //    studentsFromDb.ForEach(x => Console.WriteLine(x.Name));

            //}
            Action();

        }
      public  static void Action()
        {
            Console.WriteLine("Press a number between 1 to 6 for: \n 1.Create an Entity." +
                " \n 2.Delete an Entity. \n 3.Update an Entity. \n 4.Get Entity Details. \n " +
                "5.Get the List of entities. \n 6.Quit the app");
            int choice = int.Parse(Console.ReadLine());
            while(choice <1 || choice >6)
            {
                Console.WriteLine("Press a number between 1 to 6 for: \n 1.Create an Entity." +
                " \n 2.Delete an Entity. \n 3.Update an Entity. \n 4.Get Entity Details. \n " +
                "5.Get the List of entities. \n 6.Quit the app");
                choice = int.Parse(Console.ReadLine());
            }
            switch(choice)
            {
                case 1:
                    EntityActions.CreateStudent();
                    Action();
                    break;
                case 2:
                    EntityActions.DeleteStudent();
                    Action();
                    break;
                case 3:
                    EntityActions.UpdateStudent();
                    Action();
                    break;
                case 4:
                    EntityActions.GetStudent();
                    Action();
                    break;
                case 5:
                    EntityActions.GetListStudents();
                    Action();
                    break;
                case 6:
                    break;

            }









        }
    }
}
