using System;

    class OddEvenSum
{
    static void Main()
    {   
        int n = int.Parse(Console.ReadLine());
        long oddSum = 0;
        long evenSum = 0;
        for (int i = 0; i < n; i++)
        {
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());
                oddSum += number1;
                evenSum += number2;
        }
        if (evenSum==oddSum)
        {
            Console.WriteLine("Yes, sum={0}",evenSum);
        }
        else
        {
            if (oddSum>evenSum)
            {
                Console.WriteLine("No, diff={0}",oddSum-evenSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", evenSum-oddSum);
            }
        }
    }
}

   

           
           
       
