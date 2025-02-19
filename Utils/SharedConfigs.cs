﻿using OpenTK.Mathematics;

namespace MyFirstGameEngine.Utils;

public class SharedConfigs
{
    public static readonly string ProgramTitle = "My First Game Engine";

    public static readonly string VertexShaderFilePath = "Shaders/shader.vert"; 
    public static readonly string FragmentShaderFilePath = "Shaders/shader.frag";

    public static readonly string ColorUniformName = "uColor";
    public static readonly Color4 DefaultColor = new (142, 138, 125, 255);

    public static readonly Vector3 DefaultOriginPosition = Vector3.Zero;

    public static readonly string MvpMatrixUniformName = "mvp";
}
