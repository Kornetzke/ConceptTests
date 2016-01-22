using BuffAndDebuffTests.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests.Characters
{
    public class Player : CharacterBase
    {

        //Singleton Instance of player
        private static Player player = new Player("Player", 100, 100);

        public static Player GetInstance()
        {
            return player;
        }

        
        public int PhysicalDamage
        {
            get
            {
                return (Weapon != null ? Weapon.AttackValue : 0) + Strength;
            }
        }
        
        private Player(string name, int health, int mana)
        {
            Name = name;
            MaxHealth = Health = health;
            MaxMana = Mana = mana;
            Strength = 1;
            Intellegence = 1;
            Agility = 1;

            EffectsManager = new EffectsManager(this);
        }
        

        public override void Update(int deltaTime)
        {
            EffectsManager.Update(deltaTime);
        }

        public override string ToString()
        {
            return "Character{Name:" + Name + ",Health:" + Health + ",Mana:" + Mana + ",Strength:" + Strength + ",Agility:" + Agility + ",Intellegence:" + Intellegence + ",Weapon:" + Weapon + "}";
        }
    }
}
