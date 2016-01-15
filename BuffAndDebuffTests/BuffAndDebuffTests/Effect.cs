using System;

namespace BuffAndDebuffTests
{
    public class Effect : IComparable<Effect>
    {
        public ModifierStat ModifierStat { get; private set; }
        public ModifierType ModifierType { get; private set; }

        public double ModifierValue { get; private set; }
        public bool IsActive { get; protected set; }

        public Effect(ModifierStat stat, ModifierType type, double value)
        {
            this.ModifierStat = stat;
            this.ModifierType = type;
            this.ModifierValue = value;
            IsActive = true;
        }

        public int CompareTo(Effect other)
        {

            int value = 0;

            if (this.ModifierType == other.ModifierType)
            {
                value = 0;
            }
            else if (this.ModifierType == ModifierType.Add && other.ModifierType == ModifierType.Mulitply)
            {
                value = -1;
            }
            else if(this.ModifierType == ModifierType.Mulitply && other.ModifierType == ModifierType.Add)
            {
                value = 1;
            }


            return value;
        }

        public virtual void Update(int deltaTime)
        {
            
        }
    }

    public enum ModifierStat
    {
        Health = 0, Mana, Strength, Intellegence, Agility,Luck, AttackValue
    }
    public enum ModifierType
    {
        Add = 0, Mulitply
    }
}