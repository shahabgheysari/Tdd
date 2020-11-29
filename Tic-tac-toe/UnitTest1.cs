using System;
using Xunit;

namespace Tic_tac_toe
{
    public class UnitTest1
    {
        [Fact]
        public void TestSpaceHasRowAndColumn()
        {
            Space space12 = new Space(1,2);
            
            Assert.Equal(1,space12.Row());
            Assert.Equal(2,space12.Column());
            
            Space space23 = new Space(2,3);
            
            Assert.Equal(2,space23.Row());
            Assert.Equal(3,space23.Column());
        }
    }

    public class Space
    {
        private int _row;
        private int _column;
        
        public Space(int row,int column)
        {
            _row = row;
            _column = column;
        }

        public int Row()
        {
            return _row;
        }

        public int Column()
        {
            return _column;
        }
    }
}