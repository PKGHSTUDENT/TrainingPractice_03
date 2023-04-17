using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class Handbook : Form
    {
        public Handbook()
        {
            InitializeComponent();
        }

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gasStationDataSet);

        }

        private void Handbook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gasStationDataSet.provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.gasStationDataSet.provider);

        }
    }
}
