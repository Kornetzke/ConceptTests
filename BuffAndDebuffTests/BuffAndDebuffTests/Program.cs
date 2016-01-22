using BuffAndDebuffTests.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuffAndDebuffTests.Characters;

namespace BuffAndDebuffTests
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");

            Weapon stick = new Weapon("Stick", 1, WeaponType.Blunt, 2);

            CharacterBase player = Player.GetInstance();

            Console.WriteLine(player);

            player.EquipWeapon(stick);

            Console.WriteLine(player);
            Console.WriteLine("Player MaxHealth : " + player.MaxHealth);

            BaseEffect effect = new MaxHealthAdditionEffect(10, player);
            player.EffectsManager.AddEffect(effect);

            Console.WriteLine("Player MaxHealth : " + player.MaxHealth);

            player.EffectsManager.RemoveEffect(effect);


            Console.WriteLine("Player MaxHealth : " + player.MaxHealth);

            
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();

        }
    }
}
