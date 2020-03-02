using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //чтение файла image.txt по пути C:\Temp;
            //преобразование считанного файла в строку;
            //создание массива, который будет хранить информацию о байтах, преобразованных из строки;
            //описание цикла, который преобразовывает строковое представление числа в эквивалентное 8-битное и записывает его в массив;
            //создание файла image.png по пути C:\Temp.

            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();

            string[] arrayOfTextResult = textReaderResult.Split(' ');

            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];


            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }


            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}
