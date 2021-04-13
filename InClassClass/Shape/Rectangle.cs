using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Rectangle
    {
/*        private double _Width;
        public double GetWidth()
        {
            return _Width;
        }
        public void SetWidth(double width)
        {
            _Width = width;
        }*/
        public double Length { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Overloaded construct where we know what vlaues we want to statet the with adn lenght to
        /// </summary>
        /// <param name="width">Width of this rectangle</param>
        /// <param name="lenght">Lengthof recntangle</param>
        public Rectangle(double width, double lenght)
        {
            this.Width = width;
            Length = lenght;
        }

        //ctor
        /// <summary>
        /// Default/Empthy construcor that sets this instane of a Rectangel to starting vluses
        /// </summary>
        public Rectangle()
        {
            Width = 5;
            Length = 5;
        }

        //CalculateArea(w:double l:double)
        /// <summary>
        /// Calcualtes the Area of this Rectnagle 
        /// </summary>
        /// <returns>The area of this Rectangle</returns>
        public double CalculateArea()
        {
            return Width * Length;
        }

        /// <summary>
        /// Calculates the Perimter of this Rectangle 
        /// </summary>
        /// <returns>The perimeter of this Rectnagle </returns>
        public double CalculatePerimeter()
        {
            return 2*(Length + Width);
        }
    }
}
