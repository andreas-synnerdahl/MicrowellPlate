using System.Collections.Generic;

namespace MicrowellPlate.Main
{
    public class Plate
    {
        public Plate(int rows, int columns)
        {
            var wells = new Well[rows * columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    var well = new Well() { Row = row, Column = column };
                    wells[(row * columns) + column] = well;
                }
            }

            Wells = wells;

            Rows = rows;
            Columns = columns;
        }

        public int Rows { get; }

        public int Columns { get; }

        public IReadOnlyCollection<Well> Wells { get; }
    }
}