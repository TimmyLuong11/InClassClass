using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Circle
    {
        public double Radius { get; set; }

        /// <summary>
        /// Default/Emptoy constures settign our progmram 
        /// </summary>
        public Circle()
        {
            Radius = 0;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
