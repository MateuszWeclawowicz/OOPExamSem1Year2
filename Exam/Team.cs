using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
