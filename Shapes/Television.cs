using MyFirstGameEngine.Core;
using OpenTK.Mathematics;

namespace MyFirstGameEngine.Shapes;

public class Television : DrawableCompositeObject
{

    private static readonly Vector3 _initialPosition = Vector3.Zero;
    private static readonly Dictionary<string, IDrawable> _tvParts = new()
    {
        { "case", new TvCase() },
        { "screen", new TvScreen() }
    };


    public Television() : base(_initialPosition, _tvParts)
    {      
    }

}
