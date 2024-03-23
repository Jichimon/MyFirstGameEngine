using MyFirstGameEngine.Core;
using MyFirstGameEngine.Utils;
using OpenTK.Mathematics;

namespace MyFirstGameEngine.Shapes;

public class TvScreen : SimpleDrawableObject
{

    private static readonly Vector3 _centerOfMass = new Vector3();
    private static readonly Color4 _screenColor = new(0, 0, 0, 1);

    private static readonly float[] _vertices =
    {
        // Front face (screen case)
        -3.5f, -2.0f, 0.51f, // Bottom left - 0
         3.5f, -2.0f, 0.51f, // Bottom right - 1
         3.5f,  2.0f, 0.51f, // Top right - 2
        -3.5f,  2.0f, 0.51f, // Top left - 3

        // Back face (screen case)
        -3.5f, -2.0f, 0.49f, // Back left - 4 
         3.5f, -2.0f, 0.49f, // Back right - 5 
         3.5f,  2.0f, 0.49f, // Front right - 6 
        -3.5f,  2.0f, 0.49f, // Front left - 7 

    };


    private static readonly uint[] _indices =
    {
        // Front face (screen)
        0, 1, 2,
        2, 3, 0, 

        // Back face (screen)
        5, 4, 7,
        7, 6, 5, 

        // Top face (screen)
        3, 2, 6,
        6, 7, 3, 

        // Bottom face (screen)
        4, 5, 1,
        1, 0, 4, 

        // Left face (screen)
        4, 0, 3,
        3, 7, 4, 

        // Right face (screen)
        1, 5, 6,
        6, 2, 1, 

    };

    public TvScreen() : base(Converter.ParseToVector3Array(_vertices), _indices, color: _screenColor) { }
}
