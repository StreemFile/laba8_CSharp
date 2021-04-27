namespace laba8.Three
{
    public class Tree : IComparable, IComparer
    {
        private int price;
        private int height;
        private string poroda;

        public Tree()
        {
        }

        public Tree(int price, int height, string poroda)
        {
            this.price = price;
            this.height = height;
            this.poroda = poroda;
        }

        public string Poroda
        {
            get => poroda;
            set => poroda = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public int CompareTo(Tree treeToCompare)
        {
            if (this.price > treeToCompare.price)
            {
                return 1;
            } 
            if (this.price < treeToCompare.price)
            {
                return -1;
            } 
            return 0;
        }

        public int CompareByHeightAndPrice(Tree treeToCompare)
        {
            if (this.price > treeToCompare.price 
                && this.height > treeToCompare.height)
            {
                return 1;
            } 
            if (this.price == treeToCompare.price 
                && this.height == treeToCompare.height)
            {
                return 0;
            }
            return -1;
        }

        public override string ToString()
        {
            return $"\n{nameof(price)}: {price}, " +
                   $"\n{nameof(height)}: {height}, " +
                   $"\n{nameof(poroda)}: {poroda}";
        }
    }
}