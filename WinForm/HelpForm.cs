using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TransportBD
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            textBox1.AppendText(
                "\tПанель 'Файл'" + Environment.NewLine +
                "Для открытия файла:\t'Файл -> Открыть'" + Environment.NewLine +
                "Для сохранеия файла:\t'Файл -> Сохранить'" + Environment.NewLine +
                "Для сохранения данных в новом файле:\t'Файл -> Сохранить как...'" + Environment.NewLine +
                "Для выхода из программы:\t'Файл -> Выход'" + Environment.NewLine +
                "\tПанель 'Правка'" + Environment.NewLine +
                "Для добавления новой записи:\t'Правка -> Добавить'" + Environment.NewLine +
                "Для изменения записи:\tВыделить запись, 'Файл -> Сохранить'" + Environment.NewLine +
                "Для удаления записи:\tВыделить запись 'Файл -> Сохранить как...'" + Environment.NewLine); 
        }
    }
}
