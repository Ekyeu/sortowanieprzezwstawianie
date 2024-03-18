internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        int[] tab1 = new int[100];
        int[] tab2 = tab1;

        // uzupelnienie i wyswietlenie

        Console.WriteLine("Tablica przed sortowaniem");
        for (int i = 0; i < 100; i++)
        {
            tab1[i] = r.Next(1, 100);
            Console.Write(tab1[i] + "\n");
        }

        
        // sortowanie

        InsertionSort(tab1);

        Console.WriteLine("\n Tablica Posortowana");
        for (int i = 0; i < tab1.Length; i++)
        {
            Console.Write(tab1[i] + "\n");
        }



        // sprawdzenie

        Array.Sort(tab2);
        Console.WriteLine("\n Sprawdzenie czy tablica zostala dobrze posortowana");

        for (int i = 0; i < tab2.Length; i++)
        {
            Console.Write(tab2[i] + "\n");
        }

    }
    static void InsertionSort(int[] list)
    {
        int i = 1;
        while (i < list.Length)
        {
            // reset parametrow
            int x = list[i];
            int j = i;

            while (j > 0 && list[j - 1] > x)
            {
                list[j] = list[j - 1];
                j = j - 1;
            }
            list[j] = x;
            i = i + 1;
        }
    }
}

