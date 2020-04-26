using System;
using Models;
using CollectionRepository;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MotoRepository motoRepository = new MotoRepository();


            PrintInfo(motoRepository.GetMotoByID(2));
            PrintInfo(motoRepository.GetMoto("BMW"));

            Moto motoToCreate = new Moto()
            {
                Model = "Yamamaha",
                Name = "GSAdventure600000",
                Year = 2040,
                Odometer = 100,
                Price = 333000,
                Id = 4
            };
            motoRepository.CreateMoto(motoToCreate);
            PrintInfo(motoToCreate);            
            
            motoRepository.UpdateMoto(motoRepository.GetMotoByID(1), 444444, 100);
            PrintInfo(motoRepository.GetMotoByID(1));

            motoRepository.DeleteMoto(2);

        }
        public static void PrintInfo(Moto moto)
        {
            Console.WriteLine($"{moto.Model} - {moto.Name} - {moto.Odometer} - ${moto.Price}\n");
        }
    }
}
