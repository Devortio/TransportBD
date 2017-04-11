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
    class CarTransportTest
    {
        /// <summary>
        /// Тест свойства FuelConsumption класса CarTransport
        /// </summary>
        /// <param name="fuel"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании минимально допустимого значения - '0'.")]
        [TestCase(40, TestName = "Тестирование  при присваивании максимально допустимого значения  - '40'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 40' - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 40' - 'MinValue'.")]
        public void FuelConsumptionTest(double fuel)
        {
            var carTransport = new CarTransport() {FuelConsumption = fuel};
        }

        /// <summary>
        /// Тест свойства Speed класса CarTransport
        /// </summary>
        /// <param name="speed"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании минимально допустимого значения - '0'.")]
        [TestCase(300, TestName = "Тестирование  при присваивании максимально допустимого значения - '300'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 300' - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 300' - 'MinValue'.")]
        public void SpeedTest(double speed)
        {
            var carTransport = new CarTransport() { Speed = speed};
        }

        /// <summary>
        /// Тест свойства CurrentVolume класса CarTransport
        /// </summary>
        /// <param name="volume"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании минимально допустимого значения - '0'.")]
        [TestCase(1000, TestName = "Тестирование  при присваивании максимально допустимого значения - '1000'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 1000' - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании недопустимого значения " +
                       "лежащего за пределами допустимого диапозона '0 - 1000' - 'MinValue'.")]
        public void CurrentVolumeTest(double volume)
        {
            var carTransport = new CarTransport() { CurrentVolume = volume};
        }
    }
}
