using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTest.TransportDB
{
    [TestFixture]
    class HelicopterTransportTest
    {
        /// <summary>
        /// Тест свойства FuelConsumption класса HelicopterTransport
        /// </summary>
        /// <param name="fuel"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании минимально допустимого значения - '0'.")]
        [TestCase(200, TestName = "Тестирование  при присваивании максимально допустимого значения - '200'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 200' - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 200' - 'MinValue'.")]
        public void FuelConsumptionTest(double fuel)
        {
            var helicopterTransport = new HelicopterTransport() { FuelConsumption = fuel };
        }

        /// <summary>
        /// Тест свойства Speed класса HelicopterTransport
        /// </summary>
        /// <param name="speed"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании минимально допустимого значения - '0'.")]
        [TestCase(400, TestName = "Тестирование  при присваивании максимально допустимого значения - '400'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 400' - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 400' - 'MinValue'.")]
        public void SpeedTest(double speed)
        {
            var helicopterTransport = new HelicopterTransport() { Speed = speed };
        }

        /// <summary>
        /// Тест свойства CurrentVolume класса HelicopterTransport
        /// </summary>
        /// <param name="volume"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании минимально допустимого значения - '0'.")]
        [TestCase(10000, TestName = "Тестирование  при присваивании максимально допустимого значения - '10000'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 10000' - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 10000' - 'MinValue'.")]
        public void CurrentVolumeTest(double volume)
        {
            var helicopterTransport = new HelicopterTransport() { CurrentVolume = volume };
        }

        /// <summary>
        /// Тест свойства FuelDensity класса HelicopterTransport
        /// </summary>
        /// <param name="fuelDensity"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании минимально допустимого значения - '0'.")]
        [TestCase(10, TestName = "Тестирование  при присваивании максимально допустимого значения - '10'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 10' - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 10' - 'MinValue'.")]
        public void FuelDensityTest(double fuelDensity)
        {
            var helicopterTransport = new HelicopterTransport() { FuelDensity = fuelDensity};
        }
    }
}
