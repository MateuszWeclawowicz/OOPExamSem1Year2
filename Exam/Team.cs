using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Team
    {
        #region Properties

        public string Name { get; set; }
        public List<Player> Players { get; set; }

        #endregion Properties
        public override string ToString()
        {
            return String.Format($"{Name}");
        }
    }
}
