using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public abstract class BaseEnemy : IFactory
    {
        public abstract string Name { get; }
        public abstract EnemyType Type { get; }



        //Instantiate the Enemy from the factory
        public abstract void Instantiate();

        public Enum GetEnmuType()
        {
            return Type;
        }
    }
}