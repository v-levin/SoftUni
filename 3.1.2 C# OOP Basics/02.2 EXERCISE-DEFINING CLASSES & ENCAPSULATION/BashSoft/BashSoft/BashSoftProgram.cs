using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class BashSoftProgram
    {
        public static void Main()
        {
            // Lab 1 Tests
            //IOManager.TraverseDirectory(@"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft");
            //IOManager.TraverseDirectory();
            //IOManager.TraverseDirectory(0);

            // Lab 2 Tests
            //StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            // Lab 3 Tests
            //Tester.CompareContent(@"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft-FirstWeek-Tasks\03. CSharp-Advanced-Files-And-Directories-Lab\test2.txt", @"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft-FirstWeek-Tasks\03. CSharp-Advanced-Files-And-Directories-Lab\test3.txt");
            //Tester.CompareContent(@"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft-FirstWeek-Tasks\04. CSharp-Advanced-Exception-Handling-Lab\expected.txt", @"D:\SoftUni\3.1.1 C# Advanced\02.2 EXERCISE-LINEAR STRUCTURES - OVERVIEW\BashSoft-FirstWeek-Tasks\04. CSharp-Advanced-Exception-Handling-Lab\actual.txt");
            //IOManager.CreateDirectoryInCurrentFolder("pesho");
            //IOManager.TraverseDirectory(900);

            // Lab 4 Tests
            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(20);
            //IOManager.CreateDirectoryInCurrentFolder("*2");

            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");
            //IOManager.ChangeCurrentDirectoryRelative("..");

            // Lab 5 Test
            //InputReader.StartReadingCommands();

            Tester tester = new Tester();
            IOManager ioManager = new IOManager();
            StudentRepository repo = new StudentRepository(new RepositoryFilter(), new RepositorySorter());

            CommandInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            InputReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}
