using System.Collections.Generic;
using System.Linq;

namespace laba8.Three
{
    public interface IEnumerable
    {
        static List<Tree> Sort(List<Tree> treesToSort)
        {
            var sorted = treesToSort
                                        .OrderBy(item => item.Price)
                                        .Select(item => item);


            return new List<Tree>(sorted);
        }
    }
}