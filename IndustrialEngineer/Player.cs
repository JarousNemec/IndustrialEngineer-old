namespace IndustrialEngineer
{
    public class Player
    {
        private int id = 1;
        private int playerX = 0;
        private int playerY = 0;
        private string imagineObject = "player";
        private string color = "red";

        public string getColor()
        {
            return color;
        }
        
        public int getPlayerX()
        {
            return playerX;
        }
        
        public int getPlayerY()
        {
            return playerY;
        }
        
        public void setPlayerX(int x)
        {
            playerX = x;
        }
        
        public void setPlayerY(int y)
        {
            playerY = y;
        }
    }
}