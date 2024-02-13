using DataStructuresC_.Sorts.Interfaces;

namespace DataStructuresC_.Sorts.Implementations;
public class QuadraticSortClass : IQuadraticSortAlgorithm
{
    int[] Vet { get; set; }
    public QuadraticSortClass(int[] vet)
    {
        Vet = vet;
    }

    public int[] SelectionSort()
    {
        int[] UnsortedList = Vet;
        int[] SortedList = new int[UnsortedList.Length];

        Array.Copy(UnsortedList, SortedList, UnsortedList.Length); // Copiar para manipular longe da Lista base que foi enviada!

        for (int i = 0; i < SortedList.Length; i++)
        {
            var min = SortedList[i..].Min();
            SortedList[i] = min;
        }

        return SortedList;
    }
    public int[] InsertionSort()
    {
        int[] UnsortedList = Vet;
        int[] SortedList = new int[UnsortedList.Length];

        Array.Copy(UnsortedList, SortedList, UnsortedList.Length);



        return SortedList;
    }

    public int[] BubbleSort()
    {
        int[] UnsortedList = Vet;
        int[] SortedList = new int[UnsortedList.Length];

        Array.Copy(UnsortedList, SortedList, UnsortedList.Length); // Copiar para manipular longe da Lista base que foi enviada!



        return SortedList;
    }
}
