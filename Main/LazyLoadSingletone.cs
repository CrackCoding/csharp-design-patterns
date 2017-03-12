using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Lazy load implementation of singletone
    /// </summary>
    public sealed class LazyLoadSingletone
    {
        private static readonly Lazy<LazyLoadSingletone> lazy =
            new Lazy<LazyLoadSingletone>(() => new LazyLoadSingletone());

        /// <summary>
        /// Empty private constrictor to prevent direct instantiation
        /// </summary>
        private LazyLoadSingletone() { }

        /// <summary>
        /// Property accessor for instance
        /// </summary>
        public static LazyLoadSingletone Instance => lazy.Value;
    }
}
