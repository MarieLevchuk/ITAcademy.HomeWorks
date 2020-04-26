using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Linq;


namespace CollectionRepository
{
    public class MotoRepository : IMotoRepository
    {
        public static List<Moto> _motorcycles = new List<Moto>()
        {
            new Moto {Model="BMW", Name="Urban2000", Year= 2009, Odometer=3000, Price = 2000, Id=1 },
            new Moto {Model="Honda", Name="Racer", Year= 2011, Odometer=6000, Price = 1500, Id=2},
            new Moto {Model="Yamaha", Name="GSAdventure", Year= 2020, Odometer=500, Price = 8000, Id=3}
        };
        //public static List<Moto> Motos = _motorcycles;

        public Moto GetMotoByID(int id)
        {
            Moto moto = _motorcycles.FirstOrDefault(moto => moto.Id.Equals(id));            
            return moto;
        }

        public Moto GetMoto(string model)
        {
            Moto moto = _motorcycles.FirstOrDefault(moto => moto.Model.Equals(model));
            return moto;
        }
        public void CreateMoto(Moto moto)
        {
            if (moto == null)
            {
                throw new Exception("this moto doesn't exists");
            }
            else
                _motorcycles.Add(moto);
        }
        public void UpdateMoto(Moto motoOld, uint odometer, uint price)
        {
            motoOld.Odometer = odometer;
            motoOld.Price = price;
        }
        public void DeleteMoto(int id)
        {
            Moto moto = GetMotoByID(id);
            _motorcycles.Remove(moto);
        }
    }
}
