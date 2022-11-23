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
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {

        }

        private void screenRoomButton_Click(object sender, EventArgs e)
        {
            ScreenRoomForm myScreenRoom = new ScreenRoomForm();
            myScreenRoom.ShowDialog();

        }
    }
}
