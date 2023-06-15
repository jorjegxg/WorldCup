using Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareJucatori_Cache : IStocareData
    {
        private List<PlayerEntity> playerEntities = new List<PlayerEntity>();

        public void AddPlayer(PlayerEntity player)
        {
            playerEntities.Add(player);
            
        }

        public PlayerEntity GetPlayer(string nume, string prenume)
        {

            foreach (PlayerEntity playerEntity in playerEntities)
            {
                if(playerEntity.name == nume && playerEntity.secondName == prenume)
                {
                    return playerEntity;
                }
            }

            return null;
            
        }

        public List<PlayerEntity> GetPlayers()
        {
            return playerEntities;
        }
    }
}
