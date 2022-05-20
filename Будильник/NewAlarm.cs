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
    public partial class NewAlarm : Form
    {
        public NewAlarm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void save_Click(object sender, EventArgs e)
        {
            if (time.Text.Equals("")|| textBox1.Text.Equals(""))
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                Alarm main = this.Owner as Alarm;
                
                if(radioButton1.Checked)
                {
                    main.dataGridView1.Rows.Add(true, time.Text, textBox1.Text);
                }
                else
                {
                    main.dataGridView1.Rows.Add(false, time.Text, textBox1.Text);
                }
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
