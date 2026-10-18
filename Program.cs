// PrintHeader();
// PrintHeader();
// System.Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     System.Console.WriteLine("^_^");
//     System.Console.WriteLine("Лабораторная работа №13");
//     System.Console.WriteLine("Дата формирования отчёта: 16.10.2026");
//     System.Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     System.Console.WriteLine(">_<");
//     System.Console.WriteLine("  Конец программы");
//     System.Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, int age, string group) {
//     System.Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
// }

// PrintStudentCard("Егор", 18, "ИСП-252");
// PrintStudentCard("Валерия", 17, "ЗСП-252");

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }

// double averageGrade = 4.7;

// if (IsEligibleForBonus(averageGrade)) {
//     double result = CalculateScholarship(2000, 15);
//     System.Console.WriteLine($"Стипендия с бонусом: {result}");
// } else {
//     double result = CalculateScholarship(2000, 0);
//     System.Console.WriteLine($"Обычная стипендия: {result}");
// }

// double CalculateAverageGrade(int[] grades) {
//     int sum = 0;
//     foreach (int grade in grades) {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// System.Console.WriteLine(average);

// int CountFives(int[] grades) {
//     int count = 0;
//     foreach (int grade in grades) {
//         if (grade == 5) {
//             count++;
//         }
//     }
//     return count;
// }

// int countFives = CountFives(grades);
// System.Console.WriteLine(countFives);

// class Program {
//     static void Main() {
//         System.Console.WriteLine(Add(2, 3));
//         System.Console.WriteLine(Add(2.5, 3.5));
//         System.Console.WriteLine(Add(2, 3, 4));
//     }

//     static int Add(int a, int b) {
//         return a + b;
//     }

//     static double Add(double a, double b) {
//         return a + b;
//     }

//     static int Add(int a, int b, int c) {
//         return a + b + c;
//     }
// }

// System.Console.WriteLine("Задание Б");

// void PrintPerson(string name, int age) {
//     System.Console.WriteLine($"Студент: {name}, возраст {age}");
// }

// PrintPerson("Катя", 17);
// PrintPerson("Софа", 19);

// System.Console.WriteLine("Задание Г");

// int FindMax(int[] numbers) {
//     int max = int.MinValue;
//     foreach (int number in numbers) {
//         if (number > max) {
//             max = number;
//         }
//     }
//     return max;
// }

// int[] number = { 4, 5, 23, 7, 9 };
// int result = FindMax(number);
// System.Console.WriteLine(result);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// System.Console.WriteLine("Вариант 6");

// int CountVowels(string word) {
//     int count = 0;
//     foreach (char wor in word) {
//         if (wor == 'а' || wor == 'е' || wor == 'ё' || wor == 'и' || wor == 'о' || wor == 'у' || wor == 'ы' || wor == 'э' || wor == 'ю' || wor == 'я' || wor == 'А' || wor == 'Е' || wor == 'Ё' || wor == 'И' || wor == 'О' || wor == 'У' || wor == 'Ы' || wor == 'Э' || wor == 'Ю' || wor == 'Я') {
//             count++;
//         }
//     }
//     return count;
// }

// string word = "Тюлень";
// int glacial= CountVowels(word);
// System.Console.WriteLine(glacial);

// System.Console.WriteLine("Вариант 7");

// int FindMin(int[] numbers) {
//     int min = int.MaxValue;
//     foreach (int number in numbers) {
//         if (number < min) {
//             min = number;
//         }
//     }
//     return min;
// }

// int[] number = { 4, 5, 23, 7, 9 };
// int result = FindMin(number);
// System.Console.WriteLine(result);