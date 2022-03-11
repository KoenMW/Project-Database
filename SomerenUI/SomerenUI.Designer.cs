namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.TeacherId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supervisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.room_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlActivities = new System.Windows.Forms.Panel();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivitieName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(940, 0);
            this.imgDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(466, 415);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1449, 51);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(192, 48);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(329, 54);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(326, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(329, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(158, 48);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(162, 48);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(159, 48);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(134, 48);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(18, 42);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1407, 717);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(20, 20);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(290, 20);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.pictureBox1);
            this.pnlStudents.Controls.Add(this.lbl_Students);
            this.pnlStudents.Location = new System.Drawing.Point(18, 42);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1407, 717);
            this.pnlStudents.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(24, 65);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1147, 470);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            this.studentID.Width = 160;
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            this.studentName.Width = 160;
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            this.studentDOB.Width = 160;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(15, 15);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(255, 65);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.pnlActivities);
            this.pnlTeachers.Controls.Add(this.listViewTeachers);
            this.pnlTeachers.Controls.Add(this.pictureBox2);
            this.pnlTeachers.Controls.Add(this.label1);
            this.pnlTeachers.Location = new System.Drawing.Point(18, 42);
            this.pnlTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(1402, 712);
            this.pnlTeachers.TabIndex = 6;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeacherId,
            this.TeacherName,
            this.Supervisor});
            this.listViewTeachers.GridLines = true;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(24, 65);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1147, 470);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // TeacherId
            // 
            this.TeacherId.Text = "ID";
            this.TeacherId.Width = 160;
            // 
            // TeacherName
            // 
            this.TeacherName.Text = "Name";
            this.TeacherName.Width = 160;
            // 
            // Supervisor
            // 
            this.Supervisor.Text = "Supervisor";
            this.Supervisor.Width = 160;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 189);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teachers";
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.listViewRooms);
            this.pnlRooms.Controls.Add(this.pictureBox4);
            this.pnlRooms.Controls.Add(this.label3);
            this.pnlRooms.Location = new System.Drawing.Point(18, 42);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(1398, 708);
            this.pnlRooms.TabIndex = 7;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.room_number,
            this.capacity,
            this.type});
            this.listViewRooms.GridLines = true;
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(24, 65);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(1147, 470);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // room_number
            // 
            this.room_number.Text = "Room Number";
            this.room_number.Width = 160;
            // 
            // capacity
            // 
            this.capacity.Text = "Capacity";
            this.capacity.Width = 160;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 160;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(195, 189);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rooms";
            // 
            // pnlActivities
            // 
            this.pnlActivities.Controls.Add(this.listViewActivities);
            this.pnlActivities.Controls.Add(this.pictureBox3);
            this.pnlActivities.Controls.Add(this.label2);
            this.pnlActivities.Location = new System.Drawing.Point(5, 0);
            this.pnlActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlActivities.Name = "pnlActivities";
            this.pnlActivities.Size = new System.Drawing.Size(1402, 712);
            this.pnlActivities.TabIndex = 7;
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ActivitieName,
            this.DateTime});
            this.listViewActivities.GridLines = true;
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(24, 65);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(1147, 470);
            this.listViewActivities.TabIndex = 5;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 160;
            // 
            // ActivitieName
            // 
            this.ActivitieName.Text = "Name";
            this.ActivitieName.Width = 160;
            // 
            // DateTime
            // 
            this.DateTime.Text = "Time";
            this.DateTime.Width = 160;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 189);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activities";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 765);
            this.Controls.Add(this.pnlTeachers);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTeachers.ResumeLayout(false);
            this.pnlTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlActivities.ResumeLayout(false);
            this.pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader room_number;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader TeacherId;
        private System.Windows.Forms.ColumnHeader TeacherName;
        private System.Windows.Forms.ColumnHeader Supervisor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ActivitieName;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}

