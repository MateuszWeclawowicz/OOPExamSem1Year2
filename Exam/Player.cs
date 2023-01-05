using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Player
    {
        private const int WIN = 3, DRAW = 1, LOSS = 0;
        private int _points;
        #region Properties

        public string Name { get; set; }
        public string ResultRecord { get; set; }
        public int Points 
        { 
            get
            {
                _points = 0;
                for (int i = 0; i < ResultRecord.Length; i++)
                {
                    if (ResultRecord[i] == 'W')
                    {
                        _points += WIN;
                    }
                    else if(ResultRecord[i] == 'D')
                    {
                        _points += DRAW;
                    }
                    else
                    {
                        _points += LOSS;
                    }
                }
                return _points;
            }
        }

        #endregion Properties

        public override string ToString()
        {
            return String.Format($"{Name} - {ResultRecord} - {Points}");
        }
    }
}
