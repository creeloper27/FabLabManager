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
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblCourseName;
        private Label lblPlace;
        private Label lblDescription;
        private Label lblCredits;
        private Label lblTeacher;
        private TextBox txtCourseName;
        private TextBox txtPlace;
        private TextBox txtCredits;
        private TextBox txtTeacher;
        private Button btnAddCourse;
        private Button btnReturn;
        private TextBox txtDescription;
        private TableLayoutPanel tableLayoutPanel1;

        public Courses()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.lblCourseName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPlace, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCredits, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTeacher, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtCourseName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPlace, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCredits, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTeacher, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(414, 348);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(3, 4);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(76, 13);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course\'s name";
            // 
            // lblPlace
            // 
            this.lblPlace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(3, 26);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(34, 13);
            this.lblPlace.TabIndex = 1;
            this.lblPlace.Text = "Place";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(3, 70);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "Credits";
            // 
            // lblTeacher
            // 
            this.lblTeacher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(3, 92);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(57, 13);
            this.lblTeacher.TabIndex = 4;
            this.lblTeacher.Text = "Teacher/s";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseName.Location = new System.Drawing.Point(127, 3);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(284, 20);
            this.txtCourseName.TabIndex = 5;
            this.txtCourseName.MouseHover += new System.EventHandler(this.txtCourseName_MouseHover);
            // 
            // txtPlace
            // 
            this.txtPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlace.Location = new System.Drawing.Point(127, 25);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(284, 20);
            this.txtPlace.TabIndex = 6;
            this.txtPlace.MouseHover += new System.EventHandler(this.txtPlace_MouseHover);
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(127, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // txtCredits
            // 
            this.txtCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCredits.Location = new System.Drawing.Point(127, 69);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(284, 20);
            this.txtCredits.TabIndex = 8;
            this.txtCredits.MouseHover += new System.EventHandler(this.txtCredits_MouseHover);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeacher.Location = new System.Drawing.Point(127, 91);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(284, 20);
            this.txtTeacher.TabIndex = 9;
            this.txtTeacher.MouseHover += new System.EventHandler(this.txtTeacher_MouseHover);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddCourse, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReturn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 376);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(420, 44);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCourse.Location = new System.Drawing.Point(273, 3);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(69, 38);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.Location = new System.Drawing.Point(348, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(69, 38);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Courses
            // 
            this.ClientSize = new System.Drawing.Size(426, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }

        private void txtCourseName_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtCourseName, "Enter course's name.");
        }

        private void txtPlace_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtPlace, "Enter where the course takes place.");
        }

        

        private void txtCredits_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtCredits, "Enter amount of necessary credits for this course.");
        }

        private void txtTeacher_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtTeacher, "Enter course's teacher/s.");
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtDescription, "Enter a description.");
        }

    }
}
