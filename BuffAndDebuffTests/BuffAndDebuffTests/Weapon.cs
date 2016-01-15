using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests
{
    public class Weapon
    {
        public string Name { get; private set; }
        public WeaponType WeaponType { get; private set; }

        int strengthRequirement;
        int attackValue;

        public int AttackValue
        {
            get { return attackValue; }
            private set { attackValue = value; }
        }
        public int StrengthRequirement
        {
            get { return strengthRequirement; }
            private set { strengthRequirement = value; }
        }

        public Weapon(string name, int strengthRequirement, WeaponType type, int attackValue)
        {
            this.Name = name;
            this.strengthRequirement = strengthRequirement;
            this.WeaponType = type;
            this.attackValue = attackValue;
        }

        public override string ToString()
        {
            return "Weapon{Name:" + Name + ",StrengthRequirement:" + strengthRequirement + "WeaponType:" + WeaponType + ",AttackValue:" + attackValue + "}";
        }
    }
    public enum WeaponType
    {
        Pierce, Slash, Blunt
    }


}
