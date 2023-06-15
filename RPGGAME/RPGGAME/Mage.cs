using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Mage : Character
    {
        public Mage() : base("Маг", 100, 20, 10, 40)
        {
        }

        public override string PassiveAbility => "Магический щит";

        public override void UsePassiveAbility()
        {
            // Логика пассивной способности мага
            Console.WriteLine("Пассивная способность мага: Магический щит активирован!");
        }

        public override void Attack(Character target)
        {
            // Логика атаки мага
            Console.WriteLine("Маг атакует врага!");
            target.Health -= AttackDamage - target.Defense;
            Console.WriteLine($"Враг потерял {AttackDamage - target.Defense} единиц здоровья.");
        }

        public override void UseSuperAttack(Character target)
        {
            // Логика супер атаки мага
            Console.WriteLine("Маг выполняет супер атаку!");
            target.Health -= SuperAttackDamage - target.Defense;
            Console.WriteLine($"Враг потерял {SuperAttackDamage - target.Defense} единиц здоровья.");
        }
    }
}
