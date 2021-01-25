using System.Collections.Generic;
using System.Text;

namespace Maze.Logic.Iterator
{
    public interface IAggregate
    {
        IAbstractIterator CreateIterator(IteratorType iteratorType);
    }
}
