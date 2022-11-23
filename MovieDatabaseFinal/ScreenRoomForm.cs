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
    public partial class ScreenRoomForm : Form
    {
        public ScreenRoomForm()
        {
            InitializeComponent();
        }

        private void screenRoomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.screenRoomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieTheatreDataSet);

        }

        private void ScreenRoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieTheatreDataSet.ScreenRoom' table. You can move, or remove it, as needed.
            this.screenRoomTableAdapter.Fill(this.movieTheatreDataSet.ScreenRoom);

        }
    }
}
