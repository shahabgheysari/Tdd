namespace Tic_tac_toe
{
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