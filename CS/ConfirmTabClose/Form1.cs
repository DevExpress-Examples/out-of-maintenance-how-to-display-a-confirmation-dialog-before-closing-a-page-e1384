using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace ConfirmTabClose {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e) {
            XtraTabControl tabControl = (XtraTabControl)sender;
            ClosePageButtonEventArgs arg = (ClosePageButtonEventArgs)e;
            if(MessageBox.Show(string.Format("Close {0}?", arg.Page.Text), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                ((XtraTabPage)arg.Page).PageVisible = false;
            }
        }
    }
}
