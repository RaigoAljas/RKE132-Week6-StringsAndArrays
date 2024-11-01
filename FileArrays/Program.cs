int[] numbers = new int[10];
Random rnd = new Random();

//populating the array
for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = rnd.Next(1, numbers.Length +1);
}

foreach (int number in numbers)
{
    Console.WriteLine(number);  
}