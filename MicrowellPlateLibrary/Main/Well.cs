namespace MicrowellPlate.Main
{
    public class Well
    {
        private Plate plate;

        public Well(Plate plate)
        {
            this.plate = plate;
        }

        public int Row { get; internal set; }
        public int Column { get; internal set; }


        public int PositionRows => plate.PositionRows;

        public int PositionColumns => plate.PositionColumns;
    }
}