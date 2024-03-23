// See https://aka.ms/new-console-template for more information
using MyFirstGameEngine;
using MyFirstGameEngine.Utils;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

Console.WriteLine("Hello, World! I'm using OpenTK!");

var nativeWindowSettings = new NativeWindowSettings()
{
    ClientSize = new Vector2i(800, 600),
    Title = SharedConfigs.ProgramTitle,
    Flags = ContextFlags.ForwardCompatible,
};

using (var window = new Window(GameWindowSettings.Default, nativeWindowSettings))
{
    window.Run();
}
