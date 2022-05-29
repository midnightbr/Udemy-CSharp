// HashSet
HashSet<string> hash = new HashSet<string>();

hash.Add("TV");
hash.Add("Notebook");
hash.Add("Tablet");
hash.Add("Smartphone");

Console.WriteLine(hash.Contains("Notebook"));

foreach (string key in hash)
{
    Console.WriteLine(key);
}

/*------------------------------------------------------------------------------------*/

// SortedSet
SortedSet<int> sortedA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
SortedSet<int> sortedB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

// Union -> união das coleções
SortedSet<int> sortedC = new SortedSet<int>(sortedA);
sortedC.UnionWith(sortedB);
printCollection(sortedC);

// Intersection -> Imprimi os dados que ambos os sorted tem em comum
SortedSet<int> sortedD = new SortedSet<int>(sortedA);
sortedD.IntersectWith(sortedB);
printCollection(sortedD);

// Difference -> Imprimi os dados do sortedE e que não existem no sortedB
SortedSet<int> sortedE = new SortedSet<int>(sortedA);
sortedE.ExceptWith(sortedB);
printCollection(sortedE);

static void printCollection<T>(IEnumerable<T> collection)
{
    foreach(T item in collection)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}