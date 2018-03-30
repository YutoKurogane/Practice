namespace Cs3Method
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}