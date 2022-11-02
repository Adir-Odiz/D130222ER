using NUnit.Framework;
class Program 
{
public int[] Append(int[] array, int item){
    if (array == null || array.Length == 0) return new int[] { item };    
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++) {
        newArray[i] = array[i];
    }
    newArray[array.Length] = item;
    return newArray;
}

[TestCase(new int[] {1, 2}, 3, ExpectedResult = new int[] {1, 2, 3 })]
public int[] Append_Test(int[] array, int item)
{
    return Append(array,item);
}
}