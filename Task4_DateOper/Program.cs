﻿
#region Задание 4
// Создайте класс, который будет содержать информацию о дате(день, месяц, год).
// С помощью механизма перегрузки операторов, определите операцию разности
// двух дат(результат в виде количества дней между датами), а также операцию
// увеличения даты на определенное количество дней.
#endregion

Date date = new(1, 4, 1);


Console.WriteLine(date.GetDayMonth(2, 2001));
// Delay
Console.ReadLine();
