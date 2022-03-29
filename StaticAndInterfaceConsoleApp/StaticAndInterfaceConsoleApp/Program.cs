using StaticAndInterfaceConsoleApp.Models;
using System;

namespace StaticAndInterfaceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User Create
            User farid = new User("faridmma@code.edu.az", "Farid.mammadov60")
            {
                Fullname = "Farid Mammadov"
            };
        #endregion

        #region OneMenyu
        L1:
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
                    Console.WriteLine("Aşağida qeyd edilen 1 ve ya 2 duymesin secin!!!");
                    goto L1;
            }
        #endregion

        L2:
            Console.Write("Qrupda tehsil alaca telebelerin sayin daxil edin\n" +
                "Qeyd: bir qrupda 5-den az 18-den cox telebe ola bilmez\n" +
                "1-18 araliginda bir reqem daxil edin: ");
            int num = Group.StudentLimit(Convert.ToInt32(Console.ReadLine()));

            Group group = new Group(num);
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine($"{i} Telebenin adin ve soyadin daxil edin: ");
            //    string fullname = Console.ReadLine();
            //    Console.WriteLine($"{i} Telebenin balin daxil edin: ");
            //    double point = Convert.ToDouble(Console.ReadLine());
            //    group[i] = new Student(fullname, point);
            //}
            #region MyRegion
            Student student = new Student("Ali Abbasli", 75);
            group[0] = student;
            Console.WriteLine(group[0]);
            Student student1 = new Student("Muhammed Ali", 100);
            group[1] = student1;
            Console.WriteLine(group[1]);
            Student student2 = new Student("Corc John", 57);
            group[2] = student2;
            Console.WriteLine(group[2]);
            Student student3 = new Student("test testov", 45);
            group[3] = student3;
            Console.WriteLine(group[3]);
            Student student4 = new Student("testli test", 67);
            group[4] = student4;
        Console.WriteLine(group);
            #endregion
            Console.Clear();
        S1: Console.WriteLine("1. Show all students\n" +
                "2. Get student by id\n" +
                "3. Add student\n" +
                "0. Quit");

            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case (int)MenyuTwo.Quit:
                    return;
                case (int)MenyuTwo.ShowAllStudents:
                    group.GetAllStudent();
                    Console.WriteLine();
                    break;
                case (int)MenyuTwo.GetStudentById:
                    Console.WriteLine("Telebenin idsin daxil edin: ");
                    int stid=Convert.ToInt32(Console.ReadLine());
                    group.GetStudent(stid);
                    break;
                case (int)MenyuTwo.AddStudent:
                    break;                   
                default:
                    Console.Clear();
                    Console.WriteLine("Aşağida qeyd edilen 0-4 araliginda reqem secin!!!");
                    goto S1;
            }        

        }
    }
}
