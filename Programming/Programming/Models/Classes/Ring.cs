using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    public class Ring
    {
        private double _innerRadius;
        private double _outerRadius;
        private Point2D _center;

        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Inner radius must be a positive number.");
                }
                if (value >= OuterRadius)
                {
                    throw new ArgumentException("Inner radius must be less than outer radius.");
                }
                _innerRadius = value;
            }
        }

        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Outer radius must be a positive number.");
                }
                if (value <= InnerRadius)
                {
                    throw new ArgumentException("Outer radius must be greater than inner radius.");
                }
                _outerRadius = value;
            }
        }

        public Point2D Center
        {
            get => _center;
            private set => _center = value;
        }

        public double Area
        {
            get
            {
                double outerCircleArea = Math.PI * Math.Pow(OuterRadius, 2);
                double innerCircleArea = Math.PI * Math.Pow(InnerRadius, 2);
                return outerCircleArea - innerCircleArea;
            }
        }

        public Ring(double innerRadius, double outerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }

    }
}
