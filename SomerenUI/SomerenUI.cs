using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    // clear the listview before filling it again
                    listViewStudents.Items.Clear();
                    //fill listview
                    foreach (Student s in studentList)
                    {
                        ListViewItem li = new ListViewItem(s.Number.ToString());
                        string[] names = s.Name.Split(' ');
                        li.SubItems.Add(names[0]);
                        li.SubItems.Add(names[1]);
                        li.SubItems.Add(s.BirthDate.ToString("dd-MM-yyyy"));
                        listViewStudents.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Teachers")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();

                // show teachers
                pnlTeachers.Show();

                try
                {
                    // fill the teachers listview within the students panel with a list of students
                    TeacherService teacherService = new TeacherService(); ;
                    List<Teacher> teacherList = teacherService.GetTeachers(); ;

                    // clear the listview before filling it again
                    listViewTeachers.Items.Clear();
                    //fill listview
                    foreach (Teacher teacher in teacherList)
                    {
                        ListViewItem li = new ListViewItem(teacher.Number.ToString());
                        li.SubItems.Add(teacher.Name);
                        if (teacher.Supervisor) li.SubItems.Add("Yes");
                        else li.SubItems.Add("No");
                        listViewTeachers.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();

                // show students
                pnlRooms.Show();

                try
                {
                    // fill the rooms listview within the rooms panel with a list of rooms
                    RoomService roomService = new RoomService(); ;
                    List<Room> roomList = roomService.GetRooms(); ;

                    // clear the listview before filling it again
                    listViewRooms.Items.Clear();
                    //fill listview
                    foreach (Room room in roomList)
                    {
                        ListViewItem li = new ListViewItem(room.Number.ToString());
                        li.SubItems.Add(room.Capacity.ToString());
                        if (!room.Type) li.SubItems.Add("Teacher");
                        else li.SubItems.Add("Student");
                        listViewRooms.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }

            else if (panelName == "Activities")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();

                // show activities
                pnlActivities.Show();
                try
                {
                    // fill the Activities listview within the activities panel with a list of activities
                    ActivityService actService = new ActivityService();
                    List<Activity> activitieList = actService.GetActivities();

                    // clear the listview before filling it again
                    listViewActivities.Items.Clear();
                    //fill listview
                    foreach (Activity a in activitieList)
                    {
                        ListViewItem li = new ListViewItem(a.Id.ToString());
                        li.SubItems.Add(a.Name);
                        li.SubItems.Add(a.Time.ToString());
                        listViewActivities.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
                }
            }
            else if (panelName == "Omzetrapportage")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                pnlSupply.Hide();

                // show activities
                Omzetrapportage.Show();
                try
                {
                    // fill the Activities listview within the activities panel with a list of activities
                    RevenueService Revservice = new RevenueService();
                    Revenue revenue = Revservice.GetRevenue();

                    // clear the listview before filling it again
                    listViewRevenue.Items.Clear();
                    //fill listview
                    ListViewItem li = new ListViewItem(revenue.Sales.ToString());
                    li.SubItems.Add(revenue.Ternover.ToString("€0.00"));
                    li.SubItems.Add(revenue.NumberOfCustomers.ToString());
                    listViewRevenue.Items.Add(li);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the revenue: " + e.Message);
                }
            }
            else if (panelName == "Supplies")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                // show supplies
                pnlSupply.Show();
                try
                {
                    // fill the supplies listview within the supplies panel with a list of supplies
                    SupplyService supplyService = new SupplyService();
                    List<Supply> Drinklist = supplyService.GetDrink();

                    // clear the listview before filling it again
                    listViewSupply.Items.Clear();
                    //fill listview
                    foreach (Supply s in Drinklist)
                    {
                        ListViewItem li = new ListViewItem(s.Id.ToString());
                        li.SubItems.Add(s.Drink);
                        li.SubItems.Add(s.Stock.ToString());
                        if (s.Stock < 10)
                        {
                            li.SubItems.Add("Stock insufficient");
                        }
                        else
                        {
                            li.SubItems.Add("Stock sufficient");
                        }
                        listViewSupply.Items.Add(li);

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void omzetrapportageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Omzetrapportage");
        }

        private void CalculateRevenue_Click(object sender, EventArgs e)
        {
            listViewRevenue.Items.Clear();
            try
            {
                // fill the Activities listview within the activities panel with a list of activities
                DateTime startDate = Convert.ToDateTime(monthCalendarStartDate.SelectionRange.Start.ToString("dd-MM-yyyy"));
                DateTime endDate = Convert.ToDateTime(monthCalendarEndDate.SelectionRange.Start.ToString("dd-MM-yyyy"));
                if (System.DateTime.Compare(startDate, System.DateTime.Now)<=0 && System.DateTime.Compare(endDate, System.DateTime.Now) <= 0)
                {
                    if (System.DateTime.Compare(startDate,endDate)<=0)
                    {
                        RevenueService Revservice = new RevenueService();
                        Revenue revenue = Revservice.GetRevenue(startDate, endDate);
                        // clear the listview before filling it again
                        listViewRevenue.Items.Clear();
                        //fill listview
                        ListViewItem li = new ListViewItem(revenue.Sales.ToString());
                        li.SubItems.Add(revenue.Ternover.ToString("€0.00"));
                        li.SubItems.Add(revenue.NumberOfCustomers.ToString());
                        listViewRevenue.Items.Add(li);
                    }
                    else
                    {
                        MessageBox.Show("Start date is after end date");
                    }
                }
                else
                {
                    MessageBox.Show("One of the selected dates is in the future");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Something went wrong while loading the revenue: " + E.Message);
            }
        }

        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supplies");
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Supply updatestock = new Supply(int.Parse(Idtxt.Text), int.Parse(Stocktxt.Text));
            SupplyService drinkService = new SupplyService();
            drinkService.UpdateDrink(updatestock);
            // hide all other panels
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlActivities.Hide();
            Omzetrapportage.Hide();
            // show supplies
            pnlSupply.Show();
            try
            {
                // fill the supplies listview within the supplies panel with a list of supplies
                SupplyService supplyService = new SupplyService();
                List<Supply> Drinklist = supplyService.GetDrink();

                // clear the listview before filling it again
                listViewSupply.Items.Clear();
                //fill listview
                foreach (Supply s in Drinklist)
                {
                    ListViewItem li = new ListViewItem(s.Id.ToString());
                    li.SubItems.Add(s.Drink);
                    li.SubItems.Add(s.Stock.ToString());
                    if (s.Stock < 10)
                    {
                        li.SubItems.Add("Stock insufficient");
                    }
                    else
                    {
                        li.SubItems.Add("Stock sufficient");
                    }
                    listViewSupply.Items.Add(li);

                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + i.Message);
            }
        }
    }
}
