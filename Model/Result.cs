namespace Model
{
    public class Result
    {
        string date;
        public double r1;
        public double r2;
        public double r3;
        public double r4;
        public Result(double r1, double r2, double r3, double r4, string date)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
            this.r4 = r4;
            this.date = date;
        }
    }
}
