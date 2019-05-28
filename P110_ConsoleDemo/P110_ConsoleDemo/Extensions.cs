using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace P110_ConsoleDemo
{
    public static class Extensions
    {
        public static bool IsEmail(this string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int Pow(this int basePower, int power)
        {
            return (int)Math.Pow(basePower, power);
        }

        public static void Demo(this Journal journal)
        {
        }
    }
}
