using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FabLabManager
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Courses
            // 
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Name = "Courses";
            this.ResumeLayout(false);

        }
    }
}
