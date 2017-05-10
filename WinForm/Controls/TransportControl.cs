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
    public partial class TransportControl : UserControl
    {
        public TransportControl()
        {
            InitializeComponent();
            carTransportControl.Visible = false;
            helicopterTransportControl.Visible = false;
        }
        [DefaultValue(null)]
        public ITransport Transport
        {
            get
            {
                if (comboBoxTransportType.SelectedIndex == 0)
                {
                    return carTransportControl.CarTransport;
                }

                if (comboBoxTransportType.SelectedIndex == 1)
                {
                    return helicopterTransportControl.HelicopterTransport;
                }

                return null;
            }
            set
            {
                if (value is CarTransport)
                {
                    carTransportControl.CarTransport = (CarTransport)value;
                    comboBoxTransportType.SelectedIndex = 0;
                    carTransportControl.Visible = true;
                    helicopterTransportControl.Visible = false;
                }

                if (value is HelicopterTransport)
                {
                    helicopterTransportControl.HelicopterTransport = (HelicopterTransport)value;
                    comboBoxTransportType.SelectedIndex = 1;
                    helicopterTransportControl.Visible = true;
                    carTransportControl.Visible = false;
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
                    carTransportControl.ReadOnly = true;
                    helicopterTransportControl.ReadOnly = true;
                    comboBoxTransportType.Enabled = false;
                }
                else
                {
                    carTransportControl.ReadOnly = false;
                    helicopterTransportControl.ReadOnly = false;
                    comboBoxTransportType.Enabled = true;
                }
            }
        }

        private void comboBoxTransportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTransportType.SelectedIndex == 0)
            {
                carTransportControl.Visible = true;
                helicopterTransportControl.Visible = false;
            }
            if (comboBoxTransportType.SelectedIndex == 1)
            {
                helicopterTransportControl.Visible = true;
                carTransportControl.Visible = false;
            }
        }
    }
}
