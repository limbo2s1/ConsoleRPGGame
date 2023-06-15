using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Enemy : Character
    {
        public Enemy(string className, int health, int attackDamage, int defense, int superAttackDamage)
            : base(className, health, attackDamage, defense, superAttackDamage)
        {
        }

        public override string PassiveAbility => "";
       
        public override void UsePassiveAbility()
        {
        }
        public override void UseSuperAttack(Character target)
        {
        }
        public override void Attack(Character target)
        {
               
        }
    }
}
