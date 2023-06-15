using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Archer : Character
    {
        public Archer() : base("Лучник", 80, 25, 5, 50)
        {
        }

        public override string PassiveAbility => "Прицельная стрельба";

        public override void UsePassiveAbility()
        {
            // Логика пассивной способности лучника
            Console.WriteLine("Пассивная способность лучника: Уклонение активировано!");
        }

        public override void Attack(Character target)
        {
            // Логика атаки лучника
            Console.WriteLine("Лучник атакует врага!");
            target.Health -= AttackDamage - target.Defense;
            Console.WriteLine($"Враг потерял {AttackDamage - target.Defense} единиц здоровья.");
        }

        public override void UseSuperAttack(Character target)
        {
            // Логика супер атаки лучника
            Console.WriteLine("Лучник выполняет супер атаку!");
            target.Health -= SuperAttackDamage - target.Defense;
            Console.WriteLine($"Враг потерял {SuperAttackDamage - target.Defense} единиц здоровья.");
        }
    }
}
