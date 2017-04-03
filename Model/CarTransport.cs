using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Машина
    /// </summary>
    [Serializable]
    public class CarTransport : ITransport 
    {
        /// <summary>
        /// Марка
        /// </summary>
        private string _mark;
        /// <summary>
        /// Процент износа
        /// </summary>
        private double _wear;
        /// <summary>
        /// Расход топлива
        /// </summary>
        private double _fuelConsumption;
        /// <summary>
        /// Скорость
        /// </summary>
        private double _speed;
        /// <summary>
        /// Объем топливного бака
        /// </summary>
        private double _currentVolume;
        /// <summary>
        /// Тип топлива
        /// </summary>
        private TypeFuel _typeFuel;
        /// <summary>
        /// Необходимое количество топлива
        /// </summary>
        private double _fuelValue;
        /// <summary>
        /// Затрачиваемое колиество топлива
        /// </summary>
        public double FuelValue
        {
            get { return _fuelValue; }
            set { _fuelValue = value; }
        }

        /// <summary>
        /// Конструктор класса CarTransport
        /// </summary>
        /// <param name="mark"> Марка </param>
        /// <param name="typefuel"> Тип топлива </param>
        /// <param name="wear"> Процент износа </param>
        /// <param name="fuelconsumption"> Расход топлива </param>
        /// <param name="speed"> Скорость </param>
        /// <param name="currentvolume"> Объем топливного бака </param>
        public CarTransport(string mark, TypeFuel typefuel, double wear, double fuelconsumption, double speed, double currentvolume)
        {
            Mark = mark;
            TypeFuel = typefuel;
            Wear = wear;
            FuelConsumption = fuelconsumption;
            Speed = speed;
            CurrentVolume = currentvolume;
        }

        /// <summary>
        /// Конструктор класса CarTransport
        /// </summary>
        public CarTransport()
        {
            
        }

        /// <summary>
        /// Марка
        /// </summary>
        public string Mark
        {
            get { return _mark; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(
                        "Неверно указано название транспортного средства, поле не может быть пустым.");
                }
                else
                {
                    value = value.Trim();
                    foreach (var i in value)
                    {
                        if (!Char.IsLetter(i))
                        {
                            throw new ArgumentException (
                                "Неверно указана название транспортного средства, значение должно содержать только буквы.");
                        }
                    }
                    _mark = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                }
            }
        }

        /// <summary>
        /// Износ
        /// </summary>
        public double Wear
        {
            get { return _wear; }
            set
            {
                if ((value >= 0) && (value <= 100))
                {
                    _wear = value;
                }
                else
                {
                    throw new FormatException(
                        "Не верно указано значение износа транспорта. Значение лежит в диапозоне от 0 до 100 %.");
                }
            }
        }

        /// <summary>
        /// Расход топлива
        /// </summary>
        public double FuelConsumption
        {
            get { return _fuelConsumption; }
            set
            {
                if ((value >= 0) && (value <= 40))
                {
                    _fuelConsumption = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Не верно указано значение расхода топлива транспорта. Значение лежит в диапозоне от 1 до 40 л/км.");
                }
            }
        }

        /// <summary>
        /// Скорость
        /// </summary>
        public double Speed
        {
            get { return _speed; }
            set
            {
                if ((value >= 0) && (value <= 300))
                {
                    _speed = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Не верно указано значение скорости транспорта. Значение лежит в диапозоне от 1 до 300 км/ч.");
                }
            }
        }

        /// <summary>
        /// Объем топливного бака
        /// </summary>
        public double CurrentVolume
        {
            get { return _currentVolume; }
            set
            {
                if ((value >= 0) && (value <= 1000))
                {
                    _currentVolume = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Не верно указано значение объема топливного бака транспорта. Значение лежит в диапозоне от 1 до 1000 л.");
                }
            }
        }

        /// <summary>
        /// Тип топлива
        /// </summary>
        public TypeFuel TypeFuel
        {
            get { return _typeFuel; }
            set
            {

                if (((int)value >= 1) && ((int)value <= 3))
                {
                    _typeFuel = (TypeFuel)value;
                }
                else
                {
                    throw new ArgumentException(
                            "Не верно указан типа топлива транспорта. Допустимые занчения: Бензин, Дизель, Керосин.");
                }
            }
        }

        /// <summary>
        /// Метод определяет,сможет транспортное средство проехать заданный путь, в зависимости от его характеристик
        /// </summary>
        /// <returns> Метод возвращает true/false. </returns>
        public void IsCanBeOvercomeDistance(double distance)
        {
            //Коэффициент коррекции расхода топлива на 1 км
            const double k = 0.01;
            var coef = (_typeFuel == TypeFuel.Бензин) ? 0.05 : (_typeFuel == TypeFuel.Газ) ? 0.1 : 0.07;
            _fuelValue = k * _fuelConsumption * distance * (1 + k * _wear * (_speed * coef));
            _wear = _wear + distance * 0.002 + _speed * 0.06;

            if ((_fuelValue <= _currentVolume) && (_wear < 100))
            {
                FuelValue = _fuelValue;
                Wear = _wear;
            }
            else
            {
                FuelValue = 0;
            }
        }
    }
}
