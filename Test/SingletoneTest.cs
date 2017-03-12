using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Main;
using Xunit;

namespace Test
{
    public class SingletoneTest
    {
        [Fact]
        public void DoubleCheckSingletoneTest()
        {
            var instance1 = DoubleCheckSingleton.Instance;
            var instance2 = DoubleCheckSingleton.Instance;
            var instance3 = DoubleCheckSingleton.Instance;

            Assert.Same(instance1, instance2);
            Assert.Same(instance2, instance3);
            Assert.Same(instance1, instance3);
        }

        [Fact]
        public void LazyLoadSingletoneTest()
        {
            var instance1 = LazyLoadSingletone.Instance;
            var instance2 = LazyLoadSingletone.Instance;
            var instance3 = LazyLoadSingletone.Instance;

            Assert.Same(instance1, instance2);
            Assert.Same(instance2, instance3);
            Assert.Same(instance1, instance3);
        }

        [Fact]
        public void SimpleThreadSafeSingletoneTest()
        {
            var instance1 = SimpleThreadSafeSingletone.Instance;
            var instance2 = SimpleThreadSafeSingletone.Instance;
            var instance3 = SimpleThreadSafeSingletone.Instance;

            Assert.Same(instance1, instance2);
            Assert.Same(instance2, instance3);
            Assert.Same(instance1, instance3);
        }

        [Fact]
        public void WithoutLockingSingletonTest()
        {
            var instance1 = WithoutLockingSingletone.Instance;
            var instance2 = WithoutLockingSingletone.Instance;
            var instance3 = WithoutLockingSingletone.Instance;

            Assert.Same(instance1, instance2);
            Assert.Same(instance2, instance3);
            Assert.Same(instance1, instance3);
        }
    }
}
