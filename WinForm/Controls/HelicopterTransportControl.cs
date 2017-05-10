using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace TransportBD.Controls
{
    public partial class HelicopterTransportControl : UserControl
    {
        public HelicopterTransportControl()
        {
            InitializeComponent();
        }

        [DefaultValue(null)]
        public HelicopterTransport HelicopterTransport
        {
            get
            {
                return new HelicopterTransport
                {
                    Mark = textBoxMark.Text,
                    Wear = ConvertToDouble(textBoxWear.Text, labelWear.Text),
                    FuelConsumption = ConvertToDouble(textBoxFuelConsumption.Text, labelFuelConsumption.Text),
                    Speed = ConvertToDouble(textBoxSpeed.Text, labelSpeed.Text),
                    CurrentVolume = ConvertToDouble(textBoxCurrentVolume.Text, labelCurrentVolume.Text),
                    FuelType = (FuelType)Enum.Parse(typeof(FuelType), comboBoxFuelType.Text),
                    FuelDensity = ConvertToDouble(textBoxFuelDensity.Text, labelFuelDensity.Text)
                };
            }
            set
            {
                if (value != null)
                {
                    textBoxMark.Text = Convert.ToString(value.Mark);
                    textBoxCurrentVolume.Text = Convert.ToString(value.CurrentVolume);
                    textBoxFuelConsumption.Text = Convert.ToString(value.FuelConsumption);
                    textBoxWear.Text = Convert.ToString(value.Wear);
                    textBoxSpeed.Text = Convert.ToString(value.Speed);
                    textBoxFuelDensity.Text = Convert.ToString(value.FuelDensity);
                    comboBoxFuelType.Text = Convert.ToString(value.FuelType);
                }
            }
        }

        /// <summary>
        /// Метод Изменений
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                if (value)
                {
                    textBoxMark.ReadOnly = true;
                    textBoxWear.ReadOnly = true;
                    textBoxCurrentVolume.ReadOnly = true;
                    textBoxFuelConsumption.ReadOnly = true;
                    textBoxSpeed.ReadOnly = true;
                    textBoxFuelDensity.ReadOnly = true;
                    comboBoxFuelType.Enabled = false;
                }
                else
                {
                    textBoxMark.ReadOnly = false;
                    textBoxWear.ReadOnly = false;
                    textBoxCurrentVolume.ReadOnly = false;
                    textBoxFuelConsumption.ReadOnly = false;
                    textBoxSpeed.ReadOnly = false;
                    textBoxFuelDensity.ReadOnly = false;
                    comboBoxFuelType.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Метод Конвертации
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private double ConvertToDouble(string text, string fileName)
        {
            double view;
            try
            {
                view = Convert.ToDouble(text);
            }
            catch (FormatException)
            {
                throw new FormatException("Поле: '" + fileName + "' содержит только цифры.");
            }
            return view;
        }

        //Подсказки

        private void textBoxMark_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxMark,
                string.IsNullOrEmpty(textBoxMark.Text) ? "Название транспорта должно содержать буквы." : null);
        }

        private void textBoxWear_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxWear,
                string.IsNullOrEmpty(textBoxWear.Text) ? "Значение лежит в диапозоне от 0 до 100 %." : null);
        }

        private void textBoxFuelConsumption_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxFuelConsumption,
                string.IsNullOrEmpty(textBoxFuelConsumption.Text) ? "Значение лежит в диапозоне от 1 до 200 л/ч." : null);
        }

        private void textBoxSpeed_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxSpeed,
                string.IsNullOrEmpty(textBoxSpeed.Text) ? "Значение лежит в диапозоне от 1 до 400 км/ч." : null);
        }

        private void textBoxCurrentVolume_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxCurrentVolume,
                string.IsNullOrEmpty(textBoxCurrentVolume.Text) ? "Значение лежит в диапозоне от 1 до 10000 л." : null);
        }

        private void textBoxFuelDensity_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxFuelDensity,
                string.IsNullOrEmpty(textBoxFuelDensity.Text) ? "Значение лежит в диапозоне от 0 до 10" : null);
        }

        private void comboBoxFuelType_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(comboBoxFuelType,
                comboBoxFuelType.SelectedIndex == -1 ? "Выберите тип топлива." : null);
        }
        //Подсказки
    }
}
