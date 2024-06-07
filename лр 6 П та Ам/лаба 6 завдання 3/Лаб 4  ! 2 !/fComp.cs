using System;
using System.Windows.Forms;

namespace Лаб_3___2__
{
    public partial class fComp : Form
    {
        public Comp TheComp;

        public fComp(Comp t)
        {
            TheComp = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheComp.Name = tbName.Text.Trim();
            TheComp.os = tbOs.Text.Trim();
            TheComp.Virob = tbvirob.Text.Trim();
            TheComp.Proc = int.Parse(tbproc.Text.Trim());
            TheComp.Bios = double.Parse(tbbios.Text.Trim());
            TheComp.OperMemory = double.Parse(tboperMemory.Text.Trim());
            TheComp.Inch = chbinch.Checked;
            TheComp.Overclocking = chboverclocking.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fComp_Load(object sender, EventArgs e)
        {
            if (TheComp != null)
            {
                tbName.Text = TheComp.Name;
                tbOs.Text = TheComp.os;
                tbvirob.Text = TheComp.Virob;
                tbproc.Text = TheComp.Proc.ToString();
                tbbios.Text = TheComp.Bios.ToString();
                tboperMemory.Text = TheComp.OperMemory.ToString();
                chbinch.Checked = TheComp.Inch;
                chboverclocking.Checked = TheComp.Overclocking;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
