using DataStructuresC_.Sorts.Implementations;

namespace DataStructuresC_;

internal class Program
{
    static void Main(string[] args)
    {
        int[] TestValues = new int[] { -8, 13, 1, 20, 15, 3, 2, -1, -2 };
        QuadraticSortClass QuadraticTests = new QuadraticSortClass(TestValues);
        int[] sortedArray = QuadraticTests.SelectionSort();
        Console.WriteLine(string.Join(", ", sortedArray));
    }
}
