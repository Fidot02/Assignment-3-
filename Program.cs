Dictionary<string, string> studentsAndDislike = new Dictionary<string, string>();

studentsAndDislike["Victor"] = "Victor hates fish";
studentsAndDislike["Anita"] = "Anita hates Money";
studentsAndDislike["Caleb"] = "Caleb hates Trekking";
studentsAndDislike["Felix"] = "Felix hates playing";
studentsAndDislike["Victor"] = "Jonathan hates NYSC";


Console.WriteLine(studentsAndDislike["Felix"]);
Console.WriteLine();

Dictionary<int, string> scores = new Dictionary<int, string>();
scores[98] = "first position";
scores[90] = "second position";
scores[86] = "third position";

Console.WriteLine("We only give prices to the top " + scores.Count);
Console.WriteLine();


Dictionary<string, decimal> fruitPrices = new Dictionary<string, decimal>();
fruitPrices.Add("Orange", 500);
fruitPrices.Add("Banana", 800);
fruitPrices.Add("Mango", 200);
fruitPrices.Add("Watermelon", 1500);
fruitPrices.Add("Pineapple", 650);
fruitPrices.Add("Apple", 300);
fruitPrices.Add("cherry", 200);
fruitPrices.Add("Pawpaw", 900);


foreach (var fruitPrice in fruitPrices)
{
    Console.WriteLine("For " + fruitPrice.Key + " the price is " + "$" + fruitPrice.Value);
}
Console.ReadKey();
