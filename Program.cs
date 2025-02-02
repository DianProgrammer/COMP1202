namespace exercisewk02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the third number: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                long sum = ((long)num1 + (long)num2 + (long)num3);
                Console.WriteLine(sum);
                long avg = sum / 3;
                if (Int32.MaxValue < avg || (avg < Int32.MinValue))
                    throw new Exception();
                //throw new ArgumentException("The avg is too large");
                // avg = (n1 + n2 + n3) / 3 --> n1/3 + n2/3 +n3/3
                //When you divide integer by integer result is an integer!
                //double avg = num1/3.0 + num2/3.0 + num3/3.0
                //float can handle integer but the inetegr can not handle float 
                //console.writeline($"the result is {avg:F2}");

                Console.WriteLine(avg);

            }
            catch (OverflowException) { Console.WriteLine("The number is too big!"); }
            catch (FormatException) { Console.WriteLine("Input must be integer!"); }
            catch (ArgumentException e2) { Console.WriteLine(e2.Message); }
            {

            }
        }
    }
}
