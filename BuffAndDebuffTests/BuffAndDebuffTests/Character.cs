using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests
{
    public class Character
    {
        string name;
        float health;
        float mana;

        int strength;
        int intellegence;
        int agility;



        public Weapon weapon { get; set; }

        public EffectsManager effectsManager { get; set; }

        public int PhysicalDamage
        {
            get
            {
                return (weapon != null ? weapon.AttackValue : 0) + strength;
            }
        }

        public double Health
        {
            get
            {
                return effectsManager.GetMidifiedValueForType(ModifierStat.Health, health);
            }
        }

        public Character(string name, int health, int mana)
        {
            this.name = name;
            this.health = health;
            this.mana = mana;
            this.strength = 1;
            this.agility = 1;
            this.intellegence = 1;

            this.effectsManager = new EffectsManager();
        }

        public bool EquipWeapon(Weapon weapon)
        {
            if (weapon == null)
                throw new ArgumentNullException("weapon");

            bool equipted = false;
            if (weapon.StrengthRequirement <= strength)
            {
                this.weapon = weapon;
                equipted = true;
            }

            return equipted;
        }


        public void Update(int deltaTime)
        {
            effectsManager.Update(deltaTime);
        }

        public override string ToString()
        {
            return "Character{Name:" + name + ",Health:" + health + ",Mana:" + mana + ",Strength:" + strength + ",Agility:" + agility + ",Intellegence:" + intellegence + ",Weapon:" + weapon + "}";
        }
    }
}
