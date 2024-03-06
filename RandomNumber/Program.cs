Random rnd = new Random();

int myRandomNUm;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNUm = rnd.Next(0, 11); // 0 - 10
    randomSum = randomSum + myRandomNUm;
    Console.WriteLine($"My random number is: {myRandomNUm}");
}

Console.WriteLine($"random sum total: {randomSum}");