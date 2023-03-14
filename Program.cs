using System;
using Gtk;

namespace MVC_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel model = new DataModel("Initial data");

            // Alphanumeric mode
            IView alphanumericView = new AlphanumericView1();
            Controller alphanumericController = new Controller(model, alphanumericView);

            Console.WriteLine("Enter new data (alphanumeric mode): ");
            string newData = Console.ReadLine();
            alphanumericController.SetData(newData);

            // GUI mode
            IView guiView1 = new GuiView1();
            Controller guiController = new Controller(model, guiView1);
            guiView1.Run();
        }
    }
}
