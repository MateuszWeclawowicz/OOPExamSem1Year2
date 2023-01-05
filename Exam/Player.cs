using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Player
    {
        #region Properties

        public string Name { get; set; }
        public string ResultRecord { get; set; }

        #endregion Properties
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
