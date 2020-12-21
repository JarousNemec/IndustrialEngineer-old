namespace IndustrialEngineer
{
    public class Field
    {
        private bool iron = false;
        private bool water = false;
        private bool earth = true;
        private bool factory = false;

        public Field(bool iron, bool water, bool earth, bool factory)
        {
            this.iron = iron;
            this.water = water;
            this.earth = earth;
            this.factory = factory;
        }

        public void setIron(bool iron)
        {
            this.iron = iron;
        }

        public bool isIron()
        {
            return iron;
        }

        public bool isWater()
        {
            return water;
        }
       
        public bool isEarth()
        {
            return earth;
        }
       
        public bool isFactory()
        {
            return factory;
        }
    }
}