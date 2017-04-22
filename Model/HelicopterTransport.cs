using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Вертолет
    /// </summary>
    [Serializable]
    public class HelicopterTransport : TransportBase,ITransport 
    {
        /// <summary>
        /// Марка
        /// </summary>
        private string _mark;

        /// <summary>
        /// Процент износ
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
        private FuelType _fuelType;

        /// <summary>
        /// Плотность топлива
        /// </summary>
        private double _fuelDensity;

        /// <summary>
        /// Необходимое количество топлива
        /// </summary>
        private double _fuelValue;

        /// <summary>
        /// Конструктор класса HelicopterTransport
        /// </summary>
        /// <param name="mark"> Марка </param>
        /// <param name="typefuel"> Тип топлива </param>
        /// <param name="wear"> Процент износа </param>
        /// <param name="fuelconsumption"> Расход топлива </param>
        /// <param name="speed"> Скорость </param>
        /// <param name="currentvolume"> Объем топливного бака </param>
        /// <param name="fueldensity"> Плотность топлива </param>
        public HelicopterTransport(string mark, FuelType fuelType, double wear, double fuelconsumption, double speed,
            double currentvolume, double fueldensity)
        {
            Mark = mark;
            FuelType = fuelType;
            Wear = wear;
            FuelConsumption = fuelconsumption;
            Speed = speed;
            CurrentVolume = currentvolume;
            FuelDensity = fueldensity;
        }

        /// <summary>
        /// Конструктор класса Helicopter
        /// </summary>
        public HelicopterTransport()
        {

        }

        /// <summary>
        /// Плотность топлива
        /// </summary>
        public double FuelDensity
        {
            get { return _fuelDensity; }
            set
            {
                if ((value >= 0) && (value <= 10))
                {
                    _fuelDensity = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Не верно указано значение плотности топлива. Значение лежит в диапозоне от 0 до 10 ");
                }
            }
        }

        /// <summary>
        /// Расход топлива
        /// </summary>
        public override double FuelConsumption
        {
            get { return _fuelConsumption; }
            set
            {
                if ((value >= 0) && (value <= 200))
                {
                    _fuelConsumption = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Не верно указано значение расхода топлива транспорта. Значение лежит в диапозоне от 1 до 200 л/ч");
                }
            }
        }

        /// <summary>
        /// Скорость
        /// </summary>
        public override double Speed
        {
            get { return _speed; }
            set
            {
                if ((value >= 0) && (value <= 400))
                {
                    _speed = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Не верно указано значение скорости транспорта. Значение лежит в диапозоне от 1 до 400 км/ч");
                }
            }
        }

        /// <summary>
        /// Объем топливного бака
        /// </summary>
        public override double CurrentVolume
        {
            get { return _currentVolume; }
            set
            {
                if ((value >= 0) && (value <= 10000))
                {
                    _currentVolume = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Не верно указано значение объема топливного бака транспорта. Значение лежит в диапозоне от 1 до 10000 л");
                }
            }
        }

        /// <summary>
        /// Метод определяет,сможет транспортное средство проехать заданный путь, в зависимости от его характеристик
        /// </summary>
        /// <returns> Метод возвращает true/false</returns>
        public override void IsCanBeOvercomeDistance(double distance)
        {
            //Коэффициент коррекции расхода топлива на 1 км
            const double k = 0.01;

            var coef = (_fuelType == FuelType.Бензин) ? 0.05 : (_fuelType == FuelType.Газ) ? 0.1 : 0.07;

            _fuelValue = _fuelConsumption*distance +(k*_wear*(_speed*k + _fuelDensity*_fuelConsumption*coef));

            _wear = _wear + distance*0.02;

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
