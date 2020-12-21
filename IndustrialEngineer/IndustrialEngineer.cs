using System;
using System.Drawing;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace IndustrialEngineer
{
    public class IndustrialEngineer : Form
    {
        public IndustrialEngineer()
        {
            Inicializace();
            GameProcesor();
        }

        private MainMap _mainMap = new MainMap(10, 10);
        private EarthField _earthField = new EarthField();
        private OreIron _oreIron = new OreIron();
        private ThreadManager _threadManager = new ThreadManager();
        private KeyBoardManager _keyBoardManager;

        private void Inicializace()
        {
            this.Size = new Size(600, 600);
            this.Text = "IndustrialEngineer";
            this.Focus();
            _keyBoardManager = new KeyBoardManager(this, _mainMap);
            FillsTheMapWithEmptyFields();
        }

        public void GameProcesor()
        {
            renderFields();
        }

        private void FillsTheMapWithEmptyFields()
        {
            int rn;
            Random r = new Random();
            for (int y = 0; y < _mainMap.getY(); y++)
            {
                for (int x = 0; x < _mainMap.getX(); x++)
                {
                    Field field = new Field(false, false, true, false);
                    _mainMap.setValue(x, y, field);
                }

                Field field2 = new Field(true, false, false, false);
                rn = r.Next(9);
                _mainMap.setValue(rn, y, field2);
            }


            int i = 0;
        }

        private void renderFields()
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (_mainMap.getField(x, y).isEarth())
                    {
                        Label earth = new Label();
                        earth.Size = new Size(50, 50);
                        earth.Location = new Point((x * 50), (y * 50));
                        earth.BackColor = _earthField.Color;
                        earth.BorderStyle = BorderStyle.Fixed3D;
                        this.Controls.Add(earth);
                    }
                    else if (_mainMap.getField(x, y).isWater())
                    {
                    }
                    else if (_mainMap.getField(x, y).isIron())
                    {
                        Label iron = new Label();
                        iron.Size = new Size(50, 50);
                        iron.Location = new Point((x * 50), (y * 50));
                        iron.BackColor = _oreIron.Color;
                        iron.BorderStyle = BorderStyle.Fixed3D;
                        this.Controls.Add(iron);
                    }
                    else if (_mainMap.getField(x, y).isFactory())
                    {
                    }
                }
            }
        }
    }
}