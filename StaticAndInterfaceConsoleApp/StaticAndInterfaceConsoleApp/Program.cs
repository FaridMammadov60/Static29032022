using StaticAndInterfaceConsoleApp.Models;
using System;
using System.Text;

namespace StaticAndInterfaceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                #region User Create
                User farid = new User("faridmma@code.edu.az", "Farid.mammadov60")
                {
                    Fullname = "Farid Mammadov"
                };
            #endregion

            #region OneMenyu
            L1:
                Console.WriteLine("");
                Console.WriteLine($"1. Show info\n" +
                    $"2. Create new group");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case (int)MenyuOne.ShowInfo:
                        farid.ShowInfo();
                        goto L1;
                    case (int)MenyuOne.CreateNewGroup:
                        goto L2;
                    default:
                        Console.Clear();
                        Console.WriteLine("Aşağıda qeyd edilən 1 ve ya 2 düymesin seçin!!!");
                        goto L1;
                }
            #endregion

            #region AddStudent
            L2:
                Console.Write("Qeyd: bir qrupda 5-dən az 18-den cox tələbə ola bilməz.\n" +
                    "Qrupda təhsil alacaq tələbələrin sayın daxil edin (1-18 aralığında): ");
                int num = Group.StudentLimit(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Qrupun nörəsin təyin edin: ");
                string groupNo = Console.ReadLine();
                Group group = new Group(num, groupNo)
                {                    
                    
                };
                for (int i = 0; i < num; i++)
                {
                    Console.Write($"{i + 1} Tələbənin adı ve soyadın daxil edin: ");
                    string fullname = Console.ReadLine();
                    Console.Write($"{i + 1} Tələbənin balın daxil edin: ");
                    double point = Convert.ToDouble(Console.ReadLine());
                    group[i] = new Student(fullname, point);
                }
                #endregion

                #region TwoMenyu
                Console.Clear();
            S1: Console.WriteLine("1. Show all students\n" +
                    "2. Get student by id\n" +
                    "3. Add student\n" +
                    "0. Quit");
                Console.WriteLine("______________");
                int b = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region Switch
                switch (b)
                {
                    case (int)MenyuTwo.Quit:
                        return;
                    case (int)MenyuTwo.ShowAllStudents:
                        group.GetAllStudent();
                        goto S1;
                    case (int)MenyuTwo.GetStudentById:
                        Console.Write("Tələbənin İd-sin daxil edin: ");
                        int stid = Convert.ToInt32(Console.ReadLine());
                        group.GetStudent(stid);
                        goto S1;
                    case (int)MenyuTwo.AddStudent:
                        Console.Write($"Tələbənin adın ve soyadın daxil edin: ");
                        string fullname2 = Console.ReadLine();
                        Console.Write($"Tələbənin balın daxil edin: ");
                        double point2 = Convert.ToDouble(Console.ReadLine());
                        Student student5 = new Student(fullname2, point2);
                        group.AddStudent(student5);
                        goto S1;
                    default:
                        Console.Clear();
                        Console.WriteLine("Aşağida qeyd edilen 0-4 araliginda reqem secin!!!");
                        goto S1;
                }
                #endregion

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }        

        }
    }
}
