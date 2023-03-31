class C3Q30
{
    static void Main(string[] args)
    {
        // declaring variables
        int num1;
        int num2;
        int num3;
        int num4;
        int num5;

        // declaring variables to store the value of how many numbers are zero, positive and negative
        int zero = 0;
        int positive = 0;
        int negative = 0;

        // prompting user and taking input for num1
        Console.Write("Enter First Number:  ");
        num1 = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for num2
        Console.Write("Enter Second Number:  ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for num3
        Console.Write("Enter Third Number:  ");
        num3 = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for num4
        Console.Write("Enter Fourth Number:  ");
        num4 = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for num5
        Console.Write("Enter Fifth Number:  ");
        num5 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // checking if the number1 is zero, positive or negative
        if (num1 == 0)
        {
            zero = zero + 1;
        }

        else if (num1 > 0)
        {
            positive = positive + 1;
        }
        
        else if (num1 < 0)
        {
            negative = negative + 1;
        }

        // checking if the number2 is zero, positive or negative
        if (num2 == 0)
        {
            zero = zero + 1;
        }

        else if (num2 > 0)
        {
            positive = positive + 1;
        }

        else if (num2 < 0)
        {
            negative = negative + 1;
        }

        // checking if the number3 is zero, positive or negative
        if (num3 == 0)
        {
            zero = zero + 1;
        }

        else if (num3 > 0)
        {
            positive = positive + 1;
        }

        else if (num3 < 0)
        {
            negative = negative + 1;
        }

        // checking if the number4 is zero, positive or negative
        if (num4 == 0)
        {
            zero = zero + 1;
        }

        else if (num4 > 0)
        {
            positive = positive + 1;
        }

        else if (num4 < 0)
        {
            negative = negative + 1;
        }

        // checking if the number4 is zero, positive or negative
        if (num5 == 0)
        {
            zero = zero + 1;
        }

        else if (num5 > 0)
        {
            positive = positive + 1;
        }

        else if (num5 < 0)
        {
            negative = negative + 1;
        }

        // printing how many numbers are zeros
        Console.WriteLine("Number Of Zeros In Entered Numbers Are:  " + zero);

        // printing how many numbers are positive
        Console.WriteLine("Number Of Positive Numbers In Entered Numbers Are:  " + positive);

        // printing how many numbers are negative
        Console.WriteLine("Number Of Negative Numbers In Entered Numbers Are:  " + negative);
    }
}
