using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseFinal
{
    public partial class MangerShowTime : Form
    {
        public MangerShowTime()
        {
            InitializeComponent();
        }

        private void showTimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showTimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieTheatreDataSet);

        }

        private void MangerShowTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieTheatreDataSet.ShowTime' table. You can move, or remove it, as needed.
            this.showTimeTableAdapter.Fill(this.movieTheatreDataSet.ShowTime);

        }
    }
}
