namespace _2m_14_Figura
{
    abstract class Figura
    {
        protected string nazwa;
        public abstract double pole { get; }
        public abstract double obwod { get; }
        public Figura(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public override string ToString()
        {
            return $"{nazwa}; obw: {obwod}; pole: {pole}";
        }
    }
    class Prostokat : Figura
    {
        private double bokA, bokB;
        public override double pole { get { return bokA * bokB; } }
        public override double obwod { get { return 2 * (bokA + bokB); } }
        public Prostokat(string nazwa, double bokA, double bokB) : base(nazwa)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }
        public override string ToString()
        {
            return $"{nazwa} bok A: {bokA}; bok B: {bokB}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Prostokat p1 = new Prostokat("prostokąt", 4, 5);
            Console.WriteLine(p1);

        }
    }
}