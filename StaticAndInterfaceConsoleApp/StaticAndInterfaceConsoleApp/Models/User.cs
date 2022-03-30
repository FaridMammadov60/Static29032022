using System;

namespace StaticAndInterfaceConsoleApp.Models
{
    internal class User : IAccount
    {
        #region Fields
        static int _id;
        string _fullname;
        string _email;
        string _password;
        #endregion

        #region Construction
        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
            _id++;

        }
        #endregion

        #region Property
        public string Password
        {
            
            get
            {
                return _password;
            }
            set
            {
                try
                {
                    if (IAccount.PasswordChecker(value))
                    {
                        _password = value;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
               

            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }
        #endregion

        public void ShowInfo()
        {
            Console.WriteLine($"User fullname: {Fullname}\n" +
                $"\n" +
                $"User pasword: {Password} \n" +
                $"\n" +
                $"User email:  {Email}");
        }

        public override string ToString()
        {
            return $"UserID: {Id}\n" +
                $"Password uzunluğu {Password.Length}";
        }
    }
}
