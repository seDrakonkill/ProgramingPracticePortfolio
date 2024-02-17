using System;
using System.Console;

//a Struct is used to define a type that contains DATA and RELATED functionality, not behavior.
namespace Projects.MiscItems
{
    public struct DamageAmount
    {
        //for this struct, damage taken will be a flat amount between 10-100 and damage reduction will be a flat reduction (EG:  97, 10)
        public DamageAmount(float damageTaken, float damageReduction)
        {
            DamageTaken = damageTaken;
            DamageReduction = damageReduction;
        }

        public float DamageTaken { get; }
        public float DamageReduction { get; }

    }
}