using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWApp.Models
{
    public class Student
    {
        public Student( string name)
        {
           
            Name = name;
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
    }
}
