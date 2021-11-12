using System;
using GLFW;
using static OpenGL.Gl;

namespace SharpEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Glfw.Init();

            var window = Glfw.CreateWindow(1024, 768, "Emirs Program", Monitor.None, Window.None);
            Glfw.MakeContextCurrent(window);
            Import(Glfw.GetProcAddress);

            float[] vertices = new float[]
            {
                -.5f, -.5f, 0f,
                .5f, -.5f, 0f,
                0f, .5f, 0f
            };

            var vertexArray = glGenVertexArray();
            var vertexBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER,vertexBuffer);
            
            unsafe 
            {
                fixed (float* vertex = &vertices[0]) 
                {
                    glBufferData(GL_ARRAY_BUFFER, sizeof(float)* vertices.Length, vertex, GL_STATIC_DRAW);
                }
            }

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
