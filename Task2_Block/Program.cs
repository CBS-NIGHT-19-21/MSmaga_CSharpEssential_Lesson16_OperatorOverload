using Task2_Block.Classes;

class Program
{
    static void Main()
    {
        #region Задание 4 Block
        // Создайте класс Block с 4 - мя полями сторон, переопределите в нем методы:
        // Equals – способный сравнивать блоки между собой, 
        // ToString – возвращающий информацию о полях блока.
        // https://calculator888.ru/skolko-dnei

        // public virtual bool Equals(object? obj)
        // public static bool Equals(object? objA, object? objB)
        // public virtual int GetHashCode()
        // public Type GetType()
        // protected object MemberwiseClone()
        // public static bool ReferenceEquals(object? objA, object? objB)
        // public virtual string? ToString()

        #endregion

        Block block1 = new (1.3, 2.3, 3.3, 4.3);
        Block block2 = new (1.9, 2.9, 3.9, 4.9);
        Block block3 = new (1.9, 2.9, 3.9, 4.9);

        Console.WriteLine( block1.ToString() );

        Console.WriteLine( Equals(block1, block2) );
        Console.WriteLine( Equals(block2, block3) );

        Console.ReadLine();
    }
}


