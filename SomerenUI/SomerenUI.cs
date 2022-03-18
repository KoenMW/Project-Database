using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
<<<<<<< Updated upstream
                Omzetrapportage.Hide();
=======
                pnlBtwOphalen.Hide();
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
                Omzetrapportage.Hide();
=======
                pnlBtwOphalen.Hide();
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
                Omzetrapportage.Hide();
=======
                pnlBtwOphalen.Hide();
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
                Omzetrapportage.Hide();
=======
                pnlBtwOphalen.Hide();
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
                Omzetrapportage.Hide();
=======
                pnlBtwOphalen.Hide();
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
            else if (panelName == "Omzetrapportage")
            {
                // hide all other panels
=======
            else if (panelName == "BtwOphalen")
            {
                //hide alle panels
>>>>>>> Stashed changes
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();

<<<<<<< Updated upstream
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
=======
                //show btw panel
                pnlBtwOphalen.Show();
                try
                {
                    ClearVAT();
                }
                catch (Exception)
                {

                    throw;
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
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
=======
        private void bTWBerekenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("BtwOphalen");
        }

        //Vanaf hier is BTW berekenen
        private void btnToonBTW_Click(object sender, EventArgs e)
        {
            VATCalculationService vatCalculationService = new VATCalculationService();
            VATCalculation vatCalculation = new VATCalculation();
            string year;
            DateTime[] maxMinDate = new DateTime[2];
            try
            {
                if (textBoxYear.Text == string.Empty || textBoxYear.Text.Length < 4 || textBoxYear.Text.Length > 4)
                {
                    throw new Exception("Verkeerd jaartal ingevoerd!");
                }
                else
                {
                    year = textBoxYear.Text;

                    if (radioBtnQ1.Checked)
                    {
                        maxMinDate[0] = System.DateTime.ParseExact($"01-01-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        maxMinDate[1] = System.DateTime.ParseExact($"31-03-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        lblMaanden.Text = $"Januari t/m Maart {year}";
                    }
                    else if (radioBtnQ2.Checked)
                    {
                        maxMinDate[0] = System.DateTime.ParseExact($"01-04-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        maxMinDate[1] = System.DateTime.ParseExact($"30-06-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        lblMaanden.Text = $"April t/m Juni {year}";
                    }
                    else if (radioBtnQ3.Checked)
                    {
                        maxMinDate[0] = System.DateTime.ParseExact($"01-07-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        maxMinDate[1] = System.DateTime.ParseExact($"30-09-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        lblMaanden.Text = $"Juli t/m September {year}";
                    }
                    else if (radioBtnQ4.Checked)
                    {
                        maxMinDate[0] = System.DateTime.ParseExact($"01-10-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        maxMinDate[1] = System.DateTime.ParseExact($"31-12-{year}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        lblMaanden.Text = $"Oktober t/m December {year}";
                    }
                    vatCalculation = vatCalculationService.GetVAT(maxMinDate);
                }
                //set btw tarieven
                lblLaagTariefResultaat.Text = $"€{vatCalculation.LowTariff:0.00}";
                lblHoogTariefResultaat.Text = $"€{vatCalculation.HighTariff:0.00}";
                lblTotaalTariefResultaat.Text = $"€{vatCalculation.TotalTariff:0.00}";

                //set aantal verkochte dranken
                lblLaagTariefAantalResultaat.Text = $"{vatCalculation.AmountLowTariff}";
                lblHoogTariefAantalResultaat.Text = $"{vatCalculation.AmountHighTariff}";
                lblTotaalTariefAantalResultaat.Text = $"{vatCalculation.AmountTotalTariff}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearVAT();
        }
        private void ClearVAT()
        {
            //set btw tarieven op 0
            lblLaagTariefResultaat.Text = "€0,00";
            lblHoogTariefResultaat.Text = "€0,00";
            lblTotaalTariefResultaat.Text = "€0,00";

            //set aantal verkochte dranken op 0
            lblLaagTariefAantalResultaat.Text = "0";
            lblHoogTariefAantalResultaat.Text = "0";
            lblTotaalTariefAantalResultaat.Text = "0";
        }
        //Tot hier is BTW berekenen
>>>>>>> Stashed changes
    }
}
