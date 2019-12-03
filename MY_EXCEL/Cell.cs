namespace MY_EXCEL
{
    public class Cell
    {
        public string Expression { get; set; }
        public double Value { get; set; }
        public string Error { get; set; }
        public int RowNumber { get; set; }
        public char ColumnLetter { get; set; }
        public System.Collections.Generic.List<Cell> References { get; set; } = new System.Collections.Generic.List<Cell>();
        public _26BaseSys Class26BaseSys
        {
            get => default(_26BaseSys);
            set { }
        }
    }
}
