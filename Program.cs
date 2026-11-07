// // Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// for (int i = days.Length - 1; i >= 0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// }


// // Задание 1.2
// double[] temps = { 12.5, 8.0, -3.2, -7.5, 0.0, 5.4, 10.1 };

// foreach (double t in temps) {
//     Console.Write(t + " ");
// }



// // Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int count = 0;

// foreach (int i in prices) {
//     sum += i;
//     if (i > 100) {
//         count++;
//     }
// }

// double average = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}, Ср.Цена: {average}, Кол-во: {count}");


// // Задание 3
// int min = prices[0];
// int max = prices[0];
// int pos = 0;

// for (int i = 1; i < prices.Length; i++) {
//     if (prices[i] < min) {
//         min = prices[i];
//     }
//     if (prices[i] > max){
//         max = prices[i];
//         pos = i;
//     }
// }
// Console.WriteLine($"Минимум: {min}, Индекс: {pos}");




// Задание 4

// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++) {
//     if (balance[i] < 0) {
//         balance[i] = 0;
//     }
// }

// foreach (int b in balance) {
//     Console.Write(b + " ");
// }




// Задание 5
// int[] numbers = new int[5];

// for (int i = 0; i < numbers.Length; i++) {
//     Console.Write($"Введите число: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Массив в обратном порядке:");
// for (int i = numbers.Length - 1; i >= 0; i--) {
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();

// int count = 0;
// foreach (int n in numbers) {
//     if (n % 2 == 0) {
//         count++;
//     }
// }
// Console.WriteLine($"Чётных чисел: {count}");


// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };

// Console.Write("Введите имя: ");
// string name = Console.ReadLine();

// bool flag = false;

// for (int i = 0; i < names.Length; i++) {
//     if (names[i] == name) {
//         Console.WriteLine($"Имя стоит на позиции {i}");
//         flag = true;
//     }
// }

// if (!flag) {
//     Console.WriteLine("Не найдено");
// }





// Итоговая задача. «Журнал оценок»
int[] grades = { 5, 4, 3, 5, 2, 4, 5, 3 };

foreach (int g in grades) {
    Console.Write(g + " ");
}
Console.WriteLine();

int sum = 0;
int max = grades[0];
int min = grades[0];
int two = 0;
int five = 0;

foreach (int g in grades) {
    sum += g;
    if (g > max) {
        max = g;
    }
    if (g < min) {
        min = g;
    }
    if (g == 2) {
        two++;
    }
    if (g == 5) {
        five++;
    }
}

double average = (double)sum / grades.Length;

Console.WriteLine($"Средняя оценка: {average}");
Console.WriteLine($"Наибольшая: {max}, наименьшая: {min}");
Console.WriteLine($"Двоек: {two}, пятёрок: {five}");

if (average >= 4.5) {
    Console.WriteLine("Отличник");
}
else if (average >= 3.5) {
    Console.WriteLine("Хорошист");
}
else {
    Console.WriteLine("Есть над чем поработать");
}