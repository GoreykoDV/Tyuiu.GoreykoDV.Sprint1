using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoreykoDV.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {            
            foreach (char c in value)
            {
                if (!((c >= 'а' && c <= 'я') || c == 'ё'))
                    return false;
            }
            return true;
        }
    }
}
