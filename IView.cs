using System;
using Gtk;
namespace MVC_pattern
{
    public interface IView
    {
        void UpdateView(string data);
        void Run();
    }

    public class AlphanumericView1 : IView
    {
        public void UpdateView(string data)
        {
            Console.WriteLine("Alphanumeric View: " + data);
        }
        public void Run()
        {
            Console.WriteLine("Running Alphanumeric Mode...");
        }
    }

    public class GuiView1 : IView
    {
        private Window window;
        private Label label;

        public GuiView1()
        {
            Application.Init();
            window = new Window("MVC Demo");
            window.Resize(200, 100);

            label = new Label();
            window.Add(label);

            window.ShowAll();
        }

        public void UpdateView(string data)
        {
            label.Text = "GUI View: " + data;
        }

        public void Run()
        {
            Application.Run();
        }
    }
}