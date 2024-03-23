using MyFirstGameEngine.Core;
using MyFirstGameEngine.Utils;

namespace MyFirstGameEngine.Shapes;

public class TvCase : SimpleDrawableObject
{
    private static readonly float[] _vertices =
    {
        // Front face (screen case)
        -4.0f, -2.5f, 0.5f, // Bottom left - 0
         4.0f, -2.5f, 0.5f, // Bottom right - 1
         4.0f,  2.5f, 0.5f, // Top right - 2
        -4.0f,  2.5f, 0.5f, // Top left - 3

        // Back face (screen case)
        -4.0f, -2.5f, 0.0f, // Back left - 4 
         4.0f, -2.5f, 0.0f, // Back right - 5 
         4.0f,  2.5f, 0.0f, // Front right - 6 
        -4.0f,  2.5f, 0.0f, // Front left - 7 


        // Back face (back case)        
        -2.0f, -1.5f, -2.5f, // Back left - 8 
         2.0f, -1.5f, -2.5f, // Back right - 9 
         2.0f,  1.5f, -2.5f, // Front right - 10 
        -2.0f,  1.5f, -2.5f, // Front left - 11

    };


    private static readonly uint[] _indices =
    {
        // Front face (screen case)
        0, 1, 2, 
        2, 3, 0, 

        // Back face (screen case)
        5, 4, 7, 
        7, 6, 5, 

        // Top face (screen case)
        3, 2, 6, 
        6, 7, 3, 

        // Bottom face (screen case)
        4, 5, 1, 
        1, 0, 4, 

        // Left face (screen case)
        4, 0, 3, 
        3, 7, 4, 

        // Right face (screen case)
        1, 5, 6, 
        6, 2, 1, 


        // Front face (back case)
        4, 5, 6,
        6, 7, 4, 

        // Back face (back case)
        9, 8, 11,
        11, 10, 9, 

        // Top face (back case)
        7, 6, 10,
        10, 11, 7, 

        // Bottom face (back case)
        8, 9, 5,
        5, 4, 8, 

        // Left face (back case)
        8, 4, 7,
        7, 11, 8, 

        // Right face (back case)
        5, 9, 10,
        10, 6, 5,
    };


    public TvCase() : base(Converter.ParseToVector3Array(_vertices), _indices) { }
}
