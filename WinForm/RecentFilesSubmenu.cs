using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBD
{
    class RecentFilesSubmenu
    {
        private List<string> _recentFiles= new List<string>();

        /// <summary>
        /// Добавление файлов в лист
        /// </summary>
        /// <param name="filePath"></param>
        public void AddRecentFiles(string filePath)
        {
            if (_recentFiles.Contains(filePath))
                _recentFiles.RemoveAt(_recentFiles.IndexOf(filePath));

            _recentFiles.Insert(0, filePath);

            if(_recentFiles.Count<5)
                for (int i = 5; i < _recentFiles.Count; i++)
                {
                    _recentFiles.RemoveAt(i);
                }
        }

        /// <summary>
        /// Выдача листа 'Недавних файлов'
        /// </summary>
        /// <returns></returns>
        public List<string> RecentFilesList()
        {
            return _recentFiles.ToList();
        }
    }
}
