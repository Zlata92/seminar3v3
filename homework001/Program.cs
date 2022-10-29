Console.WriteLine ("Введите трехзначное число ");
int num=Convert.ToInt32 (Console.ReadLine ());
int amount = num.ToString().Length;

if (amount < 3 || amount>3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
} 
else
{
    Console.WriteLine(InCenter(num));
}   
 int message (string message) 
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}