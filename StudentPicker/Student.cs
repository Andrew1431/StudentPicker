﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPicker
{
    class Student
    {
        private String firstName, lastName;
        private float weight;
        private bool selected;

        public bool IsSelected
        {
            get { return selected; }
        }

        public void Select() { selected = true; }
        public void Deselect() { selected = false; }

        public float Weight
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

        public Student(String fn, String ln)
        {
            firstName = fn;
            lastName = ln;
            weight = 1f;
            selected = false;
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
