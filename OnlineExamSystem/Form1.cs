using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            scroll_panel.Height = profile_Button.Height;
            createCourse1.BringToFront();
        }

        private void Form_Close(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //create course click
        private void Profile_Button(object sender, EventArgs e)
        {
            scroll_panel.Height = profile_Button.Height;
            scroll_panel.Top = profile_Button.Top;
            createCourse1.BringToFront();
         
        }
        //Assign teacher click
        private void Course_Button(object sender, EventArgs e)
        {
            scroll_panel.Height = course_Button.Height;
            scroll_panel.Top = course_Button.Top;
            assignTeacher1.BringToFront();
        }
        //delete teacher click
        private void exm_click(object sender, EventArgs e)
        {
            scroll_panel.Height = exam_room.Height;
            scroll_panel.Top = exam_room.Top;
            deleteTeacher1.BringToFront();
        }

        private void history_click(object sender, EventArgs e)
        {
            scroll_panel.Height = histry_button.Height;
            scroll_panel.Top = histry_button.Top;
            deletestudent1.BringToFront();
        }
        //delete student click
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.10;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //delete course click
        private void mail_click(object sender, EventArgs e)
        {
            scroll_panel.Height = mail_button.Height;
            scroll_panel.Top = mail_button.Top;
            deleteCourse1.BringToFront();
        }
        
    }
}
