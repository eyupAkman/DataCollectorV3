using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DataCollectorV3.Interfaces.Abstract.IData;
using DataCollectorV3.Interfaces.Abstract.IUserControl;

namespace DataCollectorV3.Business.Concrete
{
    public class Exporter
    {
        #region Fields

        private IDataEntity _entity;
        private IParentModule _parentModule;
        private string _txt;

        #endregion

        #region Constructors

        #endregion

        #region Methods

        #region Setups

        private void Setups(IParentModule parentModule, IDataEntity entity)
        {
            _parentModule = parentModule;
            _entity = entity;
        }

        #endregion

        #region Operation Queue

        public void WriteTable(IParentModule parentModule, IDataEntity entity)
        {
            Setups(parentModule, entity);
            CreateTable();
            ExportTable();
        }

        #endregion

        #region Operations

        private void CreateTable()
        {
            SetText("Creating Table");
            CreateHeaders();
            AddObjects();
        }

        private void CreateHeaders()
        {
            _txt = _entity.KeyList.Aggregate("", (current, i) => current + $@",{i}").Substring(1);
        }

        private void AddObjects()
        {
            foreach (var strings in _entity.ObjList)
            {
                if (strings.All(s => s == null)) continue;
                var tmp = strings.Aggregate("", (current, i) => current + $@",{i}").Substring(1);
                _txt += $"\n{tmp}";
            }
        }

        private void ExportTable()
        {
            SetText("Exporting table");
            var thread = new Thread(param =>
            {
                var sf = new SaveFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    RestoreDirectory = true,
                    FileName = @"*.csv",
                    DefaultExt = "csv",
                    Filter = @"Text Files |*.txt |CSV Table |*.csv|Rich Text Document |*.rtf"
                };
                if (sf.ShowDialog() != DialogResult.OK) return;
                using (var sw = new StreamWriter(sf.OpenFile()))
                {
                    sw.Write(_txt);
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        #endregion

        #region Editors

        private void SetText(string txt)
        {
            _parentModule.BtnStartText = txt;
        }

        #endregion

        #endregion
    }
}