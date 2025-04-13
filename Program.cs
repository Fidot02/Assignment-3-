
// LIST

List<string> fruits = new List<string>();
fruits.Add("Orange");
fruits.Add("Banana");
fruits.Add("Mango");
fruits.Add("Watermelon");
fruits.Add("Pineapple");
fruits.Add("Apple");
fruits.Add("Cherry");
fruits.Add("Pawpaw");
fruits.Add("Lemon");
fruits.Add("Strawberry");
fruits.Add("Blueberry");
fruits.Add("Peach");

Console.WriteLine($"The total fruits on the list is equal to {fruits.Count}");
Console.WriteLine();

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit + " is sweet");
}
Console.WriteLine();

Console.WriteLine(fruits.ElementAt(3));
Console.WriteLine();

fruits.RemoveAt(5);
Console.WriteLine($"The total fruits on the list is equal to {fruits.Count}");
Console.WriteLine();
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit + " is sweet");
}
Console.ReadKey();

