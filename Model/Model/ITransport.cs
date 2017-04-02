using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITransport 
    {
        /// <summary>
        /// Акцессор получения марки транспортного средства
        /// </summary>
        /// <returns> Наименование марки транспорного средства </returns>
        string Mark { get; set; }

        /// <summary>
        /// Акcессор получения типа топлива транспортного средства
        /// </summary>
        /// <returns> Данные о типе топлива транспортного средства </returns>
        TypeFuel TypeFuel { get; set; }
        
        /// <summary>
        /// Акцессор получения износа транспортного средства
        /// </summary>
        /// <returns> Значение износа транспортного средства. Измерение в процентах </returns>
        double Wear { get; set; }

        /// <summary>
        /// Акцессор получения расхода топлива транспортным средством на один киллометр
        /// </summary>
        /// <returns> Значение расхода топлива траспортным средством на 100км. Измерение в л/км или л/ч </returns>
        double FuelConsumption { get; set; }
  
        /// <summary>
        /// Акцессор получения значения скорости траспортного средства
        /// </summary>
        /// <returns> Значение скорости транспортного средства. Измерение в км/ч </returns>
        double Speed { get; set; }

        /// <summary>
        /// Акцессор получения объема бака транспортного средства
        /// </summary>
        /// <returns> Значение объема бака транспортного средства. Измерение в л </returns>
        double CurrentVolume { get; set; }

        /// <summary>
        /// Акцессор получения значения количества топлива необходимого на проезд некоторого пути
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
