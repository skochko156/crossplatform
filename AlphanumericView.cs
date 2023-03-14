using System;
using Gtk;
namespace MVC_pattern
{
    public class AlphanumericView
    {
        private DataModel model;

        public AlphanumericView(DataModel model)
        {
            this.model = model;
        }

        public void DisplayData()
        {
            Console.WriteLine("Alphanumeric Mode:");
            Console.WriteLine(model.GetData());
        }

        public string GetInput()
        {
            Console.Write("Enter new data: ");
            return Console.ReadLine();
        }
    }
}
