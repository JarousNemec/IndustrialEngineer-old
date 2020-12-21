using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndustrialEngineer
{
    public class PlayerRender
    {
        
        private Player _player;
        private MainMap _mainMap;
        private IndustrialEngineer _industrialEngineer;
        private Label avatarLabel;
        

        public PlayerRender(Player player, MainMap mainMap, IndustrialEngineer InEng)
        {
            _player = player;
            _mainMap = mainMap;
            _industrialEngineer = InEng;
            avatarLabel = new Label();
            avatarLabel.Size = new Size(50,50);
            avatarLabel.ForeColor = Color.Blue;
            avatarLabel.BackColor = Color.Blue;
        }

        public void renderPlayer()
        {
            
            avatarLabel.Location = new Point(_player.PlayerWillStendOnX*50, _player.PlayerWillStendOnY*50);
            _industrialEngineer.Controls.Add(avatarLabel);
            
            _player.PlayerStendOnX = _player.PlayerWillStendOnX;
            _player.PlayerStendOnY = _player.PlayerWillStendOnY;
            Console.WriteLine(_player.PlayerStendOnX);
            Console.WriteLine(_player.PlayerStendOnY);
        }
    }
}