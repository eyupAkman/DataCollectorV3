using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataCollectorV3.Interfaces.Abstract.IUserControl;

namespace DataCollectorV3.UIWinForm.UserControls
{
    public partial class ChildModule : UserControl, IChildModule
    {
        #region Constructors

        public ChildModule()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        [DisplayName("AutoKey"), Category("Special")]
        public bool AutoKey { get; set; }

        [DisplayName("Key"), Category("Special")]
        public string Key
        {
            get => KeyBox.Text;
            set => Invoke((MethodInvoker) delegate { KeyBox.Text = value; });
        }

        [DisplayName("KeyColor"), Category("Special")]
        public Color KeyColor
        {
            get => KeyBox.BackColor;
            set => Invoke((MethodInvoker) delegate { KeyBox.BackColor = value; });
        }

        [DisplayName("Result"), Category("Special")]
        public string Result
        {
            get => ResultBox.Text;
            set => Invoke((MethodInvoker) delegate { ResultBox.Text = value; });
        }

        [DisplayName("ResultColor"), Category("Special")]
        public Color ResultColor
        {
            get => ResultBox.BackColor;
            set => Invoke((MethodInvoker) delegate { ResultBox.BackColor = value; });
        }

        [DisplayName("XPath"), Category("Special")]
        public string XPath
        {
            get => EditPath(PathBox.Text);
            set => Invoke((MethodInvoker) delegate { PathBox.Text = value; });
        }

        [DisplayName("XPathColor"), Category("Special")]
        public Color XPathColor
        {
            get => PathBox.BackColor;
            set => Invoke((MethodInvoker) delegate { PathBox.BackColor = value; });
        }

        #endregion

        #region Methods

        #region Operations

        private void FlashLabel()
        {
            lblCopied.BringToFront();
            var t = new Timer {Interval = 500};
            t.Tick += (s, e) =>
            {
                lblCopied.SendToBack();
                t.Dispose();
            };
            t.Start();
        }

        #region Editors

        private string EditPath(string path)
        {
            return path.Replace("/tbody", "").Trim();
        }

        private void BoxEdit()
        {
            KeyBox.BackColor = Color.FromArgb(32, 32, 32);
            KeyBox.Text = AutoKey ? @" Auto Key" : @" Manual Key";
            KeyBox.ReadOnly = AutoKey;
        }

        #endregion

        #endregion

        #region Events

        private void TbxEnter(object sender, EventArgs e)
        {
            var tbx = (TextBox) sender;
            tbx.SelectAll();
        }

        private void KeyBox_Leave(object sender, EventArgs e)
        {
            if (KeyBox.Text == String.Empty) KeyBox.Text = @" Manual Key";
        }

        private void PathBox_Leave(object sender, EventArgs e)
        {
            if (PathBox.Text == String.Empty) PathBox.Text = @" XPath";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void ResultBox_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultBox.Text);
            FlashLabel();
        }

        private void ChkBox_CheckStateChanged(object sender, EventArgs e)
        {
            AutoKey = ChkBox.Checked;
            BoxEdit();
        }

        #endregion

        #endregion
    }
}