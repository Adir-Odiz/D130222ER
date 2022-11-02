int[] arr1 = {1,1,1,2};

static bool CheckArr(int[] arr) {
    bool equals = true;
    for (int i=0; i<arr.Length-1; i++)
    {
        if (arr[i] == arr[i+1]) continue;
        else equals = false;
    }
    return equals;
}

Console.WriteLine(CheckArr(arr1));
