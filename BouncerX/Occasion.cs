using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncerX
{
    class Occasion
    {
        const int INITIALCOUNT = 0;
        public int AttendanceCount { get; private set; } = INITIALCOUNT;

        public void Enter()
        {
            AttendanceCount++;
        }

        public void Leave()
        {
            if (AttendanceCount > INITIALCOUNT)
                AttendanceCount--;
        }
    }
}
