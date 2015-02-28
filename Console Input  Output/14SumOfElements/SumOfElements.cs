using System;

    class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nums = input.Split(' ');
        Biginteger sum = 0;
        BigInteger diff = 0;
        bool isTrue = false;
        for (int i = 0; i < nums.Length; i++)
        {
            int num = int.Parse(nums[i]);
            sum += num;
        }
        diff = sum;
 
        for (int i = 0; i < nums.Length; i++)
        {
            if (sum / 2 == int.Parse(nums[i]) && sum % 2 == 0)
            {
                Console.WriteLine("Yes, sum={0}", sum / 2);
                isTrue = true;
                break;
            }
            else
            {
                BigInteger checkSum = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    else
                    {
                        checkSum += int.Parse(nums[j]);
                    }
                }
               
                if (diff > checkSum - int.Parse(nums[i]))
                {
                    diff = checkSum - int.Parse(nums[i]);
                }
            }
 
 
        }

        if (!isTrue)
        {
            Console.WriteLine("No, diff={0}", Math.Abs((decimal)diff));
        }
    }
}

