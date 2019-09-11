using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCollectorV3.UIWinForm.UserControls;

namespace DataCollectorV3.UIWinForm.Forms
{
    public partial class MainDashboard : Form
    {
        #region Constructors

        public MainDashboard()
        {
            InitializeComponent();
            FirstSetup();
        }

        #endregion

        #region Methods

        #region Setups

        private void FirstSetup()
        {
            AddForm();
        }

        #endregion

        #region Operations

        private void AddForm()
        {
            Task.Factory.StartNew(() =>
            {
                Invoke((MethodInvoker) delegate
                {
                    ParentContainer.Controls.Add(new ParentModule {Margin = new Padding(20, 0, 0, 10)});
                });
            });
        }

        #endregion

        #region Events

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddForm();
        }

        #endregion

        #endregion
    }
}