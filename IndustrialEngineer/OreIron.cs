using System.Drawing;

namespace IndustrialEngineer
{
    public class OreIron
    {
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

            public Color Color
            {
                get => color;
                set => color = value;
            }

            private int id = 0;
            private string imagineObject = "iron ore";
            private Color color = Color.Brown;

    }
}