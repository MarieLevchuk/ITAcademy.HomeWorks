using System;
using System.Text;

namespace HW._08.Task3
{
    class Program
    {
        static void Main(string[] args)
        {            
            StringBuilder str = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");            
            Console.WriteLine($"Исходная строка: {str.ToString()}");
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '?')
                {
                    index = i;
                    break;
                }
            }
            for (int k = str.Length-1; k > index ; k--)
            {
                if (Char.IsWhiteSpace(str[k]))
                {
                    str = str.Replace(str[k], '_',k,1);
                }
                
            }
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    if (str[j] == '!' || str[j] == '.')
                    {
                        str = str.Remove(j, 1);
                        index--;
                    }
                }
            }
            Console.WriteLine($"Форматированная строка: {str.ToString()}");
        }
    }
}
