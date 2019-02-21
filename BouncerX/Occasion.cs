using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncerX
{
    class Occasion
    {
        public int AttendanceCount { get; private set; } = 0;

        public void Enter()
        {
            AttendanceCount++;
        }

        public void Leave()
        {
            if (AttendanceCount > 0)
                AttendanceCount--;
        }
    }
}
