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
            this.WindowState = FormWindowState.Maximized;
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
                pnlBtwOphalen.Hide();
                pnlSupply.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

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
                pnlBtwOphalen.Hide();
                pnlSupply.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

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
                pnlBtwOphalen.Hide();
                pnlSupply.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

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
                pnlBtwOphalen.Hide();
                pnlSupply.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

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
                pnlBtwOphalen.Hide();
                pnlSupply.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

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
                        li.SubItems.Add(a.Description);
                        li.SubItems.Add(a.StartTime.ToString());
                        li.SubItems.Add(a.EndTime.ToString());
                        listViewActivities.Items.Add(li);
                    }

                    listViewActivities.Focus();
                    listViewActivities.Items[0].Selected = true;
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
                pnlBtwOphalen.Hide();
                pnlSupply.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

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
            else if (panelName == "BtwOphalen")
            {
                //hide alle panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

                //show btw panel
                pnlBtwOphalen.Show();
                try
                {
                    ClearVAT();
                }
                catch (Exception)
                {

                    throw;
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
                pnlBtwOphalen.Hide();
                Omzetrapportage.Hide();
                Kassa.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();

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
            else if (panelName == "Kassa")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();
                pnlBtwOphalen.Hide();
                Supervisors.Hide();
                pnlActivityParticipants.Hide();


                //Show Kassa
                Kassa.Show();
                try
                {
                    DrinkService drinkService = new DrinkService(); ;
                    List<Drink> drinkList = drinkService.GetDrinks(); ;

                    listViewDrink.Items.Clear();
                    foreach (Drink drink in drinkList)
                    {
                        ListViewItem li = new ListViewItem(drink.Number.ToString());
                        li.SubItems.Add(drink.Name);
                        li.SubItems.Add(drink.Price.ToString("€0.00"));
                        listViewDrink.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the kassa: " + e.Message);
                }

            }
            else if (panelName == "pnlActivityParticipants")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();
                pnlBtwOphalen.Hide();
                pnlActivities.Hide();

                //Show Activity Participants
                pnlActivityParticipants.Show();
                try
                {

                    ActivityService activityService = new ActivityService();
                    List<Activity> activities = activityService.GetActivities();
                    listViewActivitiesAP.Items.Clear();
                    foreach  (Activity activity in activities)
                    {
                        ListViewItem listViewItem = new ListViewItem(activity.Id.ToString());
                        listViewItem.SubItems.Add(activity.Name);
                        listViewActivitiesAP.Items.Add(listViewItem);
                    }
                    listViewActivitiesAP.SelectedItems.Clear();

                    StudentService studentService = new StudentService();
                    List<Student> students = studentService.GetStudents();
                    listViewAPallStudents.Items.Clear();
                    foreach (Student student in students)
                    {
                        ListViewItem listViewItem = new ListViewItem(student.Number.ToString());
                        listViewItem.SubItems.Add(student.Name);
                        listViewAPallStudents.Items.Add(listViewItem);
                    }
                    listViewAPallStudents.Focus();
                    listViewAPallStudents.Items[0].Selected = true;

                    listViewActivitiesAP.Focus();
                    listViewActivitiesAP.Items[0].Selected = true;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the kassa: " + e.Message);
                }
            }
            else if (panelName == "Supervisors")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlActivities.Hide();
                Omzetrapportage.Hide();
                pnlSupply.Hide();
                pnlBtwOphalen.Hide();
                Kassa.Hide();
                
                Supervisors.Show();
                try
                {
                    // fill the Activities listview within the activities panel with a list of activities
                    ActivityService actService = new ActivityService();
                    List<Activity> activitieList = actService.GetActivities();

                    // clear the listview before filling it again
                    listActivity.Items.Clear();

                    //fill listview
                    foreach (Activity a in activitieList)
                    {
                        ListViewItem li = new ListViewItem(a.Id.ToString());
                        li.SubItems.Add(a.Name);                        
                        listActivity.Items.Add(li);
                    }
                    // fill the teachers listview within the students panel with a list of students
                    TeacherService teacherService = new TeacherService(); ;
                    List<Teacher> teacherList = teacherService.GetTeachers(); ;

                    // clear the listview before filling it again
                    listViewSupervisors.Items.Clear();
                    //fill listview
                    foreach (Teacher teacher in teacherList)
                    {
                        ListViewItem li = new ListViewItem(teacher.Number.ToString());
                        li.SubItems.Add(teacher.Name);
                        li.SubItems.Add(teacher.Activity.ToString());
                        listViewSupervisors.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the revenue: " + e.Message);
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
        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supplies");
        }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Kassa");
        }
        private void bTWBerekenenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("BtwOphalen");
        }

        private void CalculateRevenue_Click(object sender, EventArgs e)
        {
            listViewRevenue.Items.Clear();
            try
            {
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

        //Vanaf hier is BTW berekenen
        private void btnToonBTW_Click_1(object sender, EventArgs e)
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

        private void btnReset_Click_1(object sender, EventArgs e)
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

        //Vanaf hier is drankvoorraad


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
            Supervisors.Hide();
            Kassa.Hide();
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
                MessageBox.Show("Something went wrong while loading the drinks: " + i.Message);
            }
        }
        //Tot hier is drankvoorraad

        //Tot hier is drankvoorraad

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void BtnGetSelectedActivity_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewActivities.SelectedItems!= null)
                {
                    ActivityService actService = new ActivityService();

                    foreach (ListViewItem li in listViewActivities.SelectedItems)
                    {
                        Activity activity = actService.GetById(li.Text);
                        TbActivityID.Text = activity.Id.ToString();
                        TbActivityName.Text = activity.Name;
                        TbActivityDiscription.Text = activity.Description;
                        McActivityStartTime.SetDate(activity.StartTime);
                        McActivityEndTime.SetDate(activity.EndTime);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an activity");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + E.Message);
            }
        }


        private void supervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            int LId = int.Parse(LecturerIdTextBox.Text);
            int AId = int.Parse(ActivityIdTextBox.Text);

            Supervisor supervisor = new Supervisor(LId, AId);
            SupervisorService supervisorService = new SupervisorService();
            supervisorService.AddSupervisor(supervisor);            
            MessageBox.Show("Supervisor succesfully added.");
        }

        private void btnDeleteSupervisor_Click(object sender, EventArgs e)
        {
            int LId = int.Parse(LIdtextBox.Text);
            int AId = int.Parse(AIdTextBox.Text);

            Supervisor supervisor = new Supervisor(LId, AId);
            SupervisorService supervisorService = new SupervisorService();
            supervisorService.DeleteSupervisor(supervisor);
            MessageBox.Show("Supervisor succesfully deleted.");

        private void BtnActivityUpdate_Click(object sender, EventArgs e)
        {
            Activity updatedActivity = new Activity
            {
                Id = int.Parse(TbActivityID.Text),
                Name = TbActivityName.Text,
                Description = TbActivityDiscription.Text,
                StartTime = Convert.ToDateTime(McActivityStartTime.SelectionRange.Start.ToString()),
                EndTime = Convert.ToDateTime(McActivityEndTime.SelectionRange.Start.ToString())
            };
            ActivityService actService = new ActivityService();
            List<Activity> activities = actService.GetActivities();

            if (activities.Any(a => a.Id == updatedActivity.Id))
            {
                if (updatedActivity.StartTime <= updatedActivity.EndTime)
                {
                    if (System.DateTime.Today <= updatedActivity.StartTime && System.DateTime.Today <= updatedActivity.EndTime)
                    {
                        actService.UpdateActivity(updatedActivity);
                        showPanel("Activities");
                    }
                    else
                    {
                        MessageBox.Show("Activity can't be in the past");
                    }
                }
                else
                {
                    MessageBox.Show("Start time is before end time");
                }
            }
            else
            {
                MessageBox.Show($"the selected activity id ({updatedActivity.Id}) does not exist please check again or use create new activity");
            }
        }

        private void BtnCreateActivity_Click(object sender, EventArgs e)
        {
            Activity newActivity = new Activity
            {
                Id = int.Parse(TbActivityID.Text),
                Name = TbActivityName.Text,
                Description = TbActivityDiscription.Text,
                StartTime = Convert.ToDateTime(McActivityStartTime.SelectionRange.Start.ToString()),
                EndTime = Convert.ToDateTime(McActivityEndTime.SelectionRange.Start.ToString())
            };
            ActivityService actService = new ActivityService();
            List<Activity> activities = actService.GetActivities();
            if (!activities.Any(a => a.Name == newActivity.Name))
            {
                if (!activities.Any(a => a.Id == newActivity.Id))
                {
                    if (newActivity.StartTime <= newActivity.EndTime)
                    {
                        if (System.DateTime.Today <= newActivity.StartTime && System.DateTime.Today <= newActivity.EndTime)
                        {
                            actService.InserActivity(newActivity);
                            showPanel("Activities");
                        }
                        else
                        {
                            MessageBox.Show("Activity can't be in the past");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Start time is before end time");
                    }
                }
                else
                {
                    MessageBox.Show($"An activity with id: {newActivity.Id} already exist");
                }
            }
            else
            {
                MessageBox.Show($"An activity with name: {newActivity.Name} already exist");
            }
        }

        private void BtnDeleteActivity_Click(object sender, EventArgs e)
        {
            Activity deleteActivity = new Activity
            {
                Id = int.Parse(TbActivityID.Text),
                Name = TbActivityName.Text,
                Description = TbActivityDiscription.Text,
                StartTime = Convert.ToDateTime(McActivityStartTime.SelectionRange.Start.ToString()),
                EndTime = Convert.ToDateTime(McActivityEndTime.SelectionRange.Start.ToString())
            };

            ActivityService actService = new ActivityService();
            List<Activity> activities = actService.GetActivities();
            if (activities.Any(a => a.Id == deleteActivity.Id))
            {
                
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {deleteActivity.Name}?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    actService.DeleteActivity(deleteActivity);
                    showPanel("Activities");
                }
            }
            else
            {
                MessageBox.Show($"the selected activity ({deleteActivity.Name}) with id ({deleteActivity.Id}) does not exist please use get selected activity");
            }
        }

        private void participatingStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("pnlActivityParticipants");
        }

        private void btnShowAP_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewActivitiesAP.SelectedItems != null)
                {
                    listViewActivitiesAPResult.Items.Clear();
                    StudentService studentService = new StudentService();
                    List<Student> students = studentService.GetStudentNamesAndActivities(int.Parse(listViewActivitiesAP.SelectedItems[0].Text));

                    foreach (Student student in students)
                    {
                        ListViewItem item = new ListViewItem(student.Number.ToString());
                        item.SubItems.Add(student.Name);
                        listViewActivitiesAPResult.Items.Add(item);
                    }
                    //listViewActivitiesAPResult.Focus();
                    //listViewActivitiesAPResult.Items[0].Selected = true;
                }

                else
                {
                    throw new Exception("Please select an activity.");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Something went wrong while listing the students: " + exception.Message);
            }
        }

        private void btnAddStudentToActivity_Click(object sender, EventArgs e)
        {
            try
            {
                StudentService studentService = new StudentService();
                studentService.UpdateStudentActivity(int.Parse(listViewActivitiesAP.SelectedItems[0].Text), int.Parse(listViewAPallStudents.SelectedItems[0].Text));
            }
            catch (Exception exception)
            {

                MessageBox.Show("Something went wrong while updating the student: " + exception.Message);
            }
        }

        private void btnRemoveParticipantFromActivity_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure that you wish to remove this participant?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (listViewActivitiesAPResult.SelectedItems != null)
                    {
                        StudentService studentService = new StudentService();
                        if (listViewActivitiesAPResult.Items.Count != 0)
                        {
                            studentService.RemoveStudentActivity(int.Parse(listViewActivitiesAPResult.SelectedItems[0].Text));
                        }
                    }
                    else
                    {
                        throw new Exception("Please select a student from the right listview.");
                    }
                    showPanel("pnlActivityParticipants");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Something went wrong while removing the student: " + exception.Message);
            }

        }
    }
}
