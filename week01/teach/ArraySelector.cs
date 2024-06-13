public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int list1Index = 0;
        int list2Index = 0;
        List<int> results = new List<int>();
        foreach (var x in select)
        {
            if (x == 1)
            {
                results.Add(list1[list1Index]);
                list1Index++;
            }
            else
            {
                results.Add(list2[list2Index]);
                list2Index++;
            }
            // we use else beacuse we only have 2 possible options,
            // but we can use else if also
        }
        return results.ToArray();
    }
}
