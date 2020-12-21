

using System.Drawing;

namespace IndustrialEngineer
{
    public class Player
    {
        private int id = 1;
        private int playerStendOnX = 0;
        private int playerStendOnY = 0;
        private int playerWillStendOnX = 0;
        private int playerWillStendOnY = 0;
        private string imagineObject = "player";

        public int PlayerStendOnX
        {
            get => playerStendOnX;
            set => playerStendOnX = value;
        }

        public int PlayerStendOnY
        {
            get => playerStendOnY;
            set => playerStendOnY = value;
        }

        public int PlayerWillStendOnX
        {
            get => playerWillStendOnX;
            set => playerWillStendOnX = value;
        }

        public int PlayerWillStendOnY
        {
            get => playerWillStendOnY;
            set => playerWillStendOnY = value;
        }

        private Color color = Color.Red;

        public Color Color
        {
            get => color;
            set => color = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string ImagineObject
        {
            get => imagineObject;
            set => imagineObject = value;
        }


        
    }
}