using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPicker
{
    public partial class Form1 : Form
    {
        List<Student>[] group;
        List<Student> selected, unselected;
        Student current;
        int selectedGrade;
        public Form1()
        {
            InitializeComponent();
            group = new List<Student>[4];
            for (int i = 0; i < group.Length; i++)
            {
                group[i] = new List<Student>();
            }
            selected = new List<Student>();
            unselected = new List<Student>();
            selectedGrade = 0;
            load();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                group[selectedGrade].Remove(current);
                group[selectedGrade].Add(new Student(txtFirst.Text, txtLast.Text, trackEntries.Value));
                UpdateLists();
                Clear();
            }
            else
            {
                group[selectedGrade].Add(new Student(txtFirst.Text, txtLast.Text, trackEntries.Value));
                UpdateLists();
                Clear();
            }
            save();
        }

        private void UpdateLists()
        {
            selected.Clear();
            unselected.Clear();
            group[selectedGrade] = group[selectedGrade].OrderBy(p => p.FirstName).ToList();
            group[selectedGrade].ForEach(s =>
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

                save();
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

                save();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                group[selectedGrade].Remove(current);
                save();
                UpdateLists();
                Clear();
            }
        }

        private void newClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedGrade = 0;
            lblHeader.Text = "Grade 9 Class";
            UpdateLists();
            Clear();
        }

        private void save()
        {
            using (StreamWriter sw = new StreamWriter(String.Format("grade{0}.sfd", selectedGrade)))
            {
                group[selectedGrade].ForEach(s => {
                    sw.WriteLine(s.FirstName);
                    sw.WriteLine(s.LastName);
                    sw.WriteLine(s.Weight);
                    sw.WriteLine(s.IsSelected ? "1" : "0");
                });
            }
        }

        private void load()
        {
            for (int i = 0; i <= 3; i++)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(String.Format("grade{0}.sfd", i)))
                    {
                        group[i].Clear();
                        while (!sr.EndOfStream)
                        {
                            group[i].Add(new Student(sr.ReadLine(), sr.ReadLine(), int.Parse(sr.ReadLine()), sr.ReadLine() == "1"));
                        }
                        UpdateLists();
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("BOOM!");
                }
            }
        }

        private void grade10ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedGrade = 1;
            lblHeader.Text = "Grade 10 Class";
            UpdateLists();
            Clear();
        }

        private void grade11ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedGrade = 2;
            lblHeader.Text = "Grade 11 Class";
            UpdateLists();
            Clear();
        }

        private void grade12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedGrade = 3;
            lblHeader.Text = "Grade 12 Class";
            UpdateLists();
            Clear();
        }
    }
}
