using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectsManager
{
    public enum PasswordScore
    {
        Blank = 0,
        TooShort = 1,
        VeryWeak = 2,
        Weak = 3,
        Medium = 4,
        Strong = 5,
        VeryStrong = 6
    }

    public class PassworChecker
    {
        public static PasswordScore CheckStrength(string password)
        {
            int score = 0;

            if (password.Length < 1)
                return PasswordScore.Blank;
            if (password.Length < 8)
                return PasswordScore.TooShort;
            else
            {
                score++;
                if (password.Length >= 8)
                    score++;
                if (password.Length >= 12)
                    score++;
                if (Regex.IsMatch(password, "\\d+"))
                    score++;
                if (Regex.IsMatch(password, "[a-z]") &&
                  Regex.IsMatch(password, "[A-Z]"))
                    score++;
                if (Regex.IsMatch(password, "[\\.,!,@,#,$,%,^,&,*,?,_,~,-,€,(,)]"))
                    score++;
            }
            return (PasswordScore)score;
        }
    }
}
