using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
          if (value == null || value.Length == 0)
            {
                return false;
            }

            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            foreach (char c in value)
            {
                if (alphabet.IndexOf(c) < 0)
                {
                    return false;
                }
            }
            return true;
        }   

    }
}
