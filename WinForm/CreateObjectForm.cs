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
            transportControl.ReadOnly = false;
        }

        public ITransport Transport
        {
           get { return transportControl.Transport; }
           set { transportControl.Transport = value; }
        }

        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cofAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var transport = transportControl.Transport;
            }
            catch (Exception exception)
            {
                _messageService.ShowExclamation(exception.Message);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
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
    }
}
