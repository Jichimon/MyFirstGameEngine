using OpenTK.Mathematics;

namespace MyFirstGameEngine.Core;

public class SimpleDrawableObject : OpenGlDrawableObject
{
    public SimpleDrawableObject(Vector3[] vertices, uint[] indices, Vector3? centerOfMass = null, Vector3? position = null, Color4? color = null) : base(vertices, indices, centerOfMass, position, color)
    {
    }
}
