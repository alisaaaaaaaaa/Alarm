using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Будильник
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void plucbutton_Click(object sender, EventArgs e)
        {
            NewAlarm newAlarm = new NewAlarm();
            newAlarm.ShowDialog();
        }
    }
}
