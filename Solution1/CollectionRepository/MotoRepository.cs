using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Linq;
using Logger;

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

        public Moto GetMotoByID(int id)
        {
            Logging.Log.Info("Method \"GetMotoByID\" called");

            Moto moto = _motorcycles.FirstOrDefault(moto => moto.Id.Equals(id));            
            return moto;
        }
        public Moto GetMoto(string model)
        {
            Logging.Log.Info("Method \"GetMoto\" called");

            Moto moto = _motorcycles.FirstOrDefault(moto => moto.Model.Equals(model));
            return moto;
        }
        public void CreateMoto(Moto moto)
        {
            Logging.Log.Info("Method \"CreateMoto\" called");

            if (moto == null)
            {
                Logging.Log.Warn("throw exeption in \"CreateMoto\"");

                throw new Exception("this moto doesn't exists");
            }
            else
                _motorcycles.Add(moto);
        }
        public void UpdateMoto(Moto motoOld, uint odometer, uint price)
        {
            Logging.Log.Info("Method \"UpdateMoto\" called");

            motoOld.Odometer = odometer;
            motoOld.Price = price;
        }
        public void DeleteMoto(int id)
        {
            Logging.Log.Info("Method \"DeleteMoto\" called");

            Moto moto = GetMotoByID(id);
            _motorcycles.Remove(moto);
        }
    }
}
