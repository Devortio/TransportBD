using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public abstract class TransportBase: ITransport
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
        private TypeFuel _typeFuel;

        /// <summary>
        /// Необходимое количество топлива
        /// </summary>
        private double _fuelValue;

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
                            throw new ArgumentException(
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
                    throw new ArgumentException(
                        "Не верно указано значение износа транспорта. Значение лежит в диапозоне от 0 до 100 %.");
                }
            }
        }

        /// <summary>
        /// Расход топлива
        /// </summary>
        public abstract double FuelConsumption { get; set; }

        /// <summary>
        /// Скорость
        /// </summary>
        public abstract double Speed { get; set; }

        /// <summary>
        /// Объем топливного бака
        /// </summary>
        public abstract double CurrentVolume { get; set; }

        /// <summary>
        /// Типа топлива
        /// </summary>
        public TypeFuel TypeFuel
        {
            get { return _typeFuel; }
            set
            {

                if (((int)value >= 1) && ((int)value <= 3))
                {
                    _typeFuel = value;
                }
                else
                {
                    throw new ArgumentException(
                            "Не верно указан типа топлива транспорта. Допустимые занчения: Бензин, Дизель, Керосин.");
                }
            }
        }

        /// <summary>
        /// Затрачиваемое колиество топлива
        /// </summary>
        public double FuelValue { get; set; }

        /// <summary>
        /// Метод определяет,сможет транспортное средство проехать заданный путь, в зависимости от его характеристик
        /// </summary>
        /// <returns> Метод возвращает true/false. </returns>
        public abstract void IsCanBeOvercomeDistance(double distance);
    }
}
