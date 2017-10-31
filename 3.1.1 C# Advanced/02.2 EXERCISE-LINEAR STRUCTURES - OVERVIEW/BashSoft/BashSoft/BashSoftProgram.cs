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

            StudentsRepository.InitializeData();
            StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
        }
    }
}
