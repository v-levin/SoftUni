﻿namespace RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public string Id
        {
            get { return this.id; }
        }

        public bool IntersectsWith(Rectangle rectangle)
        {
            return rectangle.x + rectangle.width >= this.x &&
                rectangle.x <= this.x + this.width &&
                rectangle.y >= this.y - height &&
                rectangle.y - rectangle.height <= this.y;
        }
    }
}
