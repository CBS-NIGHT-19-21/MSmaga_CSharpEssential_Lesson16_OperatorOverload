
namespace Task2_Block.Classes
{
    public struct Block
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;
        private readonly double _side4;

        public Block(double side1, double side2, double side3, double side4)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            _side4 = side4;
        }
        public override string ToString() =>
                       base.ToString() + "\t" + base.GetHashCode() + "\t" + base.GetType();

        public static bool Equals(Block block1, Block block2)
        {
            bool isEqual = (block1._side1 == block2._side1 && block1._side2 == block2._side2 &&
                            block1._side3 == block2._side3 && block1._side4 == block2._side4);
            if (isEqual) return true;
            else return false;
        }
    }
}
