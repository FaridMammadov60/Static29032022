using System;
using System.Text.RegularExpressions;

namespace StaticAndInterfaceConsoleApp.Models
{

    public static partial class RegularExtention
    {
        //Elave olaraq yazilib test kimi
        public const string Email_Pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public const string Phone_Pattern = @"^(?<olkekodu>\+994|0)(?<operator>50|51||55|60|70|77|99)-(\d{3}-\d{2}-\d{2})$";
        public const string Name_Pattern = @"^[A-ZĞÖÜƏIŞÇ]{1}[a-zğöəıüşç]{2,}$";
        public const string Password_Pattern = @"^((?=.*\d)(?=.*[A-Z])(?=.*[a-z])).{8,}$";
        public static bool isEmail(this string email)
        {
            Match emailResult = Regex.Match(email, Email_Pattern);
            if (emailResult.Success)
                return true;
            return false;
        }
        public static bool isPhone(this string phone)
        {
            //Match phoneResult = Regex.Match(phone, Phone_Pattern);
            if (Regex.IsMatch(phone, Phone_Pattern))
                return true;
            return false;
        }
        public static bool isName(this string name)
        {
            //Match nameResult = Regex.Match(name, Phone_Pattern);
            if (Regex.IsMatch(name, Name_Pattern))
                return true;
            return false;
        }
        public static bool isPassword(this string password)
        {
            //Match passwordResult = Regex.Match(password, Phone_Pattern);
            if (Regex.IsMatch(password, Password_Pattern))
                return true;
            return false;
        }
    }
}
