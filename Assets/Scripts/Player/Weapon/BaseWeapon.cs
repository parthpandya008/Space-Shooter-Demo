using System;


namespace Factory
{
    public abstract class BaseWeapon : IFactory
    {
        public abstract string Name { get; }
        public abstract WeaponType Type { get; }

        public Enum GetEnmuType()
        {
            return Type;
        }

        //Instantiate the weapon from the factory
        public abstract void Instantiate(PlayerController controller);
    }
}