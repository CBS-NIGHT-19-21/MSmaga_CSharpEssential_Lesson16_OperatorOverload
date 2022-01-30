using Task3_House.Classes;
using Task3_House_Clone.Classes;

class Program : Room
{
    static void Main()
    {
        #region Задание 3 House 
        // Создайте класс House c двумя полями и свойствами. 
        // Создайте два метода Clone() и DeepClone(),
        // которые выполняют поверхностное и глубокое
        // копирование соответственно.Реализуйте простой способ проверки. 

        // public virtual bool Equals(object? obj)
        // public static bool Equals(object? objA, object? objB)
        // public virtual int GetHashCode()
        // public Type GetType()
        // protected object MemberwiseClone()
        // public static bool ReferenceEquals(object? objA, object? objB)
        // public virtual string? ToString()

        #endregion

        House house = new();
        house.Show();

        House? clone = House.Clone(house);
        clone!.Show();

        clone.Adress = "DeepClone";
        clone!.Show();

        Console.WriteLine("\nDeepClone: " + House.IsDeepClone(house, clone));



        Office office = new();

        Office? cloneOffice = Office.Clone(office);
        cloneOffice!.Show();

        cloneOffice._house.roomName = "Clone";
        cloneOffice!.Show();

        Console.WriteLine("\nClone: " + Office.IsClone(office, cloneOffice));



        Console.ReadLine();
    }
}


