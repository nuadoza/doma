using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    public partial class Galaxy : Form
    {
        public Galaxy()
        {
            InitializeComponent();
        }        
        private void Galaxy_Load(object sender, EventArgs e)
        {
        }

        private void startattack_Click(object sender, EventArgs e)
        {
           pictureBox1.Visible = false;
             
            startattack.Visible = false;
            drownout.Visible = true;
            camouflage.Visible = true;
            back.Visible = true;

        }
        private void drownout_Click(object sender, EventArgs e)
        {
            
        }
        static Timer timer;
        private void camouflage_Click(object sender, EventArgs e)
        {            
            timer = new Timer();
            timer.Interval = 2000; // Интервал в миллисекундах (15 секунд)
            // Скрываем pictureBox2 и отображаем camouflage
            pictureBox2.Visible = false;
            camouflage.Visible = true;
            // Запускаем таймер
            timer.Start();          
        }

        private void back_Click(object sender, EventArgs e)
        {
           Close(); 
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
    }
}
