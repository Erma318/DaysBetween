using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysBetween
{
    public partial class Form1 : Form
    {
        TimeSpan gap;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            gap = secondPick.Value - firstPick.Value;
            resShow.Text = gap.TotalDays.ToString("0");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            firstPick.ValueChanged -= firstPick_ValueChanged;
            secondPick.ValueChanged -= secondPick_ValueChanged;
            resShow.Text = "";
            firstPick.MaxDate = new DateTime(9998, 12, 31);
            secondPick.MinDate = new DateTime(1753, 1, 1);
            firstPick.ResetText();
            secondPick.ResetText();
            firstPick.ValueChanged += firstPick_ValueChanged;
            secondPick.ValueChanged += secondPick_ValueChanged;
        }

        private void firstPick_ValueChanged(object sender, EventArgs e)
        {
            secondPick.MinDate = firstPick.Value;
        }

        private void secondPick_ValueChanged(object sender, EventArgs e)
        {
            firstPick.MaxDate = secondPick.Value;
        }
    }
}
