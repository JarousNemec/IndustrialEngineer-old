namespace IndustrialEngineer
{
    public class MainMap
    {

        private Field[,] mainMap;

        public MainMap(int Xvalue, int Yvalue)
        {
            mainMap = new Field [Xvalue, Yvalue];
        }

        public int getX()
        {
            return mainMap.GetLength(0);
        }

        public int getY()
        {
            return mainMap.GetLength(1);
        }

        public Field getField(int x, int y)
        {
            return mainMap[x, y];
        }

        public void setValue(int x, int y, Field field)
        {
            mainMap[x, y] = field;
        }

    }
}