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
        CharacterBase Owner { get; set; }

        public double ModifierValue { get; private set; }
        public bool IsActive { get; protected set; }

        public BaseEffect(double value, CharacterBase owner)
        {
            this.ModifierValue = value;
            this.Owner = owner;
            IsActive = true;
        }


        public abstract void Update(int deltaTime);
        

        public abstract void RemoveEffect(CharacterBase player);

        public abstract void ApplayEffect(CharacterBase player);
    }

}