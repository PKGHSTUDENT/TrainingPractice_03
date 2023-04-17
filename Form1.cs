using System;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by @dobrodelete");
        }

        private void handbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Handbook handbook = new Handbook();
            handbook.ShowDialog();
        }

        private void fuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        private void accountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.ShowDialog();
        }
    }
}
