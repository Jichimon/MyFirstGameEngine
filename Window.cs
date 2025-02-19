﻿using MyFirstGameEngine.Core;
using MyFirstGameEngine.Shapes;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace MyFirstGameEngine;

public class Window : GameWindow
{

    private readonly IDrawable _object;
    private Matrix4 _viewProjectionMatrix;
    private Matrix4 _projectionMatrix;
    public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
    {
        _object = new Television();
    }

    protected void CreateViewProjectionMatrix()
    {

        //posicion de la camara
        Vector3 position = new(20.0f, 5.0f, 8.0f);
        Vector3 front = new(0.0f, 0.0f, -1.0f);
        Vector3 up = new(0.0f, 1.0f, 0.0f);

        Matrix4 view = Matrix4.LookAt(position, front, up);

        _viewProjectionMatrix = view * _projectionMatrix;
    }


    protected override void OnLoad()
    {
        GL.ClearColor(0.12f, 0.32f, 0.2f, 1.0f);
        _projectionMatrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), Size.X / Size.Y, 1.0f, 100.0f);
        _object.Build();
        base.OnLoad();
    }


    protected override void OnRenderFrame(FrameEventArgs args)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        GL.Enable(EnableCap.DepthTest);

        CreateViewProjectionMatrix();

        _object.Draw(_viewProjectionMatrix);
        SwapBuffers();
        base.OnRenderFrame(args);
    }


    protected override void OnResize(ResizeEventArgs e)
    {
        GL.Viewport(0, 0, Size.X, Size.Y);
        base.OnResize(e);
    }


    protected override void OnUnload()
    {
        _object.Destroy();
        base.OnUnload();
    }
}
