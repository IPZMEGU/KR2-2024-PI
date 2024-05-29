using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR2_2024_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тату у нас сьогодні в школі скорочені батьківські збори.\n– Що значить скорочені?\n– Ти, я і директор.", "Анекдот", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
