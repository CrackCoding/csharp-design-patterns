using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Simple thread-safe implementation of singletone
    /// </summary>
    public sealed class SimpleThreadSafeSingletone
    {
        /// <summary>
        /// Instance of class
        /// </summary>
        private static SimpleThreadSafeSingletone _instance = null;

        /// <summary>
        /// Lock object
        /// </summary>
        private static readonly object _lock = new object();

        /// <summary>
        /// Empty private constrictor to prevent direct instantiation
        /// </summary>
        private SimpleThreadSafeSingletone() { }

        /// <summary>
        /// Property accessor for instance
        /// </summary>
        public static SimpleThreadSafeSingletone Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ?? (_instance = new SimpleThreadSafeSingletone());
                }
            }
        }
    }
}
