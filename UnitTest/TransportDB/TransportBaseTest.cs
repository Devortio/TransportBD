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
    class TransportBaseTest
    {
        /// <summary>
        /// Тест свойства Mark класса TransportBase
        /// </summary>
        /// <param name="mark"></param>
        [Test]
        [TestCase("Audi", TestName = "Тестирование  при присваивании позитивного значения - 'Audi'.")]
        [TestCase("toyota", TestName = "Тестирование  при присваивании позитивного значения - 'Toyota'.")]
        [TestCase("", ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование  при присваивании негативного значения - 'Пустая строка'.")]
        [TestCase(1234, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании негативного значения - '1234'.")]
        public void MarkTest(string mark)
        {
            var carTransport = new CarTransport() {Mark = mark};
        }

        /// <summary>
        /// Тест свойства Wear класса TransportBase
        /// </summary>
        /// <param name="wear"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование  при присваивании позитивного значения - '0'.")]
        [TestCase(100, TestName = "Тестирование  при присваивании позитивного значения - '100'.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании негативного значения - 'MaxValue'.")]
        [TestCase(double.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании негативного значения - 'MinValue'.")]
        public void WearTest(double wear)
        {
            var carTransport = new CarTransport() { Wear = wear};
        }

        /// <summary>
        /// Тест свойства TypeFuel класса TransportBase
        /// </summary>
        /// <param name="typeFuel"></param>
        [Test]
        [TestCase(TypeFuel.Бензин, TestName = "Тестирование  при присваивании позитивного значения - 'Бензин'.")]
        [TestCase(TypeFuel.Дизель, TestName = "Тестирование  при присваивании позитивного значения - 'Дизель'.")]
        [TestCase("Кислород", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании негативного значения - 'Кислород'.")]
        [TestCase("Пропан", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование  при присваивании негативного значения - 'Пропан'.")]
        public void TypeFuelTest(TypeFuel typeFuel)
        {
            var carTransport = new CarTransport() { TypeFuel = typeFuel};
        }
    }
}
