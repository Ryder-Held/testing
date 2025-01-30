// Creator: Ryder Held
// Date: 1/27/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculator
{
    public class a_quiz_calculator
    {
        // Variables
        private double quiz1 = -10.00;
        private double quiz2 = -10.00;
        private double quiz3 = -10.00;
        private double quiz4 = -10.00;
        // Below are not needed
        // private double total = -40.00;
        // private double average = -10.00;
        // private string letterGrade = "n/a";

        // Gets and sets
        public double Quiz1
        {
            get { return this.quiz1; }
            set
            {
                if (value is > 100.00 || value < 0.00)
                {
                    this.quiz1 = -10.00;
                }
                else
                {
                    this.quiz1 = value;
                }
            }
        }
        public double Quiz2
        {
            get { return this.quiz2; }
            set
            {
                if (value is > 100.00 || value < 0.00)
                {
                    this.quiz2 = -10.00;
                }
                else
                {
                    this.quiz2 = value;
                }
            }
        }
        public double Quiz3
        {
            get { return this.quiz3; }
            set
            {
                if (value is > 100.00 || value < 0.00)
                {
                    this.quiz3 = -10.00;
                }
                else
                {
                    this.quiz3 = value;
                }
            }
        }
        public double Quiz4
        {
            get { return this.quiz4; }
            set
            {
                if (value is > 100.00 || value < 0.00)
                {
                    this.quiz4 = -10.00;
                }
                else
                {
                    this.quiz4 = value;
                }
            }
        }

        // Methods
        public double CalcTotal()
        {
            double aTotal = 0.0;
            aTotal = Quiz1 + Quiz2 + Quiz3 + Quiz4;
            return aTotal;
        }

        public double CalcAverage()
        {
            double aAverage = 0.0;
            aAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) / 4;
            return aAverage;
        }
        public string CalcLetterGrade()
        {
            double aAverage = 0.0;
            string aLetterGrade = "n/a";
            aAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) / 4;
            if(aAverage >= 0.00 && aAverage < 60.00)
            {
                aLetterGrade = "F";
            }
            if (aAverage >= 60.00 && aAverage < 70.00)
            {
                aLetterGrade = "D";
            }
            if (aAverage >= 70.00 && aAverage < 80.00)
            {
                aLetterGrade = "C";
            }
            if (aAverage >= 80.00 && aAverage < 90.00)
            {
                aLetterGrade = "B";
            }
            if (aAverage >= 90.00 && aAverage <= 100.00)
            {
                aLetterGrade = "A";
            }
            return aLetterGrade;
        }
    }
}
