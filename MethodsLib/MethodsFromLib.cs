using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MethodsLib
{
    public static class MethodsFromLibStatic
    {
        public static bool Authorization(string Login, string Password)
        {
            var data = RepetitorsBasePracticEntities.GetContext();
            var sign = from repetitor in data.Repetitors
                       where repetitor.Login == Login
                       where repetitor.Password == Password
                       select repetitor;
           
            if(sign == null|| !sign.Any() )
            {
                return true;
            }
            return false;
    }
    }
    public class MethodsFromLib
    {
        public static bool ContainsLowerLetter(string Password)
        {
            foreach (char c in Password)
            {
                if (Char.IsLetter(c) && Char.IsLower(c))
                    return true;

            }
            return false;
        }
        public static bool ContainsUpperLetter(string Password)
        {
            foreach (char c in Password)
            {
                if ((Char.IsLetter(c) && (Char.IsUpper(c))))
                    return true;
            }
            return false;
        }
        public static bool ContainDigit(string Password)
        {
            foreach (char c in Password)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }
        public static bool ContainPunctuation(string Password)
        {
            foreach (char c in Password)
            {
                if (Char.IsPunctuation(c))
                    return true;
            }
            return false;
        }
        public static bool ContainSeparator(string Password)
        {
            foreach (char c in Password)
            {
                if (Char.IsSeparator(c))
                    return true;
            }
            return false;
        }
        public static bool ContainMax(string Password)
        {
            
            foreach (char c in Password)
            {
                if (Password.Length < 21)
                    return true;
            }
            return false;
        } 
        public static bool ContainMin(string Password)
        {
            
            foreach (char c in Password)
            {
                if (Password.Length > 7)
                    return true;
            }
            return false;
        }
        public static bool CorrectPass(string Password)
        {
            Regex regex = new Regex("^(?=.*[a-zA-Z])(?=.*\\d)(?=.*[#&%^$_]).{8,20}$");

            return regex.Match(Password).Success;
        }
        public static bool ContainSpec(string Password)
        {
            Regex regex = new Regex("^[#&%^$_]");

            return regex.Match(Password).Success;
        }

    }
}
