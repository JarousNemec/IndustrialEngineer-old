namespace IndustrialEngineer
{
    public class PlayerMovementManager
    {
        private Player _player;
        private MainMap _mainMap;
        private int _mapSizeX;
        private int _mapSizeY;
        private int _PlayerLocX;
        private int _PlayerLocY;
        private PlayerRender _playerRender;
        
        public PlayerMovementManager(MainMap mainMap, IndustrialEngineer InEng)
        {
            _mainMap = mainMap;
            _mapSizeX = _mainMap.getX();
            _mapSizeY = _mainMap.getY();

            _player =new Player();
            _PlayerLocX = _player.PlayerStendOnX;
            _PlayerLocY = _player.PlayerStendOnY;
            
            _playerRender = new PlayerRender(_player,_mainMap,InEng);
        }

        public void GoUp()
        {
            if ((_player.PlayerStendOnY + 1) <= _mapSizeY)
            {
                _player.PlayerWillStendOnY = _player.PlayerWillStendOnY + 1;
                _playerRender.renderPlayer();
            }
        }
        
        public void GoDown()
        {
            if ((_player.PlayerStendOnY - 1) >= 0)
            {
                _player.PlayerWillStendOnY = _player.PlayerWillStendOnY - 1;
                _playerRender.renderPlayer();
            }
        }
        
        public void GoLeft()
        {
            if ((_player.PlayerStendOnX - 1) >= 0)
            {
                _player.PlayerWillStendOnX = _player.PlayerWillStendOnX - 1;
                _playerRender.renderPlayer();
            }
        }
        
        public void GoRight()
        {
            if ((_player.PlayerStendOnX + 1) <= _mapSizeX)
            {
                _player.PlayerWillStendOnX = _player.PlayerWillStendOnX + 1;
                _playerRender.renderPlayer();
            }
        }
        
    }
}