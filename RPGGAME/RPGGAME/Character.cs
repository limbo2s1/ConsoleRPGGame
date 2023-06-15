using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public abstract class Character
    {
        public string ClassName { get; protected set; }
        public int Health { get; set; }
        public int AttackDamage { get; protected set; }
        public int Defense { get; protected set; }
        public int SuperAttackDamage { get; protected set; }
        public abstract string PassiveAbility { get; }


        public Character(string className, int health, int attackDamage, int defense, int superAttackDamage)
        {
            ClassName = className;
            Health = health;
            AttackDamage = attackDamage;
            Defense = defense;
            SuperAttackDamage = superAttackDamage;
        }


        public abstract void UsePassiveAbility();
        public abstract void Attack(Character target);
        public abstract void UseSuperAttack(Character target);
    }
}
