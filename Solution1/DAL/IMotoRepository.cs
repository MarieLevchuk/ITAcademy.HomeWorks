using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public interface IMotoRepository
    {
            Moto GetMotoByID(int id);
            Moto GetMoto(string model);
            void CreateMoto(Moto moto) { }
            void UpdateMoto(Moto motoOld, Moto motoNew) { }
            void DeleteMoto(int id) { }        
    }
}
