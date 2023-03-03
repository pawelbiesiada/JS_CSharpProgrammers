using System;
using System.Data.Entity;
using System.Text;
using System.Windows.Forms;

namespace WinFormsSample
{
    public partial class Form1 : Form
    {
        private TestSchoolScriptEntities _ctx;
        private Action<bool> onGridLoadedAction;

        public Form1()
        {
            InitializeComponent();
            onGridLoadedAction = isLoaded => { btnSave.Enabled = isLoaded; };
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _ctx = new TestSchoolScriptEntities();
                _ctx.Students.Load();
                this.studentBindingSource.DataSource = _ctx.Students.Local.ToBindingList();
                onGridLoadedAction(true);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception.Message}\n\n{exception.StackTrace}");
                MessageBox.Show(exception.StackTrace, "Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ctx == null)
                return;

            try
            {
                _ctx.SaveChanges();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception.Message}\n\n{exception.StackTrace}");
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdUsers.Rows.Clear();
            _ctx?.Dispose();
            onGridLoadedAction(false);
        }

        private void GrdUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView grid))
                return;

            var row = grid.Rows[e.RowIndex]; //or grid.SelectedRows;
            var studentId = (int)row.Cells[0].Value;
            var studentName = (string)row.Cells[1].Value;

            var studentDetailsForm = new FrmUserDetails(studentId, studentName);
            // await studentDetailsForm.LoadDetails();  //or
            var result = studentDetailsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show($"Student {studentDetailsForm.StudentName} details saved.");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimalizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             HideForm();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideForm();
            }
        }

        private void HideForm()
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
            //TODO
        }

        private void grdUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                if (grdUsers.SelectedRows.Count > 0)
                {
                    //here we could copy selected rows and paste them into the same grid
                }
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                if (grdUsers.SelectedRows.Count > 0)
                {
                    var copiedText = new StringBuilder();
                    foreach (DataGridViewRow row in grdUsers.SelectedRows)
                    {
                        copiedText.AppendLine($"{row.Cells[0]}   {row.Cells[1]}");
                    }

                    Clipboard.SetText(copiedText.ToString());
                }
            }
        }
    }
}
