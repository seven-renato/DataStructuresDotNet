namespace DataStructuresC_.Sorts;
public class QuadraticSortClass
{
    int[] Vet {  get; set; }
    public QuadraticSortClass(int[] vet, string name)
    {
        Vet = vet; 
    }

    public int[] SelectionSort()
    {
        int[] UnsortedList = Vet;
        int[] SortedList = new int[UnsortedList.Length];

        Array.Copy(UnsortedList, SortedList, UnsortedList.Length); // Copiar para manipular longe da Lista base que foi enviada!



        return SortedList;
    }
    public int[] InsertionSort()
    {
        int[] UnsortedList = Vet;
        int[] SortedList = new int[UnsortedList.Length];

        Array.Copy(UnsortedList, SortedList, UnsortedList.Length); // Copiar para manipular longe da Lista base que foi enviada!



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
