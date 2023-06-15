using Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NivelStocareDate
{
    public interface IStocareData
    {
        void AddPlayer(PlayerEntity player);

        List<PlayerEntity> GetPlayers();
        PlayerEntity GetPlayer(string nume, string prenume);


    }
}
