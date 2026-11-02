using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._4
{
    internal class Box : Idimensions, IEnglishDimensions, IMetricDimensions
    {
        private float lengthInches;
        private float widthInches;

        public Box(float length, float width)
        {
            lengthInches = length;
            widthInches = width;
        }

        public float Length()
        {
            return lengthInches;
        }

        public float Width()
        {
            return widthInches;
        }

        float IEnglishDimensions.Length()
        {
            return lengthInches;
        }

        float IEnglishDimensions.Width()
        {
            return widthInches;
        }

        float IMetricDimensions.Length()
        {
            return lengthInches * 2.54f;
        }

        float IMetricDimensions.Width()
        {
            return widthInches * 2.54f;
        }
    }
}
