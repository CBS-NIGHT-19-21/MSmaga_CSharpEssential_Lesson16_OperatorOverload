
namespace Task3_House.Classes
{
    class House : Apartment
    {
        public string _address = "Avenue 13";
        public decimal _price = 1319m;

        
        public string Adress { get { return _address; } set { _address = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }

        public void Show() =>
               Console.WriteLine("HashCode: " + this.GetHashCode() + "\t" + this.Adress +
                                 "\t" + this.Price + "\t" + this.floor + "\t" + this.roomName);
        public static House? Clone(House original) => original.MemberwiseClone() as House;

        public static bool IsDeepClone(House house1, House house2) =>
                house1.roomName == house2.roomName && house1.GetHashCode() != house2.GetHashCode();
    }
}