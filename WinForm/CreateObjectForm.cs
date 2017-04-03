using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Model;

namespace TransportBD
{
    public partial class CreateObjectForm : Form
    {
        private readonly MessageService _messageService = new MessageService();

        public CreateObjectForm()
        {
            InitializeComponent();
            ItemsEnable(false);
        }

        /// <summary>
        /// Get/Set Транспорта
        /// </summary>
        public ITransport Transport
        {
            get
            {
                if (radioButtonCar.Checked)
                {
                    return new CarTransport
                    {
                        Mark = textBoxMark.Text,
                        Wear = ConvertToDouble(textBoxWear.Text,labelWear.Text),
                        FuelConsumption = ConvertToDouble(textBoxFuelConsumption.Text,labelFuelConsumption.Text),
                        Speed = ConvertToDouble(textBoxSpeed.Text,labelSpeed.Text),
                        CurrentVolume = ConvertToDouble(textBoxCurrentVolume.Text,labelCurrentVolume.Text),
                        TypeFuel = (TypeFuel) Enum.Parse(typeof(TypeFuel),comboBoxTypeFuel.Text)
                    };
                }
                return new HelicopterTransport
                {
                    Mark = textBoxMark.Text,
                    Wear = ConvertToDouble(textBoxWear.Text,labelWear.Text),
                    FuelConsumption = ConvertToDouble(textBoxFuelConsumption.Text,labelFuelConsumption.Text),
                    Speed = ConvertToDouble(textBoxSpeed.Text,labelSpeed.Text),
                    CurrentVolume = ConvertToDouble(textBoxCurrentVolume.Text,labelCurrentVolume.Text),
                    TypeFuel = (TypeFuel) Enum.Parse(typeof(TypeFuel),comboBoxTypeFuel.Text),
                    FuelDensity = ConvertToDouble(textBoxFuelDensity.Text,labelFuelDensity.Text)
                };
            }
            set
            {
                if (value is CarTransport)
                {
                    textBoxMark.Text = Convert.ToString(value.Mark);
                    textBoxCurrentVolume.Text = Convert.ToString(value.CurrentVolume);
                    textBoxFuelConsumption.Text = Convert.ToString(value.FuelConsumption);
                    textBoxWear.Text = Convert.ToString(value.Wear);
                    textBoxSpeed.Text = Convert.ToString(value.Speed);
                    comboBoxTypeFuel.Text = Convert.ToString(value.TypeFuel);
                    textBoxSpeed.Text = Convert.ToString(value.Speed);
                    radioButtonCar.Checked = true;
                }
                else
                {
                    var transport = (HelicopterTransport)value;
                    textBoxMark.Text = Convert.ToString(transport.Mark);
                    textBoxCurrentVolume.Text = Convert.ToString(transport.CurrentVolume);
                    textBoxFuelConsumption.Text = Convert.ToString(transport.FuelConsumption);
                    textBoxWear.Text = Convert.ToString(transport.Wear);
                    textBoxSpeed.Text = Convert.ToString(transport.Speed);
                    textBoxFuelDensity.Text = Convert.ToString(transport.FuelDensity);
                    comboBoxTypeFuel.Text = Convert.ToString(transport.TypeFuel);
                    radioButtonHelicopter.Checked = true;
                }
            }
        }

        /// <summary>
        /// Выбор Транспорта (Машина)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            ItemsEnable(true);
            labelFuelDensity.Visible = false;
            textBoxFuelDensity.Visible = false;    
        }

        /// <summary>
        /// Выбор Транспорта (Вертолет)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHelicopter_CheckedChanged(object sender, EventArgs e)
        {
            ItemsEnable(true);
        }

        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cofAddButton_Click(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked || radioButtonHelicopter.Checked)
            {

                try
                {
                    var transport = Transport;
                }
                catch (ArgumentException exception)
                {
                    _messageService.ShowExclamation(exception.Message);
                    return;
                }
                catch (FormatException formatException)
                {
                    _messageService.ShowExclamation(formatException.Message);
                    return;
                }

            }
            else
            {
                _messageService.ShowExclamation("Выберите тип транспорта.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
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

        /// <summary>
        /// Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cofCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Отображение контролов на форме
        /// </summary>
        /// <param name="itemsEnable"></param>
        private void ItemsEnable(bool itemsEnable)
        {
            textBoxCurrentVolume.Enabled = itemsEnable;
            textBoxFuelConsumption.Enabled = itemsEnable;
            textBoxMark.Enabled = itemsEnable;
            textBoxSpeed.Enabled = itemsEnable;
            textBoxWear.Enabled = itemsEnable;
            comboBoxTypeFuel.Enabled = itemsEnable;
            textBoxFuelDensity.Visible = itemsEnable;
            labelFuelDensity.Visible = itemsEnable;
        }
//------------------------------------------------- Подсказки ----------------------------------------------------------------//
        
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
            if (radioButtonCar.Checked == true)
            {
                errorProvider.SetError(textBoxFuelConsumption,
                    string.IsNullOrEmpty(textBoxFuelConsumption.Text)
                        ? "Значение лежит в диапозоне от 1 до 40 л/км."
                        : null);
            }
            else
            {
                errorProvider.SetError(textBoxFuelConsumption,
                    string.IsNullOrEmpty(textBoxFuelConsumption.Text)
                        ? "Значение лежит в диапозоне от 1 до 200 л/ч."
                        : null);
            }
        }

        private void textBoxSpeed_MouseLeave(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked)
            {
                errorProvider.SetError(textBoxSpeed,
                    string.IsNullOrEmpty(textBoxSpeed.Text) ? "Значение лежит в диапозоне от 1 до 300 км/ч." : null);
            }
            else
            {
                errorProvider.SetError(textBoxSpeed,
                    string.IsNullOrEmpty(textBoxSpeed.Text) ? "Значение лежит в диапозоне от 1 до 400 км/ч." : null);
            }
        }

        private void textBoxCurrentVolume_MouseLeave(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked)
            {
                errorProvider.SetError(textBoxCurrentVolume,
                    string.IsNullOrEmpty(textBoxCurrentVolume.Text)
                        ? "Значение лежит в диапозоне от 1 до 1000 л."
                        : null);
            }
            else
            {
                errorProvider.SetError(textBoxCurrentVolume,
                    string.IsNullOrEmpty(textBoxCurrentVolume.Text)
                        ? "Значение лежит в диапозоне от 1 до 10000 л."
                        : null);
            }
        }

        private void textBoxFuelDensity_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxFuelDensity,
                string.IsNullOrEmpty(textBoxFuelDensity.Text) ? "Значение лежит в диапозоне от 0 до 10" : null);
        }

        private void comboBoxTypeFuel_MouseLeave(object sender, EventArgs e)
        {
            errorProvider.SetError(comboBoxTypeFuel,
                comboBoxTypeFuel.SelectedIndex == -1 ? "Выберите тип топлива." : null);
        }
//------------------------------------------------- Подсказки ----------------------------------------------------------------//
    }
}
