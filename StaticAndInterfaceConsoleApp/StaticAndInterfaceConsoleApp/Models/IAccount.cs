using System;

namespace StaticAndInterfaceConsoleApp.Models
{
    internal interface IAccount
    {

        public static bool PasswordChecker(string password)
        {
            try
            {
                if (password.Length < 8 || IsUp(password) || IsLo(password) || IsNum(password))
                {
                L1: Console.WriteLine("Password standartlara uygun deyil tekrar daxil edin: ");
                    password = Console.ReadLine();
                    if (password.Length < 0 || IsUp(password) || IsLo(password) || IsNum(password))
                    {
                        goto L1;
                    }

                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public void ShowInfo()
        {
            Console.WriteLine("acount info");
        }
        static bool IsUp(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsLo(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsNum(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsNumber(password[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
