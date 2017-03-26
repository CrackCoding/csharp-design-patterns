using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Double check thread-safe implementation of singletone
    /// </summary>
    public sealed class DoubleCheckSingleton
    {
        /// <summary>
        /// Instance of class
        /// </summary>
        private static DoubleCheckSingleton _instance;

        /// <summary>
        /// Lock object
        /// </summary>
        private static readonly object _lock = new object();

        /// <summary>
        /// Empty private constrictor to prevent direct instantiation
        /// </summary>
        private DoubleCheckSingleton() { }

        /// <summary>
        /// Property accessor for instance
        /// </summary>
        public static DoubleCheckSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        return _instance ?? (_instance = new DoubleCheckSingleton());
                    }
                }

                return _instance;
            }
        }
    }
}
