using Task3_House.Classes;
 
namespace Task3_House_Clone.Classes
{
    class Office
    {
        public House _house = new();
        public Garage _garage = new();

        public void Show() =>
        Console.WriteLine("HashCode: " + this.GetHashCode() + "\t" + 
                          this._garage.sqr + "\t" + this._house.roomName);
        public static Office? Clone(Office original) => original.MemberwiseClone() as Office;

        public static bool IsClone(Office office1, Office office2) =>
                   office1._house.roomName == office2._house.roomName &&
                   office1.GetHashCode() != office2.GetHashCode();
    }
}
