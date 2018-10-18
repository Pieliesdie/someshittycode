namespace Task3
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }

    public class ArithmeticalProgression : IIndexableSeries
    {
        double start, step;
        int currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 0;
        }

        public double GetCurrent()
        {
            return start + step * currentIndex;
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

        public double this[int index]
        {
            get
            {
                return start + step * index;
            }
        }
    }

    public class List : ISeries
    {
        private double[] series;
        private int currentIndex;

        public List(double[] series)
        {
            this.series = series;
            currentIndex = 0;
        }

        public double GetCurrent()
        {
            return series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public double this[int index] => series[index % series.Length];
    }

    public interface IIndexable
    {
        double this[int index] { get; }
    }
    interface IIndexableSeries : IIndexable, ISeries { }
}
