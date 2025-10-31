using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MalcevDV.Sprint3.Task3.V23.Lib
{
    public class DataService : ISprint3Task3V23
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            char[] characters = value.ToCharArray();
            int index = 0;

            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    characters[index] = replacement;
                }
                index++;
            }

            return new string(characters);
        }
    }
}
