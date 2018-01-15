namespace Calculator
{
    public class Calculator
    {
        public double answer {get; set;}
        public double Add (double first, double second) 
        {
            this.answer = (first+second);
            return this.answer;
        }
    }
}
