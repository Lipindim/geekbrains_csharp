using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7.Task1
{
    public partial class DoublerForm : Form
    {
        private readonly Doubler doubler;

        public DoublerForm()
        {
            InitializeComponent();
            this.doubler = new Doubler();
            this.UpdateInterface();
        }

        private void UpdateInterface()
        {
            lblTargetValue.Text = this.doubler.TargetValue.ToString();
            lblCurrentValue.Text = this.doubler.CurrentValue.ToString();
            lblCommandCount.Text = this.doubler.CommandCount.ToString();
        }

        private void btnPlusCommand_Click(object sender, EventArgs e)
        {
            this.doubler.PlusOne();
            this.UpdateInterface();
            if (this.doubler.IsWin())
                this.Win();
        }

        private void Win()
        {
            MessageBox.Show("Поздравляем! Вы победили!!!");
            this.gbGameControls.Enabled = false;
        }

        private void btnMultyCommand_Click(object sender, EventArgs e)
        {
            this.doubler.MyltiplyByTwo();
            this.UpdateInterface();
            if (this.doubler.IsWin())
                this.Win();
        }

        private void btnClearCommand_Click(object sender, EventArgs e)
        {
            this.doubler.Reset();
            this.UpdateInterface();
        }

        private void btnCancelCommand_Click(object sender, EventArgs e)
        {
            this.doubler.Cancel();
            this.UpdateInterface();
        }
    }
}
