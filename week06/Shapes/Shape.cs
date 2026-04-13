using System;

namespace ShapesApp
{
    // We use 'abstract' because a generic "Shape" doesn't have a specific area formula
    public abstract class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        // Abstract method: No body here, child classes MUST implement it
        public abstract double GetArea();
    }
}