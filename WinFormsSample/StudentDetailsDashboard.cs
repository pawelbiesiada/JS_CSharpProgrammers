using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSample
{
    public partial class StudentDetailsDashboard : UserControl
    {
        public delegate void SaveEventHandler(object sender, SaveEventArgs saveEventArgs);
        public event SaveEventHandler Saved;

        public StudentDetailsDashboard()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();

                Saved?.Invoke(this, new SaveEventArgs(true, null));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                Saved?.Invoke(this, new SaveEventArgs(false, exception.Message));
            }
        }

        private void Save()
        {
        }
    }
}
