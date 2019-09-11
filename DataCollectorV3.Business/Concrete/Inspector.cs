using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataCollectorV3.Interfaces.Abstract.IData;
using DataCollectorV3.Interfaces.Abstract.IUserControl;
using HtmlAgilityPack;
using static System.String;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace DataCollectorV3.Business.Concrete
{
    public class Inspector
    {
        #region Fields

        private bool _ready = true;

        private readonly string[] _errorExplanations =
        {
            "Url must not be empty", "Url is invalid", "Control page must not be empty",
            "Separator must not be empty", "Start number must not be empty", "End number must not be empty",
            "There must be a difference between the start and end page", "Seconds must not be empty", "Add a field"
        };

        private readonly List<byte> _errorCodes = new List<byte>();
        private readonly HtmlWeb _web = new HtmlWeb();
        private HtmlDocument _doc;
        private HtmlNode _node;
        private string _temp, _url = "";
        private int _ctPage = -2;
        private IDataEntity _entity;
        private IParentModule _parentModule;

        #endregion

        #region Constructors

        #endregion

        #region Methods

        #region Setups

        private void DocLoad()
        {
            if (_url.Equals(_parentModule.Url) && _ctPage.Equals(_parentModule.ControlPage)) return;
            _url = _parentModule.Url;
            _ctPage = _parentModule.ControlPage;
            _doc = _web.Load(_url + _ctPage);
        }

        private void Reset(IParentModule parentModule, IDataEntity entity)
        {
            _parentModule = parentModule;
            _entity = entity;
            _ready = true;
            _errorCodes.Clear();
        }

        #endregion

        #region Operation Queue

        public bool IsOk(IParentModule parentModule, IDataEntity entity)
        {
            Reset(parentModule, entity);
            SetText("Checking options");
            UrlInspect();
            ControlPageInspect();
            SeparatorInspect();
            StartInspect();
            EndInspect();
            StartEndValidation();
            SecondsInspect();
            ChildModulesPresence();
            (_ready ? (Action) ContinueChildInspect : ShowErrors).Invoke();
            return _ready;
        }

        #endregion

        #region Operations

        private void UrlInspect()
        {
            if (!_parentModule.Url.Equals(Empty))
            {
                _parentModule.UrlColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.UrlColor = Color.Crimson;
                _errorCodes.Add(0);
            }

            if (Uri.IsWellFormedUriString(_parentModule.Url, UriKind.Absolute))
            {
                _parentModule.UrlColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.UrlColor = Color.Crimson;
                _errorCodes.Add(1);
            }
        }

        private void ControlPageInspect()
        {
            if (_parentModule.ControlPage >= 0)
            {
                _parentModule.ControlPageColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.ControlPageColor = Color.Crimson;
                _errorCodes.Add(2);
            }
        }

        private void SeparatorInspect()
        {
            if (!_parentModule.Separator.Equals(Empty))
            {
                _parentModule.SeparatorColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.SeparatorColor = Color.Crimson;
                _errorCodes.Add(3);
            }
        }

        private void StartInspect()
        {
            if (_parentModule.StartPage >= 0)
            {
                _parentModule.StartPageColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.StartPageColor = Color.Crimson;
                _errorCodes.Add(4);
            }
        }

        private void EndInspect()
        {
            if (_parentModule.EndPage >= 0)
            {
                _parentModule.EndPageColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.EndPageColor = Color.Crimson;
                _errorCodes.Add(5);
            }
        }

        private void StartEndValidation()
        {
            if (_parentModule.StartPage > _parentModule.EndPage)
            {
                var tmp = _parentModule.EndPage;
                _parentModule.EndPage = _parentModule.StartPage;
                _parentModule.StartPage = tmp;
            }

            if (_parentModule.EndPage - _parentModule.StartPage > 0)
            {
                _parentModule.StartPageColor = Color.MediumSeaGreen;
                _parentModule.EndPageColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.StartPageColor = Color.Crimson;
                _parentModule.EndPageColor = Color.Crimson;
                _errorCodes.Add(6);
            }
        }

        private void SecondsInspect()
        {
            if (_parentModule.Seconds >= 0)
            {
                _parentModule.SecondsColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                _parentModule.SecondsColor = Color.Crimson;
                _errorCodes.Add(7);
            }
        }

        private void ChildModulesPresence()
        {
            if (_parentModule.ChildModules.Count > 0) return;
            _ready = false;
            _errorCodes.Add(8);
        }

        private void ContinueChildInspect()
        {
            SetText("Inspecting fields");
            DocLoad();
            foreach (var childModule in _parentModule.ChildModules)
            {
                TryNodeLoading(childModule);
                (_node != null ? (Action<IChildModule>) NodeAvailable : NodeNull)(childModule);
            }
        }

        private void TryNodeLoading(IChildModule childModule)
        {
            _node = null;
            try
            {
                _node = _doc.DocumentNode.SelectSingleNode(childModule.XPath);
            }
            catch
            {
                // ignored
            }
        }

        private void NodeAvailable(IChildModule childModule)
        {
            ModuleIsOk(childModule);
            StringLoad();
            BoolListAdd(childModule);
            (childModule.AutoKey ? (Action<IChildModule>) AutoKeyWork : ManualKeyWork)(childModule);
        }

        private void ModuleIsOk(IChildModule childModule)
        {
            childModule.XPathColor = Color.MediumSeaGreen;
        }

        private void StringLoad()
        {
            _temp = _node.InnerText.Trim();
        }

        private void BoolListAdd(IChildModule childModule)
        {
            _entity.BoolList.Add(childModule.AutoKey);
        }

        private void NodeNull(IChildModule childModule)
        {
            _ready = false;
            childModule.XPath = @" XPath is invalid";
            childModule.XPathColor = Color.Crimson;
        }

        private void AutoKeyWork(IChildModule childModule)
        {
            (_temp.Contains(_parentModule.Separator) ? (Action<IChildModule>) SeparatorAvailable : SeparatorNull)(
                childModule);
        }

        private void SeparatorAvailable(IChildModule childModule)
        {
            var spl = _temp.Split(new[] {_parentModule.Separator}, StringSplitOptions.None);
            var key = EditString(spl[0]);
            var length = key.Length + _parentModule.Separator.Length;
            var value = EditString(_temp.Substring(length));
            if (!_entity.KeyList.Contains(key))
            {
                _entity.KeyList.Add(key);
                _entity.PathList.Add(childModule.XPath);
                childModule.Key = key;
                childModule.KeyColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                childModule.KeyColor = Color.Crimson;
                childModule.Key = @" Key already exists!";
            }

            childModule.Result = value;
            childModule.ResultColor = Color.MediumSeaGreen;
        }

        private void SeparatorNull(IChildModule childModule)
        {
            _ready = false;
            childModule.Key = @" Key not found";
            childModule.KeyColor = Color.Crimson;
        }

        private void ManualKeyWork(IChildModule childModule)
        {
            var key = EditString(childModule.Key);
            var result = EditString(_temp);
            if (!_entity.KeyList.Contains(key))
            {
                if (!childModule.Key.Equals(@" Manual Key") && !childModule.Key.Equals(@" Please enter a keyword") &&
                    !childModule.Key.Equals(@" Key already exists!"))
                {
                    childModule.KeyColor = Color.MediumSeaGreen;
                    _entity.KeyList.Add(key);
                    _entity.PathList.Add(childModule.XPath);
                }
                else
                {
                    _ready = false;
                    childModule.Key = @" Please enter a keyword";
                    childModule.KeyColor = Color.Crimson;
                }

                childModule.Result = result;
                childModule.ResultColor = Color.MediumSeaGreen;
            }
            else
            {
                _ready = false;
                childModule.Key = @" Key already exists!";
                childModule.KeyColor = Color.Crimson;
            }
        }

        #endregion

        #region Editors

        private void ShowErrors()
        {
            var str = _errorCodes.Aggregate("", (current, t) => current + $"\n- {_errorExplanations[t]}");
            MessageBox.Show(str.Trim());
        }

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