using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSample
{
    public partial class FrmUserDetails : Form
    {
        private readonly int _studentId;
        private bool _areDetailsLoaded;
        public string StudentName { get; }
        private FrmUserDetails()
        {
            InitializeComponent();
        }

        public FrmUserDetails(int id, string name) :this()
        {
            _studentId = id;
            StudentName = name;
            lblUserId.Text = $"{id}   {name}";
        }



        public async Task LoadDetails()
        {
            using (var ctx = new TestSchoolScriptEntities())
            {
                var student = await ctx.Students.SingleAsync(el => el.StudentID == _studentId);
                await Task.Delay(1000);
                var studentAddress = student.StudentAddress;

                txbAddress1.Text = studentAddress?.Address1;
                txbAddress2.Text = studentAddress?.Address2;
                txbCity.Text = studentAddress?.City;
                txbState.Text = studentAddress?.State;

                await Task.Delay(5000);
                await ctx.Courses.LoadAsync();
                clbCourses.DataSource = ctx.Courses.Local.ToBindingList();
                clbCourses.DisplayMember = "CourseName";

                for (int i = 0; i < clbCourses.Items.Count; i++)
                {
                    var course = clbCourses.Items[i];
                    if (student.Courses.Contains(course))
                    {
                        clbCourses.SetItemCheckState(i, CheckState.Checked);
                    }
                }

                _areDetailsLoaded = true;
            }
        }



        private async void BtnSave_Click(object sender, EventArgs e)
        {
            //Save results
            var isSaved = await SaveResults(_studentId);

            if (!isSaved) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async Task<bool> SaveResults(int id)
        {
            var result = true;
            try
            {
                using (var ctx = new TestSchoolScriptEntities())
                {
                    var student = await ctx.Students.SingleAsync(el => el.StudentID == id);
                    if (student.StudentAddress == null)
                    {
                        student.StudentAddress = new StudentAddress();
                    }
                    var studentAddress = student.StudentAddress;

                    studentAddress.Address1 = txbAddress1.Text;
                    studentAddress.Address2 = txbAddress2.Text;
                    studentAddress.City = txbCity.Text;
                    studentAddress.State = txbState.Text;

                    var chosenCourses = clbCourses.CheckedItems.Cast<Course>();
                    student.Courses.Clear();
                    foreach (var chosenCourse in chosenCourses)
                    {
                        var contextCourse = ctx.Courses.SingleOrDefault(c => c.CourseId == chosenCourse.CourseId);
                        if (contextCourse == null)
                        {
                            continue;
                        }

                        student.Courses.Add(contextCourse);
                    }

                    await ctx.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.Message, "Saving error.");

                result = false;
            }

            return result;
        }

        private async void FrmUserDetails_Load(object sender, EventArgs e)
        {
            if (!_areDetailsLoaded)
            {
                await LoadDetails();
            }
        }
    }
}
