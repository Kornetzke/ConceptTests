using BuffAndDebuffTests.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests.Effects
{
    public class MaxHealthAdditionEffect : BaseEffect
    {

        public MaxHealthAdditionEffect(double modifierValue) : base(modifierValue)
        {

        }
        

        public override void ApplayEffect(CharacterBase player)
        {
            player.MaxHealth += ModifierValue;
        }


        public override void RemoveEffect(CharacterBase player)
        {
            player.MaxHealth -= ModifierValue;
        }

        public override void Update(int deltaTime)
        {
            
        }
    }
}
