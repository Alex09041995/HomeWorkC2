Console.WriteLine("Данная программа принимает на вход число и на выходе показывает третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите любое число: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра числа это: " + anyNumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет так, как вы ввели число меньшее трёхзначного!");
}