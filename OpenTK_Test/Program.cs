using System;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;

namespace OpenTK_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GameWindowSettings gws = GameWindowSettings.Default;
            // gws.IsMultiThreaded = false;
            gws.RenderFrequency = 60;
            gws.UpdateFrequency = 60;
            
            NativeWindowSettings nws = NativeWindowSettings.Default;
            string openGLversion = "4.1.0";
            nws.APIVersion = Version.Parse(openGLversion);
            nws.Size = new Vector2i(1280,720);
            nws.Title = "HelloWorld";
            // nws.Icon = 

          GameWindow window = new GameWindow(gws, nws);

            window.UpdateFrame += (FrameEventArgs args) =>
            {

            };

          window.Run();
        }
    }
}
