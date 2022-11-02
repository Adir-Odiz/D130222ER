using NUnit.Framework;

namespace Ex2;
class Program {
    public int[] GetIndexes(int[] array, int item)
    {
        int[] indexes = new int[array.Length];
        for (int i=0; i<array.Length; i++){
            if (item == array[i]){
                indexes;
            }
        }
        return indexes;

    }
}