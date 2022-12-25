Console.WriteLine("Данная программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите любую цифру от 1 до 7, обозначающую день недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
}
  if (dayNumber == 7) {
  Console.WriteLine("Этот день является выходным! Это - Воскресенье");
   }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Данная цифра не является днём недели, так как не входит в интервал чисел от 1 до 7!");
  }
  if (dayNumber == 6) {
  Console.WriteLine("Этот день является выходным! Это - Суббота");
  }
  if (dayNumber == 5) {
  Console.WriteLine("Этот день является будним! Это - Пятница");
  }
  if (dayNumber == 4) {
  Console.WriteLine("Этот день является будним! Это - Четверг");
  }
  if (dayNumber == 3) {
  Console.WriteLine("Этот день является будним! Это - Среда");
  }
  if (dayNumber == 2) {
  Console.WriteLine("Этот день является будним! Это - Вторник");
  }
  if (dayNumber == 1) {
  Console.WriteLine("Этот день является будним! Это - Понедельник");
  }

CheckingTheDayOfTheWeek(dayNumber);