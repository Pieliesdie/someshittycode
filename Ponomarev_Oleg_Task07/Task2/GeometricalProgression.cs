using DemoApplication;
using System;

namespace Task2
{
    class GeometricalProgression:ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricalProgression(double start,double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 0;
        }
        public double GetCurrent()
        {
            return start * Math.Pow(step,currentIndex);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}
