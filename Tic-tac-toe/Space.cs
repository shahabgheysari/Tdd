using System;

namespace Tic_tac_toe
{
    public class Space
    {
        private int _row;
        private int _column;
        private string _mark = "";
        public Space(int row,int column)
        {
            _row = row;
            _column = column;
        }

        public string Mark
        {
            set
            {
                if (_mark.Equals(String.Empty))
                {
                    _mark = value;
                } 
            }
            get => _mark; 
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