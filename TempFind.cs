// Creator: Ryder Held
// Date: 1/27/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculator
{
    public  class TempFind
    {
        // Variables
        private double fahrenheit = -99999.9;

        // Gets and sets
        public double Fahrenheit
        {
            get { return this.fahrenheit; }
            set { this.fahrenheit = value; }
        }

        // Methods
        public double FahToCel()
        {
            double celcius = (this.Fahrenheit - 32) * (5.0 / 9.0);
            return celcius;
        }
        public double FahToKel()
        {
            double kelvin = (this.Fahrenheit - 32) * (5.0 / 9.0) + 273.15;
            return kelvin;
        }
        public double FahToRan()
        {
            double rankine = this.Fahrenheit + 459.67;
            return rankine;
        }
    }
}
