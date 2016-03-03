using BuffAndDebuffTests.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests.Effects
{
    public abstract class TimedEffect : BaseEffect
    {

        public int Duration { get; private set; }

        public TimedEffect(int duration, double modifierValue) : base(modifierValue)
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
