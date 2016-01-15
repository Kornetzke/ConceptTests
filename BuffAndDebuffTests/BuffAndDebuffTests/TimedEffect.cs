using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests
{
    public class TimedEffect : Effect
    {

        public int Duration { get; private set; }

        public TimedEffect(int duration, ModifierStat stat, ModifierType type, double value) : base(stat, type, value)
        {
            Duration = duration;
        }

        public override void Update(int deltaTime)
        {
            Duration -= deltaTime;

            if (Duration <= 0)
                IsActive = false;
        }

    }
}
