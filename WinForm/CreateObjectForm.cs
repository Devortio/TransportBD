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
            textBoxCurrentVolume.Enabled = false;
            textBoxFuelConsumption.Enabled = false;
            textBoxMark.Enabled = false;
            textBoxSpeed.Enabled = false;
            textBoxWear.Enabled = false;
            comboBoxTypeFuel.Enabled = false;
            textBoxFuelDensity.Visible = false;
        }

        /// <summary>
        /// Get/Set Транспорта
        /// </summary>
        public ITransport Transport
        {
            get
            {
                if (radioButtonCar.Checked == true)
                {
                    CarTransport car = new CarTransport();
                    car.Mark = textBoxMark.Text;
                    car.Wear = ConvertToDouble(textBoxWear.Text, labelWear.Text);
                    car.FuelConsumption = ConvertToDouble(textBoxFuelConsumption.Text, labelFuelConsumption.Text);
                    car.Speed = ConvertToDouble(textBoxSpeed.Text, labelSpeed.Text);
                    car.CurrentVolume = ConvertToDouble(textBoxCurrentVolume.Text, labelCurrentVolume.Text);
                    car.TypeFuel = (TypeFuel)Enum.Parse(typeof(TypeFuel), comboBoxTypeFuel.Text);
                    return car;

                }

                else
                {
                    HelicopterTransport helicopter = new HelicopterTransport();
                    helicopter.Mark = textBoxMark.Text;
                    helicopter.Wear = ConvertToDouble(textBoxWear.Text, labelWear.Text);
                    helicopter.FuelConsumption = ConvertToDouble(textBoxFuelConsumption.Text, labelFuelConsumption.Text);
                    helicopter.Speed = ConvertToDouble(textBoxSpeed.Text, labelSpeed.Text);
                    helicopter.CurrentVolume = ConvertToDouble(textBoxCurrentVolume.Text, labelCurrentVolume.Text);
                    helicopter.TypeFuel = (TypeFuel)Enum.Parse(typeof(TypeFuel), comboBoxTypeFuel.Text);
                    helicopter.FuelDensity = ConvertToDouble(textBoxFuelDensity.Text, labelFuelDensity.Text);
                    return helicopter;
                }
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
                    HelicopterTransport transport = new HelicopterTransport();
                    transport = (HelicopterTransport)value;
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
            labelFuelDensity.Visible = false;
            textBoxCurrentVolume.Enabled = true;
            textBoxFuelConsumption.Enabled = true;
            textBoxMark.Enabled = true;
            textBoxSpeed.Enabled = true;
            textBoxWear.Enabled = true;
            comboBoxTypeFuel.Enabled = true;
            textBoxFuelDensity.Visible = false;    
        }

        /// <summary>
        /// Выбор Транспорта (Вертолет)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHelicopter_CheckedChanged(object sender, EventArgs e)
        {
            labelFuelDensity.Visible = true;
            textBoxFuelDensity.Visible = true;
            textBoxCurrentVolume.Enabled = true;
            textBoxFuelConsumption.Enabled = true;
            textBoxMark.Enabled = true;
            textBoxSpeed.Enabled = true;
            textBoxWear.Enabled = true;
            comboBoxTypeFuel.Enabled = true;
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
//------------------------------------------------- Подсказки ----------------------------------------------------------------//
        private void CreateObjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        private void textBoxMark_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMark.Text))
            {
                errorProvider.SetError(textBoxMark, "Название транспорта должно содержать буквы.");
            }
            else
            {
                errorProvider.SetError(textBoxMark, null);
            }
        }

        private void textBoxWear_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxWear.Text))
            {
                errorProvider.SetError(textBoxWear, "Значение лежит в диапозоне от 0 до 100 %.");
            }
            else
            {
                errorProvider.SetError(textBoxWear, null);
            }

        }

        private void textBoxFuelConsumption_MouseLeave(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked == true)
            {
                if (string.IsNullOrEmpty(textBoxFuelConsumption.Text))
                {
                    errorProvider.SetError(textBoxFuelConsumption, "Значение лежит в диапозоне от 1 до 40 л/км.");
                }
                else
                {
                    errorProvider.SetError(textBoxFuelConsumption, null);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxFuelConsumption.Text))
                {
                    errorProvider.SetError(textBoxFuelConsumption, "Значение лежит в диапозоне от 1 до 200 л/ч.");
                }
                else
                {
                    errorProvider.SetError(textBoxFuelConsumption, null);
                }
            }
        }

        private void textBoxSpeed_MouseLeave(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked == true)
            {
                if (string.IsNullOrEmpty(textBoxSpeed.Text))
                {
                    errorProvider.SetError(textBoxSpeed, "Значение лежит в диапозоне от 1 до 300 км/ч.");
                }
                else
                {
                    errorProvider.SetError(textBoxSpeed, null);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxSpeed.Text))
                {
                    errorProvider.SetError(textBoxSpeed, "Значение лежит в диапозоне от 1 до 400 км/ч.");
                }
                else
                {
                    errorProvider.SetError(textBoxSpeed, null);
                }
            }
        }

        private void textBoxCurrentVolume_MouseLeave(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked == true)
            {
                if (string.IsNullOrEmpty(textBoxCurrentVolume.Text))
                {
                    errorProvider.SetError(textBoxCurrentVolume, "Значение лежит в диапозоне от 1 до 1000 л.");
                }
                else
                {
                    errorProvider.SetError(textBoxCurrentVolume, null);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxCurrentVolume.Text))
                {
                    errorProvider.SetError(textBoxCurrentVolume, "Значение лежит в диапозоне от 1 до 10000 л.");
                }
                else
                {
                    errorProvider.SetError(textBoxCurrentVolume, null);
                }
            }
        }

        private void textBoxFuelDensity_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFuelDensity.Text))
            {
                errorProvider.SetError(textBoxFuelDensity, "Значение лежит в диапозоне от 0 до 10");
            }
            else
            {
                errorProvider.SetError(textBoxFuelDensity, null);
            }
        }

        private void comboBoxTypeFuel_MouseLeave(object sender, EventArgs e)
        {
            if(comboBoxTypeFuel.SelectedIndex==-1)
            {
                errorProvider.SetError(comboBoxTypeFuel, "Выберите тип топлива.");
            }
            else
            {
                errorProvider.SetError(comboBoxTypeFuel, null);
            }
        }
//------------------------------------------------- Подсказки ----------------------------------------------------------------//
    }
}
