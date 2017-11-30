using MsSeed.Lib.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var msStephanie = new Teacher()
            {
                Name = "Ms. Stephanie"
            };

            msStephanie.Dances.Add(new Dance() {
                Name = "Game of Shadows"
            });


            msStephanie.Dances.Add(new Dance()
            {
                Name = "Taxi"
            });

            msStephanie.Dances.Add(new Dance()
            {
                Name = "Team"
            });


            msStephanie.Save("../../stephanie.json");
        }
    }
}
