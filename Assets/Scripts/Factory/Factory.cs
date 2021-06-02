using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Factory
{
    public class Factory<T> where T : class, IFactory

    {
        private Dictionary<Enum, Type> objectsByType;
        //private T baseClass;
        //private Enum enumType;

        public Factory()
        {
            //baseClass = bClass;
            //enumType = eType;

            var objectType = Assembly.GetAssembly(typeof(T)).GetTypes().
                Where
                (
                    mytype => mytype.IsClass && !mytype.IsAbstract && mytype.IsSubclassOf(typeof(T))
                );
            objectsByType = new Dictionary<Enum, Type>();
            foreach (var type in objectType)
            {
                var temp = Activator.CreateInstance(type) as T;
                objectsByType.Add(temp.GetEnmuType(), type);
            }
        }

        public T GetObject(Enum objectType)
        {
            if (objectsByType.ContainsKey(objectType))
            {
                Type type = objectsByType[objectType];
                T weapon = (T)Activator.CreateInstance(type);
                return weapon;
            }
            return default(T);
        }

        internal IEnumerable<Enum> GetObjectNames()
        {
            return objectsByType.Keys;
        }
    }
}