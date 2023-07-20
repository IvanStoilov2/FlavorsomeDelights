// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Test 1 from SO");
//Console.WriteLine("Hello from Ivaka");
//Console.WriteLine("Hi, I am Eli.");
//Console.WriteLine("Hi, I'm Ivan. Nice to meet you!");
//Console.ReadLine();


//Function to get a random but always same element for a given day from an array 
var recepiesCount = 23;

for (int i = 0; i < 5; i++)
{
    var date = DateTime.Now.Date.AddDays(i);
    var dateAsNumber = date.ToOADate(); //change 5 time the dates to prove it gives different element

    Console.WriteLine("For the date {0} the random selected number from an aray with length {1}",
                      date.ToString("dd.MM.yy"),
                      recepiesCount);

    for (int j = 0; j < 3; j++) //output twice the random number for that day to prove it is the same
    {
        var random = new Random((int)dateAsNumber);
        var result = random.Next(recepiesCount);

        Console.WriteLine("\t" + result);
    }

}






Console.ReadLine();
