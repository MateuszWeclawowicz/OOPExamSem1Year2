using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Team
    {
        private int _teamPoints;
        #region Properties

        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public int TeamPoints 
        { 
            get 
            {
                foreach (Player player in Players)
                {
                    _teamPoints += player.Points;
                }
                return _teamPoints;
            } 
            
        }

        
        #endregion Properties
        public override string ToString()
        {
            return String.Format($"{Name} - {TeamPoints}");
        }
    }
}
