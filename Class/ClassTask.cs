using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    class Rectangle
    {
        private double sideA;
        private double sideB;
        public Rectangle(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;
        }
        public Rectangle(double a)
        {
            this.sideA = a;
            this.sideB = 5;
        }
        public Rectangle()
        {
            this.sideA = 4;
            this.sideB = 3;
        }
        public double GetSideA()
        {
            return this.sideA;
        }
        public double GetSideB()
        {
            return this.sideB;
        }
        public double Area()
        {
            return this.sideA * this.sideB;
        }
        public double Perimeter()
        {
            return (this.sideA + this.sideB) * 2;
        }
        public bool IsSquare()
        {
            return this.sideA == this.sideB;
        }
        public void ReplaceSides()
        {
            double temp = this.sideA;
            this.sideA = this.sideB;
            this.sideB = temp;
        }
    };
    class ArrayRectangles
    {
        private Rectangle[] rectangle_array;



        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];

        }
        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
            }
            return false;

        }
        public int NumberMaxArea()
        {
            var maxVal = rectangle_array.Max();
            var indexMax = Array.IndexOf(rectangle_array, maxVal);

            return indexMax;
        }
        public int NumberMinPerimeter()
        {
            var minVal = rectangle_array.Min();
            var indexMin = Array.IndexOf(rectangle_array, minVal);

            return indexMin;
        }
        public int NumberSquare()
        {
            int squareNumber = 0;
            foreach ( var array in rectangle_array )
            {
                if (array.IsSquare())
                {
                    squareNumber++; 
                }
            }
            return squareNumber;
        }
    }
};
