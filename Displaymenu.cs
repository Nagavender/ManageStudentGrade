using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStrudentGradeNK
{
    class Displaymenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("WELCOME TO STUDENT`S GRADE SYSTEM");
            Console.WriteLine();
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Add Grade");
            Console.WriteLine("3. Print Grade");
            Console.WriteLine("4. Print Lowest Grade");
            Console.WriteLine("5. Print best student");
            Console.WriteLine("6. Update Grade of a student");
            Console.WriteLine("7. Delete Grade of a student");
            Console.WriteLine("8. Delete a Student");
            Console.WriteLine("9. Exit");
            Console.ReadLine();
        }
    }
}
