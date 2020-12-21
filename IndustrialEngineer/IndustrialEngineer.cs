using System;
using System.Drawing;
using System.Dynamic;
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

        MainMap _mainMap = new MainMap(10, 10);
        EarthField _earthField = new EarthField();
        Player _player = new Player();

        private void Inicializace()
        {
            this.Size = new Size(600, 600);
            this.Text = "IndustrialEngineer";
            this.Focus();
            FillsTheMapWithEmptyFields();
        }
        private void FillsTheMapWithEmptyFields()
        {
           
            for (int y = 0; y < _mainMap.getY(); y++)
            {
                
                for (int x = 0; x < _mainMap.getX(); x++)
                {
                    Field field = new Field(false, false,true, false);
                    _mainMap.setValue(x,y,field);
                }
            }

            int i = 0;
        }
        
        public void GameProcesor()
        {
            renderFields();
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
                        earth.Size = new Size(50,50);
                        earth.Location = new Point((x*50),(y*50));
                        earth.BackColor = _earthField.getColor();
                        earth.BorderStyle = BorderStyle.Fixed3D;
                        this.Controls.Add(earth);
                    }
                    else if (_mainMap.getField(x, y).isWater())
                    {
                        
                    }
                    else if (_mainMap.getField(x, y).isIron())
                    {
                        
                    }
                    else if (_mainMap.getField(x, y).isFactory())
                    {
                        
                    }
                }
            }
        }
    }
}