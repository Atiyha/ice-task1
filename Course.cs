using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_1
{
    internal class Course
    {
        private int _grade;

        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 and 100.");
                _grade = value;
            }
        }

        public bool IsPass => _grade >= 50;
    }
}