using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace TransportBD
{
    public partial class ViewForm : Form
    {
        private string _filePath;
        private List<ITransport> _transportList;
        private readonly MessageService _messageServices = new MessageService();
        private bool _pointFixer;

        public ViewForm()
        {
            InitializeComponent();
            _pointFixer = true;
        }

        private void PointFixer(bool pointFixer)
        {
            if (pointFixer ==false)
            {
                this.Text = "TransportBD*";
            }
            else
            {
                this.Text = "TransportBD";
            }
        }

        /// <summary>
        ///  Открытие файла (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы|*.tdb|Все файлы|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != null)
                {
                    _filePath = ofd.FileName;
                    _transportList = Serialization.Deserialize(_filePath);
                    iTransportBindingSource.DataSource = _transportList;
                }
            }
        }

        /// <summary>
        /// Сохранение (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Save();
        }

        /// <summary>
        /// Изменить (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iTransportBindingSource.Current != null)
            {
                CreateObjectForm cof = new CreateObjectForm();
                int index = iTransportBindingSource.IndexOf(iTransportBindingSource.Current);
                cof.Transport = (ITransport)iTransportBindingSource.Current;
                iTransportBindingSource.RemoveAt(index);
                cof.ShowDialog();
                var transport = cof.Transport;
                iTransportBindingSource.Insert(index, transport);
                PointFixer(_pointFixer = false);
            }
            else
            {
                _messageServices.ShowError("Не выбрана запись. Выберите запись и повторите попытку.");
            }
        }

        /// <summary>
        /// Сохранить как (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Файлы|*.tdb|Все файлы|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _filePath = sfd.FileName;
                    Serialization.Serialize(_filePath, _transportList);
                    _messageServices.ShowMessage("Сохранение прошло успешно.");
                    PointFixer(_pointFixer = true);
                }

        }

        /// <summary>
        /// Добавить (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateObjectForm cof = new CreateObjectForm();
            if (cof.ShowDialog() == DialogResult.OK)
            {
                PointFixer(_pointFixer = false);
                var transport = cof.Transport;
                iTransportBindingSource.Add(transport);
            }
        }

        /// <summary>
        /// Выход (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Новый файл (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((_transportList != null) && (_pointFixer != true))
            {
                Save();
                _filePath = null;
                iTransportBindingSource.DataSource = _transportList = new List<ITransport>();
            }
            else
            {
                _filePath = null;
                iTransportBindingSource.DataSource = _transportList = new List<ITransport>();
            }
        }

        /// <summary>
        /// Удалить (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_filePath != null)
            {
                _transportList.Remove((ITransport)iTransportBindingSource.Current);
                iTransportBindingSource.Remove(iTransportBindingSource.Current);
                PointFixer(_pointFixer = false);
            }
            else
            {
                _messageServices.ShowError("Не выбрана запись. Выберите запись и повторите попытку.");
            }
           
        }

        /// <summary>
        /// О программе (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af=new AboutForm();
            af.ShowDialog();
        }

        /// <summary>
        /// Руководство (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        /// <summary>
        /// Закрытие формы (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (_pointFixer != true)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Сохранить изменения ?", "Предупреждение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation);

                if (dialogResult == DialogResult.Yes)
                {
                    Serialization.Serialize(_filePath, _transportList);
                    _messageServices.ShowMessage("Сохранение прошло успешно.");
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Добавить (Кнопка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateObjectForm cof = new CreateObjectForm();
            if (cof.ShowDialog() == DialogResult.OK)
            {
                PointFixer(_pointFixer = false);
                var transport = cof.Transport;
                iTransportBindingSource.Add(transport);
            }           
        }

        /// <summary>
        /// Изменить (Кнопка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (iTransportBindingSource.Current != null)
            {
                CreateObjectForm cof = new CreateObjectForm();
                int index = iTransportBindingSource.IndexOf(iTransportBindingSource.Current);
                cof.Transport = (ITransport)iTransportBindingSource.Current;
                iTransportBindingSource.RemoveAt(index);
                cof.ShowDialog();
                var transport = cof.Transport;
                iTransportBindingSource.Insert(index, transport);
                PointFixer(_pointFixer = false);
            }
            else
            {
                _messageServices.ShowError("Не выбрана запись. Выберите запись и повторите попытку.");
            }
        }

        /// <summary>
        /// Удалить (Кнопка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (iTransportBindingSource.Current != null)
            {
                _transportList.Remove((ITransport)iTransportBindingSource.Current);
                iTransportBindingSource.Remove(iTransportBindingSource.Current);
                PointFixer(_pointFixer = false);
            }
            else
            {
                _messageServices.ShowError("Не выбрана запись. Выберите запись и повторите попытку.");
            }
        }

        /// <summary>
        /// Поиск (Кнопка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (_transportList!= null)
            {
                if (comboBoxSearch.SelectedIndex != -1)
                {
                    string searchLine = textBoxSearch.Text;
                    switch (comboBoxSearch.SelectedItem.ToString())
                    {
                        case "Марка":
                        {
                            iTransportBindingSource.DataSource = _transportList.FindAll(delegate(ITransport transport)
                            {
                                return transport.Mark == searchLine;
                            });
                            break;
                        }
                        case "Скорость":
                        {
                            iTransportBindingSource.DataSource = _transportList.FindAll(delegate(ITransport transport)
                            {
                                return transport.Speed.ToString() == searchLine;
                            });
                            break;
                        }
                        case "Степень износа":
                        {
                            iTransportBindingSource.DataSource = _transportList.FindAll(delegate(ITransport transport)
                            {
                                return transport.Wear.ToString() == searchLine;
                            });
                            break;
                        }
                        case "Объем бака":
                        {
                            iTransportBindingSource.DataSource = _transportList.FindAll(delegate(ITransport transport)
                            {
                                return transport.CurrentVolume.ToString() == searchLine;
                            });
                            break;
                        }
                        case "Тип топлива":
                        {
                            iTransportBindingSource.DataSource = _transportList.FindAll(delegate(ITransport transport)
                            {
                                return transport.TypeFuel.ToString() == searchLine;
                            });
                            break;
                        }
                        case "Расход топлива":
                        {
                            iTransportBindingSource.DataSource = _transportList.FindAll(delegate(ITransport transport)
                            {
                                return transport.FuelConsumption.ToString() == searchLine;
                            });
                            break;
                        }
                    }
                }
                else
                {
                    _messageServices.ShowExclamation("Не выбрано поле поиска.");
                }
            }
            else
            {
                _messageServices.ShowExclamation("База данных пуста.");
            }
        }

        /// <summary>
        /// Метод Сохранения
        /// </summary>
        private void Save()
        {
            if (_filePath != null)
            {
                Serialization.Serialize(_filePath, _transportList);
                _messageServices.ShowMessage("Сохранение прошло успешно.");
                PointFixer(_pointFixer = true);
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Файлы|*.tdb|Все файлы|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _filePath = sfd.FileName;
                    Serialization.Serialize(_filePath, _transportList);
                    _messageServices.ShowMessage("Сохранение прошло успешно.");
                    PointFixer(_pointFixer = true);
                }
            }
        }

        /// <summary>
        /// Обновить (Меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iTransportBindingSource.DataSource = _transportList;
        }

        /// <summary>
        /// Обновить (Кнопка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            iTransportBindingSource.DataSource = _transportList;
        }
    }
}
