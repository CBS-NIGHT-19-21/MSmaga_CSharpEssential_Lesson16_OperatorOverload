using Task4_DateOperators.Classes;
class Program
{
    static void Main()
    {
        #region Задание 4 
        // Создайте класс, который будет содержать информацию о дате(день, месяц, год).
        // С помощью механизма перегрузки операторов, определите операцию разности
        // двух дат(результат в виде количества дней между датами), а также операцию
        // увеличения даты на определенное количество дней.
        // https://calculator888.ru/skolko-dnei

        // public virtual bool Equals(object? obj)
        // public static bool Equals(object? objA, object? objB)
        // public virtual int GetHashCode()
        // public Type GetType()
        // protected object MemberwiseClone()
        // public static bool ReferenceEquals(object? objA, object? objB)
        // public virtual string? ToString()

        #endregion

        Date date1 = new(4, 12, 2008);
        Date date2 = new(28, 1, 2022);
        date1.Show();
        date2.Show();

        Console.WriteLine($"Days diff is {date1 - date2} days.\n");

        Date date3 = new(28, 1, 2022);
        date3.Show();

        Date date4 = date3 + 15;
        date4.Show();

        Console.ReadLine();
    }
}


