using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPicker
{
    public partial class Form1 : Form
    {
        List<Student> group, selected, unselected;
        Student current;
        public Form1()
        {
            InitializeComponent();
            group = new List<Student>();
            selected = new List<Student>();
            unselected = new List<Student>();
            lstSelected.DataSource = selected;
            lstUnselected.DataSource = unselected;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            group.Add(new Student(txtFirst.Text, txtLast.Text));
            UpdateLists();
            Clear();
        }

        private void UpdateLists()
        {
            selected.Clear();
            unselected.Clear();
            group.ForEach(s =>
            {
                if (s.IsSelected)
                {
                    selected.Add(s);
                }
                else
                {
                    unselected.Add(s);
                }
            });
        }
        private void Clear()
        {
            txtFirst.Text = "";
            txtLast.Text = "";
        }
    }
}
