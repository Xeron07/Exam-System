using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace OnlineExamSystem
{
    public partial class createCourse : UserControl
    {
        string courseName, courseID, courseSec;

        public createCourse()
        {
            InitializeComponent();
        }

        private void createCourse_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Red, Color.Black, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            courseName = textBox1.Text;
            courseID = textBox2.Text;
            courseSec = comboBox1.Text;
        }
    }
}
