using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCollectorV3.Business.Concrete;
using DataCollectorV3.Entities.Concrete.Appearance;
using DataCollectorV3.Entities.Concrete.DataLibraries;
using DataCollectorV3.Interfaces.Abstract.IUserControl;
using static System.String;

namespace DataCollectorV3.UIWinForm.UserControls
{
    public partial class ParentModule : UserControl, IParentModule
    {
        #region Fields

        private Action _btnAction;
        private DataEntity _entity = new DataEntity();
        private readonly Inspector _inspector = new Inspector();
        private readonly Worker _worker = new Worker();
        private readonly Exporter _exporter = new Exporter();

        #endregion

        #region Constructors

        public ParentModule()
        {
            InitializeComponent();
            FirstSetups();
            SetColors();
        }

        #endregion

        #region Properties

        public string BtnStartText
        {
            get => BtnStart.Text;
            set => Invoke((MethodInvoker) delegate { BtnStart.Text = value; });
        }

        public List<IChildModule> ChildModules
        {
            get
            {
                var childModules = new List<IChildModule>();
                foreach (ChildModule module in ChildContainer.Controls)
                {
                    childModules.Add(module);
                }

                return childModules;
            }
        }

        public bool Sequential { get; private set; }
        public string Url => TbxUrl.Text;

        public Color UrlColor
        {
            get => TbxUrl.BackColor;
            set => Invoke((MethodInvoker) delegate { TbxUrl.BackColor = value; });
        }

        public int ControlPage => TbxCtPage.Text.Equals(Empty) ? -1 : Convert.ToInt32(TbxCtPage.Text);

        public Color ControlPageColor
        {
            get => TbxCtPage.BackColor;
            set => Invoke((MethodInvoker) delegate { TbxCtPage.BackColor = value; });
        }

        public string Separator
        {
            get => TbxSep.Text.Equals("newline") ? "\n" : TbxSep.Text;
            set => TbxSep.Text = value;
        }

        public Color SeparatorColor
        {
            get => TbxSep.BackColor;
            set => Invoke((MethodInvoker) delegate { TbxSep.BackColor = value; });
        }

        public int StartPage
        {
            get => TbxStart.Text.Equals(Empty) ? -1 : Convert.ToInt32(TbxStart.Text);
            set => Invoke((MethodInvoker) delegate { TbxStart.Text = value.ToString(); });
        }

        public Color StartPageColor
        {
            get => TbxStart.BackColor;
            set => Invoke((MethodInvoker) delegate { TbxStart.BackColor = value; });
        }

        public int EndPage
        {
            get => TbxEnd.Text.Equals(Empty) ? -1 : Convert.ToInt32(TbxEnd.Text);
            set => Invoke((MethodInvoker) delegate { TbxEnd.Text = value.ToString(); });
        }

        public Color EndPageColor
        {
            get => TbxEnd.BackColor;
            set => Invoke((MethodInvoker) delegate { TbxEnd.BackColor = value; });
        }

        public int Seconds => TbxSeconds.Text.Equals(Empty) ? -1 : Convert.ToInt32(TbxSeconds.Text);

        public Color SecondsColor
        {
            get => TbxSeconds.BackColor;
            set => Invoke((MethodInvoker) delegate { TbxSeconds.BackColor = value; });
        }

        #endregion

        #region Methods

        #region Setups

        private void FirstSetups()
        {
            RbSeq.Checked = true;
            ChildContainer.Controls.Add(new ChildModule {Margin = new Padding(20, 3, 0, 3)});
            BtnStart.Click += (s, e) => { _btnAction(); };
            _btnAction = InspectAll;
        }

        private void SetColors()
        {
            var palette = new CustomColorPalette().GetRandomSingleTonePalette(100, 80, 73, 65, 20, 8);
            BtnClose.BackColor = palette[0];
            PnlOptions.BackColor = palette[1];
            TbxUrl.BackColor = palette[2];
            TbxCtPage.BackColor = palette[2];
            TbxSep.BackColor = palette[2];
            TbxStart.BackColor = palette[2];
            TbxEnd.BackColor = palette[2];
            TbxSeconds.BackColor = palette[2];
            BtnStart.BackColor = palette[3];
            BtnAdd.BackColor = palette[4];
            PnlHeader.BackColor = palette[5];
            ChildContainer.BackColor = palette[5];
            PnlFooter.BackColor = palette[5];
        }

        private void Reset()
        {
            _entity = new DataEntity();
        }

        #endregion

        #region Operations

        private void InspectAll()
        {
            Reset();
            _btnAction = NullAction;
            Task.Factory.StartNew(() =>
            {
                if (_inspector.IsOk(this, _entity))
                {
                    SetText("Looks everything is OK. Click here to start work");
                    _btnAction = StartToWork;
                }
                else
                {
                    SetText("Ooops! Something went wrong... Try again.");
                    _btnAction = InspectAll;
                }
            });
        }

        private void StartToWork()
        {
            _btnAction = NullAction;
            Task.Factory.StartNew(() => { _worker.Work(this, _entity); }).ContinueWith(task =>
            {
                SetText("Completed all scans. Click here to save table");
                _btnAction = WriteTable;
            });
        }

        private void WriteTable()
        {
            Task.Factory.StartNew(() => { _exporter.WriteTable(this, _entity); }).ContinueWith(task =>
            {
                SetText("Restart");
                _btnAction = InspectAll;
            });
        }

        private void NullAction()
        {
        }

        #endregion

        #region Editors

        private void SetText(string txt)
        {
            BtnStartText = txt;
        }

        #endregion

        #region Events

        private void Resizing(object sender, ControlEventArgs c)
        {
            if (ChildContainer.Controls.Count > 10) return;
            Height = (ChildContainer.Controls.Count * 31) + 220;
        }

        private void RbChanged(object sender, EventArgs e)
        {
            Sequential = RbSeq.Checked;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ChildContainer.Controls.Add(new ChildModule {Margin = new Padding(20, 3, 0, 3)});
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void TbxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxEnter(object sender, EventArgs e)
        {
            var tbx = (TextBox) sender;
            tbx.SelectAll();
        }

        #endregion

        #endregion
    }
}