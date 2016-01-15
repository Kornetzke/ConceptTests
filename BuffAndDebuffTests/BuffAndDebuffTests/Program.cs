using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffAndDebuffTests
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");

            Weapon stick = new Weapon("Stick", 1, WeaponType.Blunt, 2);

            Character player = new Character("Bob", 100, 100);

            Console.WriteLine(player);
            Console.WriteLine(stick);

            player.EquipWeapon(stick);

            Console.WriteLine(player);
            Console.WriteLine("Player Health : " + player.Health);

            //player.effectsManager.AddEffect(new Effect(ModifierStat.Health, ModifierType.Add, -50));
            Effect effect = new Effect(ModifierStat.Health, ModifierType.Mulitply, 1.01);
            player.effectsManager.AddEffect(effect);

            Console.WriteLine("Player Health : " + player.Health);

            player.effectsManager.RemoveEffect(effect);


            Console.WriteLine("Player Health : " + player.Health);

            Console.WriteLine("Applying time based Effect");
            effect = new TimedEffect(2, ModifierStat.Health, ModifierType.Add, 50);
            player.effectsManager.AddEffect(effect);

            Console.WriteLine("Player Health : " + player.Health);

            player.Update(1);

            Console.WriteLine("Player Health : " + player.Health);

            player.Update(1);

            Console.WriteLine("Player Health : " + player.Health);

            player.Update(1);
            Console.WriteLine("Player Health : " + player.Health);

            player.Update(1);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();

        }
    }
}
