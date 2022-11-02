Console.WriteLine($"Enter the sum of the array:");
double inputSum = double.Parse(Console.ReadLine());
double[] arr1 = {1,2,3,4};

static double ArrSum(double[] arr){
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}
    if (inputSum == ArrSum(arr1)) {
        Console.WriteLine($"Your input equals the sum of the array.");
    }
    else {
        Console.WriteLine($"Your input does not equal the sum of the array.");
    }
