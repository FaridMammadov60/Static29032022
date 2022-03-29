using System;
using System.Text.RegularExpressions;

namespace StaticAndInterfaceConsoleApp.Models
{
    internal class Group
    {
        #region Fields
        string _groupNo;
        Student[] _students;
        #endregion

        #region Constructor
        public Group(int length)
        {
            _students = new Student[length];
        }
        #endregion


        #region Property

        public Student this[int index]
        {
            get
            {
                if (index < _students.Length && index >= 0)
                {
                    return _students[index];
                }
                Console.WriteLine("sehv get");
                throw new Exception();
            }
            set
            {
                if (index < _students.Length && index >= 0)
                {
                    _students[index] = value;
                    return;
                }
                Console.WriteLine("sehv set");
                throw new Exception();

            }
        }
        public Student[] Students
        {
            get
            {
                return _students;
            }
        }

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
                else
                {
                C1: Console.WriteLine("Qrup nomresin 2 böyük hərf əvvəldə və 3 rəqəm olaraq daxil edin:");
                    value = Console.ReadLine();
                    if (CheckGroupNo(value))
                    {
                        _groupNo = value;
                    }
                    goto C1;
                }

            }
        }
        #endregion

        #region Method
        /// <summary>
        /// Qrupda olacaq telebelerin say limitini teyin edir
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int StudentLimit(int num)
        {
            if (num < 5 || num > 18)
            {
            L1: Console.WriteLine("5-18 araliginde reqem daxil edin: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 5 || num > 18)
                {
                    goto L1;
                }
                return num;
            }
            return num;
        }

        //Pattern ilk 2 herf boyuk sonra 3 reqem
        public const string GroupNo_Pattern = @"^[A-Z]{2}[\d]{3}$";
        public bool CheckGroupNo(string groupno)
        {
            if (Regex.IsMatch(groupno, GroupNo_Pattern))
            {
                return true;
            }
            return false;

        }

        public void GetStudent(int num)
        {

            Console.WriteLine(Students[num]);

        }

        public void GetAllStudent()
        {           
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i]);
            }           

        }

        public  void AddStudent()
        {

        }

        #endregion

        public override string ToString()
        {
            return $"Student {_students}";
        }
    }
}
