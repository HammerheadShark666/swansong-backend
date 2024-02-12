using System;
using System.Text;

namespace SwanSong.xUnit.Test.Helpers;

public class UnitTestHelper
{
    public static string generateRandomString(int length)
    {
        StringBuilder str_build = new();
        Random random = new();

        char letter;

        for (int i = 0; i < length; i++)
        {
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            letter = Convert.ToChar(shift + 65);
            str_build.Append(letter);
        }

        return str_build.ToString();
    }
}
