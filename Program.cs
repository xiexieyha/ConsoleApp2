using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Entity;

namespace ConsoleApp3.Reposotory
{
    abstract class Department
    {

        public int id { get; set; }
        private decimal budget { get; set; }
        public List<string>? Course { get; set; }
    }

    public interface IPersonService<T> where T : class
    {
        void age(T entity);
        void salary(T entity);
        void Address(T entity);
    }

    public class Student : IPersonService<Person>
    {
        public List<string>? Course { get; set; }
        public double gpa { get; set; }
        public override decimal salary { get; set; }
        public string? grade { get; set; }
    }

    class Instructor : Department, IPersonService<Person>
    {
        public override decimal salary { get; set; }
        public int deptID { get; set; }
    }

    class Course 
    {
        public List<string> EnrolledStudents{get; set;} 
   

           

    }

    
}

    
    }

    

    }
}
