using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Warrior : Character
    {
        public Warrior() : base("Воин", 120, 30, 15, 60)
        {
        }
        public override string PassiveAbility => "Прицельная стрельба";
        public override void UsePassiveAbility()
        {
            // Логика пассивной способности воина
            Console.WriteLine("Пассивная способность воина: Броня усиливается!");
        }

        public override void Attack(Character target)
        {
            // Логика атаки воина
            Console.WriteLine("Воин атакует врага!");
            target.Health -= AttackDamage - target.Defense;
            Console.WriteLine($"Враг потерял {AttackDamage - target.Defense} единиц здоровья.");
        }

        public override void UseSuperAttack(Character target)
        {
            // Логика супер атаки воина
            Console.WriteLine("Воин выполняет супер атаку!");
            target.Health -= SuperAttackDamage - target.Defense;
            Console.WriteLine($"Враг потерял {SuperAttackDamage - target.Defense} единиц здоровья.");
        }
    }
}
