using StaticAndInterfaceConsoleApp.Models;
using System;

namespace StaticAndInterfaceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            #region AddStudent
            L2:
                Console.Write("Qrupda tehsil alaca telebelerin sayin daxil edin\n" +
                    "Qeyd: bir qrupda 5-den az 18-den cox telebe ola bilmez\n" +
                    "1-18 araliginda bir reqem daxil edin: ");
                int num = Group.StudentLimit(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Qrupun nomresin teyin edin: ");
                string groupNo = Console.ReadLine();
                Group group = new Group(num, groupNo)
                {                    
                    
                };
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"{i + 1} Telebenin adin ve soyadin daxil edin: ");
                    string fullname = Console.ReadLine();
                    Console.WriteLine($"{i + 1} Telebenin balin daxil edin: ");
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
                        Console.WriteLine("Telebenin idsin daxil edin: ");
                        int stid = Convert.ToInt32(Console.ReadLine());
                        group.GetStudent(stid);
                        goto S1;
                    case (int)MenyuTwo.AddStudent:
                        Console.WriteLine($"Telebenin adin ve soyadin daxil edin: ");
                        string fullname2 = Console.ReadLine();
                        Console.WriteLine($"Telebenin balin daxil edin: ");
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
