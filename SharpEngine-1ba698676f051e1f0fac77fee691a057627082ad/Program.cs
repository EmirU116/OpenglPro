using System;
using GLFW;

namespace SharpEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Glfw.Init();

            var window = Glfw.CreateWindow(1024, 768, "Emirs Program", Monitor.None, Window.None);
            Glfw.MakeContextCurrent(window);

            while (!Glfw.WindowShouldClose(window))
            {
                Glfw.PollEvents(); // Reacts to window changes (position etc.)
                // do nothing
            }
            {
                
            }
        }
    }
}
