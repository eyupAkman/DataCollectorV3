using System;
using System.Linq;
using System.Threading.Tasks;
using DataCollectorV3.Interfaces.Abstract.IData;
using DataCollectorV3.Interfaces.Abstract.IUserControl;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace DataCollectorV3.Business.Concrete
{
    public class Worker
    {
        #region Fields

        private readonly HtmlWeb _web = new HtmlWeb();
        private HtmlDocument _doc;
        private HtmlNode _node;
        private int _count;
        private string _temp;
        private string[] _obj;
        private Action _act;
        private IDataEntity _entity;
        private IParentModule _parentModule;

        #endregion

        #region Constructors

        #endregion

        #region Methods

        #region Setups

        private void Setups(IParentModule parentModule, IDataEntity entity)
        {
            _parentModule = parentModule;
            _entity = entity;
            _count = _entity.KeyList.Count;
            _act = _parentModule.Sequential ? (Action) Sequential : Periodic;
        }

        #endregion

        #region Operations

        public void Work(IParentModule parentModule, IDataEntity entity)
        {
            Setups(parentModule, entity);
            _act.Invoke();
        }

        private void Sequential()
        {
            var completedCount = 0;
            var totalCount = _parentModule.EndPage - _parentModule.StartPage;
            Parallel.For(_parentModule.StartPage, _parentModule.EndPage, i =>
            {
                completedCount++;
                SetText($@"Completed {completedCount} of {totalCount}");
                DocLoad(i);
                CreateObject();
                _entity.ObjList.Add(_obj);
            });
        }

        private void DocLoad(int i)
        {
            _doc = _web.Load(_parentModule.Url + i);
        }

        private void CreateObject()
        {
            _obj = new string[_count];
            for (int j = 0; j < _count; j++)
            {
                TryNodeLoading(j);
                if (_node == null) continue;
                _temp = _node.InnerText.Trim();
                (_entity.BoolList[j] ? (Action<int>) AutoKeyWork : ManualKeyWork)(j);
            }
        }

        private void TryNodeLoading(int j)
        {
            _node = null;
            try
            {
                _node = _doc.DocumentNode.SelectSingleNode(_entity.PathList[j]);
            }
            catch
            {
                // ignored
            }
        }

        private void AutoKeyWork(int j)
        {
            if (!_temp.Contains(_parentModule.Separator)) return;
            var spl = _temp.Split(new[] {_parentModule.Separator}, StringSplitOptions.None);
            var key = EditString(spl[0]);
            var length = key.Length + _parentModule.Separator.Length;
            var value = EditString(_temp.Substring(length));
            var idx = _entity.KeyList.IndexOf(key);
            _obj[idx] = value;
        }

        private void ManualKeyWork(int j)
        {
            _obj[j] = EditString(_temp);
        }

        private void Periodic()
        {
        }

        #endregion

        #region Editors

        private string EditString(string value)
        {
            var result = value.Replace("\t", "").Replace("\r", "").Trim();
            if (!result.Contains('"') && !result.Contains(',') && !result.Contains("\n")) return result;
            result = result.Replace(@"""", @"""""");
            result = $@"""{result}""";
            return result;
        }

        private void SetText(string txt)
        {
            _parentModule.BtnStartText = txt;
        }

        #endregion

        #endregion
    }
}