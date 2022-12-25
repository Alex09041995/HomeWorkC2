Console.WriteLine("Данная программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Введите любое трёхзначное число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

if (threeDigitNumber < 100 || threeDigitNumber >= 1000){
    Console.WriteLine("Вы ввели не трёхзначное число!");   
}
Console.WriteLine("Вторая цифра числа это: "+stringNumber[1]);