using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class BashSoftProgram
    {
        static void Main()
        {
            //IOManager.TraverseDirectory(@"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft");
            //IOManager.TraverseDirectory();
            IOManager.TraverseDirectory(0);

            //StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            //Tester.CompareContent(@"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft-FirstWeek-Tasks\03. CSharp-Advanced-Files-And-Directories-Lab\test2.txt", @"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft-FirstWeek-Tasks\03. CSharp-Advanced-Files-And-Directories-Lab\test3.txt");

            //IOManager.CreateDirectoryInCurrentFolder("pesho");
        }
    }
}
