using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Without locking thread-safe implementation of singletone
    /// </summary>
    public sealed class WithoutLockingSingletone
    {
        private static readonly WithoutLockingSingletone _instance = new WithoutLockingSingletone();

        /// <summary>
        /// Static constructor removes BeforeFieldInit on class 
        /// so static fields not initialized before they are used
        /// </summary>
        static WithoutLockingSingletone() { }

        /// <summary>
        /// Empty private constrictor to prevent direct instantiation
        /// </summary>
        private WithoutLockingSingletone() { }

        /// <summary>
        /// Property accessor for instance
        /// </summary>
        public static WithoutLockingSingletone Instance
        {
            get { return _instance; }
        }
    }
}
