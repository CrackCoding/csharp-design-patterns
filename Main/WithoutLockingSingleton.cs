using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Without locking thread-safe implementation of singletone
    /// </summary>
    public sealed class WithoutLockingSingleton
    {
        private static readonly WithoutLockingSingleton _instance = new WithoutLockingSingleton();

        /// <summary>
        /// Static constructor removes BeforeFieldInit on class 
        /// so static fields not initialized before they are used
        /// </summary>
        static WithoutLockingSingleton() { }

        /// <summary>
        /// Empty private constrictor to prevent direct instantiation
        /// </summary>
        private WithoutLockingSingleton() { }

        /// <summary>
        /// Property accessor for instance
        /// </summary>
        public static WithoutLockingSingleton Instance
        {
            get { return _instance; }
        }
    }
}
