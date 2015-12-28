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
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                group.Remove(current);
                group.Add(new Student(txtFirst.Text, txtLast.Text, trackEntries.Value));
                UpdateLists();
                Clear();
            }
            else
            {
                group.Add(new Student(txtFirst.Text, txtLast.Text, trackEntries.Value));
                UpdateLists();
                Clear();
            }
        }

        private void UpdateLists()
        {
            selected.Clear();
            unselected.Clear();
            group = group.OrderBy(p => p.FirstName).ToList();
            group.ForEach(s =>
            {
                if (s.IsSelected)
                {
                    for (int i = 0; i < s.Weight; i++)
                    {
                        selected.Add(s);
                    }
                }
                else
                {
                    unselected.Add(s);
                }
            });

            lstSelected.DataSource = selected.ToArray();
            lstUnselected.DataSource = unselected.ToArray();
        }
        private void Clear()
        {
            current = null;
            txtFirst.Text = "";
            txtLast.Text = "";
            trackEntries.Value = 1;
        }

        private void updateFields()
        {
            txtFirst.Text = current.FirstName;
            txtLast.Text = current.LastName;
            trackEntries.Value = current.Weight;
        }

        private void lstUnselected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox b = (ListBox)sender;
            current = unselected[b.SelectedIndex];

            updateFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Select();
                current.Weight = trackEntries.Value;

                UpdateLists();
                Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Deselect();
                current.Weight = trackEntries.Value;

                UpdateLists();
                Clear();
            }
        }

        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox b = (ListBox)sender;
            current = selected[b.SelectedIndex];

            updateFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateLists();
            Clear();
        }

        private void trackEntries_ValueChanged(object sender, EventArgs e)
        {
            lblEntries.Text = String.Format("Entries: {0}", trackEntries.Value);
        }
    }
}
