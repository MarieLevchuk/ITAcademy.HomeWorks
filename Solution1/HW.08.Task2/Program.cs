using System;

namespace HW._08.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Удалить самое длинноееееее слово.";
            Console.WriteLine($"Исходная строка: \"{str}\"");
            Console.WriteLine("\nп.1: удалить самое длинное слово:");
            RemoveMaxLengthWord(str);
            RemoveMaxLengthWord("\nп.2: поменять местами самое длинное и самое короткое слово:");
            ExchangeMaxWordWithMin(str);
            Console.WriteLine("\nп.3: Посчитать количество букв и знаков препинания в строке: ");
            CountLettersAndPunktuations(str);
            Console.WriteLine("\nп.4: сортировать по длине слов:");
            ToArrayAndSort(str);
        }
        static void RemoveMaxLengthWord(string s)
        {
            string[] arr = s.Split(new Char[] { ' ', '.' });            
            int maxLength = 0, index=0;
            string maxWord = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > maxLength)
                {                    
                    maxLength = arr[i].Length;                    
                    maxWord = arr[i];
                }
            }
            index = s.IndexOf(maxWord);
            Console.WriteLine(s.Remove(index,maxWord.Length));                      
        }
        static void ExchangeMaxWordWithMin(string s)
        {            
            string[] arr = s.Split(new Char[] { ' ', '.' });
            string max=arr[0];
            string min=arr[0];
            int indexMax=0, indexMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > max.Length)
                {
                    max = arr[i];
                    indexMax = i;
                }                    
                if (arr[i].Length < min.Length && arr[i].Length>0)
                {
                    min = arr[i];
                    indexMin = i;
                }                    
            }
            arr[indexMax] = min;
            arr[indexMin] = max;
            s = String.Join(" ",arr); 
            Console.WriteLine(s);
        }
        static void CountLettersAndPunktuations(string s)
        {
            s = s.Replace(" ", String.Empty);            
            int letterCount = 0;
            int punctCount = 0;
            foreach (var item in s)
            {
                if (Char.IsPunctuation(item))
                {
                    punctCount++;
                }
                if (Char.IsLetter(item))
                {
                    letterCount++;
                }
            }
            Console.WriteLine($"Букв:{letterCount}, знаков препинания: {punctCount}");
        }
        static void ToArrayAndSort(string s)
        {
            string[] arr = s.Split(new Char[] { ' ', '.' });
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        string k = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = k;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
