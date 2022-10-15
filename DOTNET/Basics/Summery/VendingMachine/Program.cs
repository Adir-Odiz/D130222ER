class Program
{
    static void getChange(double m, double p)
    {
        if (m < p)
        {
            throw new ArithmeticException("insufficient funds.");
        }
        else calcChange(m, p);
    }
    static void calcChange(double m, double p)
    {
        double change = Math.Round(m - p, 3);
        int[] changeArr = { 0, 0, 0, 0, 0, 0 };

        System.Console.WriteLine(Math.Round(change, 3));

        if (change >= 1)
        {
            changeArr[5] = Convert.ToInt32(Math.Truncate((change)*1d)); // ???
            change = Math.Round(change - Math.Truncate((change)*1d), 3);
        }
        if (change >= 0.5)
        {
            changeArr[4] = 1;
            change = Math.Round(change - 0.5, 3);
        }
        if (change >= 0.25)
        {
            changeArr[3] = 1;
            change = Math.Round(change - 0.25, 3);
        }
        if (change >= 0.1)
        {
            changeArr[2] = Convert.ToInt32(Math.Floor(change * 10));
            change = Math.Round(change - Math.Floor(change * 10) / 10, 3);
        }
        if (change >= 0.05)
        {
            changeArr[1] = 1;
            change = Math.Round(change - 0.05, 3);
        }
        if (change >= 0.01)
        {
            changeArr[0] = Convert.ToInt32(change*100);
        }



        void printArr(int[] arr)
        {
            System.Console.Write("[");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                System.Console.Write($"{arr[i]},");
            }
            System.Console.WriteLine(arr[5] + "]");
        }
        printArr(changeArr);
    }


    static void Main(string[] args)
    {
        getChange(5, 0.99); // should return [1,0,0,0,0,4]
        getChange(3.14, 1.99); // should return [0,1,1,0,0,1] 
        getChange(3, 0.01); // should return [4,0,2,1,1,2] 
        getChange(4, 3.14); // should return [1,0,1,1,1,0] 
        getChange(0.45, 0.34); // should return [1,0,1,0,0,0]
    }
}