using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Lazy load implementation of singletone
    /// </summary>
    public sealed class LazyLoadSingleton
    {
        private static readonly Lazy<LazyLoadSingleton> lazy =
            new Lazy<LazyLoadSingleton>(() => new LazyLoadSingleton());

        /// <summary>
        /// Empty private constrictor to prevent direct instantiation
        /// </summary>
        private LazyLoadSingleton() { }

        /// <summary>
        /// Property accessor for instance
        /// </summary>
        public static LazyLoadSingleton Instance => lazy.Value;
    }
}
