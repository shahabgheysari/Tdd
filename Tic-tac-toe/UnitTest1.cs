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

        [Fact]
        public void TestNewSpaceHasNotMark()
        {
            Space space21 = new Space(2,1);
            
            Assert.True(space21.Mark.Equals(String.Empty));
        }
        
                
        [Fact]
        
        public void TestOccupiedSpaceNotAllowedToBeingSetEmpty()
        {
            Space space11 = new Space(1,1);
            space11.Mark = "O"; 
            space11.Mark = "X";
            
            Assert.True("O".Equals(space11.Mark));
        }

    }
}