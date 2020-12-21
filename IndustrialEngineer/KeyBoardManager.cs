using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace IndustrialEngineer
{
    public class KeyBoardManager
    {
        private IndustrialEngineer _industrialEngineer;
        private PlayerMovementManager _playerMovementManager;
        
        public KeyBoardManager(IndustrialEngineer InEng, MainMap _mainMap)
        {
            _playerMovementManager = new PlayerMovementManager(_mainMap, InEng);
            _industrialEngineer = InEng;
            _industrialEngineer.KeyDown += KeyDistributor;

        }

        private void KeyDistributor(object sender, KeyEventArgs e)
        {
            
            //Console.WriteLine( $"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");

            switch (e.KeyCode)
            {
                case Keys.W:
                {
                    _playerMovementManager.GoUp();
                    break;   
                }
                case Keys.S:
                {
                    _playerMovementManager.GoDown();
                    break;   
                }
                case Keys.A:
                {
                    _playerMovementManager.GoLeft();
                    break;   
                }
                case Keys.D:
                {
                    _playerMovementManager.GoRight();
                    break;   
                }
            }
        }
        
        public static void Movement()
        {
            
        }
    }
}