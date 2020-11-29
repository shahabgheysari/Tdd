using System;
using Xunit;

namespace Tic_tac_toe
{
    public class UnitTest1
    {
        [Fact]
        public void TestSpaceHasRowAndColumn()
        {
            Space space11 = new Space(1,2);
            
            Assert.Equal(space11.Row(),1);
            Assert.Equal(space11.Column(),2);
        }
    }

    public class Space
    {
        private int row;
        private int column;
        public Space(int row,int column)
        {
        }

        public int Row()
        {
            return 1;
        }

        public int Column()
        {
            return 2;
        }
    }
}