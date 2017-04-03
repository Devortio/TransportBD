using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ITransport 
    {
        /// <summary>
        /// Марка транспортного средства
        /// </summary>
        /// <returns> Наименование марки транспорного средства </returns>
        string Mark { get; set; }

        /// <summary>
        /// Типа топлива транспортного средства
        /// </summary>
        /// <returns> Данные о типе топлива транспортного средства </returns>
        TypeFuel TypeFuel { get; set; }
        
        /// <summary>
        /// Износ транспортного средства
        /// </summary>
        /// <returns> Значение износа транспортного средства. Измерение в процентах </returns>
        double Wear { get; set; }

        /// <summary>
        /// Расхода топлива транспортным средством на один киллометр
        /// </summary>
        /// <returns> Значение расхода топлива траспортным средством на 100км. Измерение в л/км или л/ч </returns>
        double FuelConsumption { get; set; }
  
        /// <summary>
        /// Скорость траспортного средства
        /// </summary>
        /// <returns> Значение скорости транспортного средства. Измерение в км/ч </returns>
        double Speed { get; set; }

        /// <summary>
        /// Объема топливного бака транспортного средства
        /// </summary>
        /// <returns> Значение объема бака транспортного средства. Измерение в л </returns>
        double CurrentVolume { get; set; }

        /// <summary>
        /// Количество топлива необходимого на проезд пути
        /// </summary>
        /// <returns> Значение количества топлива необходимого на проезд некоторого пути </returns>
        double FuelValue { get; }

        /// <summary>
        /// Метод определяет,сможет транспортное средство проехать заданный путь, в зависимости от его характеристик
        /// </summary>
        /// <returns> Метод возвращает true/false </returns>
        void IsCanBeOvercomeDistance(double distance);
    }
}
