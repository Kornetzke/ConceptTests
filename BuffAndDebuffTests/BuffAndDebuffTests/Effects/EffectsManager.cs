using BuffAndDebuffTests.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests.Effects
{
    public class EffectsManager
    {

        private CharacterBase affiliatedCharacter;
        private List<BaseEffect> _effectList;
        
        public List<BaseEffect> EffectList { get { return _effectList; } set { _effectList = value; } }

        public EffectsManager(CharacterBase affiliatedCharacter)
        {
            this.affiliatedCharacter = affiliatedCharacter;
            _effectList = new List<BaseEffect>();
        }

        public void AddEffect(BaseEffect effect)
        {
            effect.ApplayEffect(affiliatedCharacter);
            _effectList.Add(effect);
        }

        public void RemoveEffect(BaseEffect effect)
        {
            effect.RemoveEffect(affiliatedCharacter);
            _effectList.Remove(effect);
        }
        

        public void Update(int deltaTime)
        {
            foreach(BaseEffect effect in _effectList)
            {
                effect.Update(deltaTime);
            }
        }

        public void DeleteInactiveEffects()
        {
            IEnumerable<BaseEffect> inActiveList = _effectList.Where(e => e.IsActive == false);
            foreach(BaseEffect effect in inActiveList)
            {
                RemoveEffect(effect);
            }
        }
    }
}