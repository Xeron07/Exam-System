namespace OnlineExamSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scroll_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOut_button = new System.Windows.Forms.Button();
            this.histry_button = new System.Windows.Forms.Button();
            this.exam_room = new System.Windows.Forms.Button();
            this.mail_button = new System.Windows.Forms.Button();
            this.course_Button = new System.Windows.Forms.Button();
            this.profile_Button = new System.Windows.Forms.Button();
            this.App_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.deleteCourse1 = new OnlineExamSystem.deleteCourse();
            this.assignTeacher1 = new OnlineExamSystem.assignTeacher();
            this.createCourse1 = new OnlineExamSystem.createCourse();
            this.deletestudent1 = new OnlineExamSystem.deletestudent();
            this.deleteTeacher1 = new OnlineExamSystem.deleteTeacher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.scroll_panel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logOut_button);
            this.panel1.Controls.Add(this.histry_button);
            this.panel1.Controls.Add(this.exam_room);
            this.panel1.Controls.Add(this.mail_button);
            this.panel1.Controls.Add(this.course_Button);
            this.panel1.Controls.Add(this.profile_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 595);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(18, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Admin";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scroll_panel
            // 
            this.scroll_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.scroll_panel.Location = new System.Drawing.Point(3, 172);
            this.scroll_panel.Name = "scroll_panel";
            this.scroll_panel.Size = new System.Drawing.Size(10, 32);
            this.scroll_panel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 81);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // logOut_button
            // 
            this.logOut_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.logOut_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut_button.FlatAppearance.BorderSize = 0;
            this.logOut_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.logOut_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_button.ForeColor = System.Drawing.Color.White;
            this.logOut_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut_button.Location = new System.Drawing.Point(30, 428);
            this.logOut_button.Name = "logOut_button";
            this.logOut_button.Size = new System.Drawing.Size(148, 44);
            this.logOut_button.TabIndex = 2;
            this.logOut_button.Text = "LogOut";
            this.logOut_button.UseVisualStyleBackColor = false;
            // 
            // histry_button
            // 
            this.histry_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.histry_button.FlatAppearance.BorderSize = 0;
            this.histry_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.histry_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.histry_button.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histry_button.ForeColor = System.Drawing.Color.White;
            this.histry_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.histry_button.Location = new System.Drawing.Point(9, 348);
            this.histry_button.Name = "histry_button";
            this.histry_button.Size = new System.Drawing.Size(169, 38);
            this.histry_button.TabIndex = 2;
            this.histry_button.Text = "Delete student";
            this.histry_button.UseVisualStyleBackColor = true;
            this.histry_button.Click += new System.EventHandler(this.history_click);
            // 
            // exam_room
            // 
            this.exam_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exam_room.FlatAppearance.BorderSize = 0;
            this.exam_room.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.exam_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exam_room.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_room.ForeColor = System.Drawing.Color.White;
            this.exam_room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exam_room.Location = new System.Drawing.Point(9, 304);
            this.exam_room.Name = "exam_room";
            this.exam_room.Size = new System.Drawing.Size(169, 38);
            this.exam_room.TabIndex = 2;
            this.exam_room.Text = "Delete teacher";
            this.exam_room.UseVisualStyleBackColor = true;
            this.exam_room.Click += new System.EventHandler(this.exm_click);
            // 
            // mail_button
            // 
            this.mail_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mail_button.FlatAppearance.BorderSize = 0;
            this.mail_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.mail_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mail_button.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_button.ForeColor = System.Drawing.Color.White;
            this.mail_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mail_button.Location = new System.Drawing.Point(12, 260);
            this.mail_button.Name = "mail_button";
            this.mail_button.Size = new System.Drawing.Size(169, 38);
            this.mail_button.TabIndex = 2;
            this.mail_button.Text = "Delete course";
            this.mail_button.UseVisualStyleBackColor = true;
            this.mail_button.Click += new System.EventHandler(this.mail_click);
            // 
            // course_Button
            // 
            this.course_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.course_Button.FlatAppearance.BorderSize = 0;
            this.course_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.course_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course_Button.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_Button.ForeColor = System.Drawing.Color.White;
            this.course_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.course_Button.Location = new System.Drawing.Point(9, 216);
            this.course_Button.Name = "course_Button";
            this.course_Button.Size = new System.Drawing.Size(169, 38);
            this.course_Button.TabIndex = 2;
            this.course_Button.Text = "Assign teacher";
            this.course_Button.UseVisualStyleBackColor = true;
            this.course_Button.Click += new System.EventHandler(this.Course_Button);
            // 
            // profile_Button
            // 
            this.profile_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_Button.FlatAppearance.BorderSize = 0;
            this.profile_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.profile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_Button.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_Button.ForeColor = System.Drawing.Color.White;
            this.profile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_Button.Location = new System.Drawing.Point(12, 172);
            this.profile_Button.Name = "profile_Button";
            this.profile_Button.Size = new System.Drawing.Size(169, 38);
            this.profile_Button.TabIndex = 2;
            this.profile_Button.Text = "Create course";
            this.profile_Button.UseVisualStyleBackColor = true;
            this.profile_Button.Click += new System.EventHandler(this.Profile_Button);
            // 
            // App_Exit
            // 
            this.App_Exit.BackColor = System.Drawing.Color.Black;
            this.App_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.App_Exit.FlatAppearance.BorderSize = 0;
            this.App_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App_Exit.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Exit.ForeColor = System.Drawing.Color.White;
            this.App_Exit.Location = new System.Drawing.Point(851, -6);
            this.App_Exit.Name = "App_Exit";
            this.App_Exit.Size = new System.Drawing.Size(38, 32);
            this.App_Exit.TabIndex = 2;
            this.App_Exit.Text = "X";
            this.App_Exit.UseVisualStyleBackColor = false;
            this.App_Exit.Click += new System.EventHandler(this.Form_Close);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(799, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.App_Exit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 32);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 567);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // deleteCourse1
            // 
            this.deleteCourse1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteCourse1.Location = new System.Drawing.Point(184, 34);
            this.deleteCourse1.Name = "deleteCourse1";
            this.deleteCourse1.Size = new System.Drawing.Size(889, 561);
            this.deleteCourse1.TabIndex = 4;
            // 
            // assignTeacher1
            // 
            this.assignTeacher1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.assignTeacher1.Location = new System.Drawing.Point(184, 34);
            this.assignTeacher1.Name = "assignTeacher1";
            this.assignTeacher1.Size = new System.Drawing.Size(889, 561);
            this.assignTeacher1.TabIndex = 3;
            // 
            // createCourse1
            // 
            this.createCourse1.Location = new System.Drawing.Point(184, 31);
            this.createCourse1.Name = "createCourse1";
            this.createCourse1.Size = new System.Drawing.Size(889, 561);
            this.createCourse1.TabIndex = 2;
            // 
            // deletestudent1
            // 
            this.deletestudent1.Location = new System.Drawing.Point(184, 32);
            this.deletestudent1.Name = "deletestudent1";
            this.deletestudent1.Size = new System.Drawing.Size(889, 561);
            this.deletestudent1.TabIndex = 5;
            // 
            // deleteTeacher1
            // 
            this.deleteTeacher1.Location = new System.Drawing.Point(184, 32);
            this.deleteTeacher1.Name = "deleteTeacher1";
            this.deleteTeacher1.Size = new System.Drawing.Size(889, 561);
            this.deleteTeacher1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 595);
            this.Controls.Add(this.deleteTeacher1);
            this.Controls.Add(this.deletestudent1);
            this.Controls.Add(this.deleteCourse1);
            this.Controls.Add(this.assignTeacher1);
            this.Controls.Add(this.createCourse1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button course_Button;
        private System.Windows.Forms.Button profile_Button;
        private System.Windows.Forms.Button logOut_button;
        private System.Windows.Forms.Button histry_button;
        private System.Windows.Forms.Button mail_button;
       // private System.Windows.Forms.Button exm_rm_button;
        private System.Windows.Forms.Button App_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel scroll_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exam_room;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private createCourse createCourse1;
        private assignTeacher assignTeacher1;
        private deleteCourse deleteCourse1;
        private deletestudent deletestudent1;
        private deleteTeacher deleteTeacher1;
    }
}

