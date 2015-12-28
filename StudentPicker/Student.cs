using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPicker
{
    class Student
    {
        private String firstName, lastName;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private int weight;
        private bool selected;

        public bool IsSelected
        {
            get { return selected; }
        }

        public void Select() { selected = true; }
        public void Deselect() { selected = false; }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public Student(String fn, String ln, int weight)
        {
            firstName = fn;
            lastName = ln;
            this.weight = weight;
            selected = false;
        }

        public Student(String fn, String ln, int weight, bool isSelected)
        {
            firstName = fn;
            lastName = ln;
            this.weight = weight;
            this.selected = isSelected;
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
