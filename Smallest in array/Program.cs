int SmallestInArray(int[] x) {

    int smallest = x[0];
    for (int i = 1; i < x.Length; i++) {
        if (x[i] < smallest)
        {
            smallest = x[i];
        }
    }
    
    return smallest;
}

int[] a = {7, 12, 9, 11, 3};
Console.WriteLine(SmallestInArray(a));
Console.WriteLine("Press any key to exit");
Console.ReadKey();