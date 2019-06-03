using System;

namespace CircleApp
{
    class Circle
    {
        private float _radius;
        private const float PI = 3.14f;

        public Circle() { }
        public Circle(float radius) {
            _radius = radius;
        }

        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public float CalArea()
        {
            return (float)(PI * Math.Pow(_radius, 2));
        }
    }
}
