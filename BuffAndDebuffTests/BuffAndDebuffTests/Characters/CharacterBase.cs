using BuffAndDebuffTests.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests.Characters
{
    public abstract class CharacterBase
    {
        public string Name { get; set; }

        public double MaxHealth { get; set; }
        public double Health { get; set; }

        public double MaxMana { get; set; }
        public double Mana { get; set; }


        public int Strength { get; set; }
        public int Intellegence { get; set; }
        public int Agility { get; set; }

        public Weapon Weapon { get; set; }
        public EffectsManager EffectsManager { get; set; }

        public bool EquipWeapon(Weapon weapon)
        {
            if (weapon == null)
                throw new ArgumentNullException("weapon");

            bool equipted = false;
            if (weapon.StrengthRequirement <= Strength)
            {
                this.Weapon = weapon;
                equipted = true;
            }

            return equipted;
        }

        public abstract void Update(int deltaTime);
    }
}
