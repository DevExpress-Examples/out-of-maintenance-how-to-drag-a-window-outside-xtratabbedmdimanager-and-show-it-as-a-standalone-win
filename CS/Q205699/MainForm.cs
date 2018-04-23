using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraTab.ViewInfo;
using System.Diagnostics;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Q205699 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            xtraTabbedMdiManager1.FloatPageDragMode = FloatPageDragMode.FullWindow;
            xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            for(int i = 0; i < 3; i++) {
                AddChild();
            }
        }
        int childCount = 1;
        void AddChild() {
            Form childForm = new Form();
            childForm.Text = "Form" + childCount;

            LabelControl label = new LabelControl();
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Text = "Form" + childCount++;
            childForm.Controls.Add(label);
            label.Dock = DockStyle.Fill;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}