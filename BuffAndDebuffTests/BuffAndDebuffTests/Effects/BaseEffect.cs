using BuffAndDebuffTests.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests.Effects
{
    public abstract class BaseEffect : IEffect
    {

        public double ModifierValue { get; private set; }
        public bool IsActive { get; protected set; }

        public BaseEffect(double value)
        {
            this.ModifierValue = value;
            IsActive = true;
        }


        public abstract void Update(int deltaTime);
        

        public abstract void RemoveEffect(CharacterBase character);

        public abstract void ApplayEffect(CharacterBase character);
    }

}