namespace Calculator
{
    public class Calculator
    {
        // Define the property of answer
        public double answer { get; set; }
        // Addition Method
        public double Add(double first, double second)
        {
            this.answer = (first + second);
            return this.answer;
        }
        // Subtraction Method
        public double Subtract(double first, double second)
        {
            this.answer = (first - second);
            return this.answer;
        }
        // Multiplication Method
        public double Multiply(double first, double second)
        {
            this.answer = (first * second);
            return this.answer;
        }
        // Division Method
        public double Divide(double first, double second)
        {
            this.answer = (first / second);
            return this.answer;
        }
    }
}
