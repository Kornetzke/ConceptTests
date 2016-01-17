using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests
{
    public class EffectsManager
    {

        private Dictionary<ModifierStat, List<Effect>> EffectsListDictionary;

        public EffectsManager()
        {
            var enumArray = Enum.GetValues(typeof(ModifierStat));

            EffectsListDictionary = new Dictionary<ModifierStat, List<Effect>>(enumArray.Length);
            foreach (ModifierStat value in enumArray)
            {
                EffectsListDictionary.Add(value, new List<Effect>());
            }
        }

        public void AddEffect(Effect effect)
        {
            EffectsListDictionary[effect.ModifierStat].Add(effect);
        }

        public void RemoveEffect(Effect effect)
        {
            EffectsListDictionary[effect.ModifierStat].Remove(effect);
        }


        public double GetMidifiedValueForType(ModifierStat stat, double value)
        {

            List<Effect> effectList = EffectsListDictionary[stat];

            // sorts that List so that ModifierType.Add will come before ModifierType.Multiply in the list.
            // This will make it so that addition modifications will happen before multiplier modifications.
            effectList.Sort();

            foreach (Effect effect in effectList)
            {
                if (effect.IsActive)
                {
                    if (effect.ModifierType == ModifierType.Add)
                    {
                        value += effect.ModifierValue;
                    }
                    else if (effect.ModifierType == ModifierType.Mulitply)
                    {
                        value *= effect.ModifierValue;
                    }
                }
            }
            return value;
        }

        

        internal void Update(int deltaTime)
        {
            List<Effect> deleteList = new List<Effect>();
            foreach (List<Effect> effectList in EffectsListDictionary.Values)
            {
                foreach (Effect effect in effectList)
                {
                    effect.Update(deltaTime);
                    if (effect.IsActive == false)
                        deleteList.Add(effect);
                }
                
            }

            foreach(Effect effect in deleteList)
            {
                RemoveEffect(effect);
            }

        }
    }
}