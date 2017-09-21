using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    // string connString = "Server=CORI\\SQLEXPRESS; Data Source=.\\SQLEXPRESS; Initial Catalog=pubs; Integrated Security=true";
    {
        static void Main(string[] args)
        {

            var dbContext = new PlutoDBContext();
            var courses = dbContext.GetCourses();
            foreach ( var course in courses )
            {
                Console.WriteLine(course.Title);
            }
        }
    }
}
