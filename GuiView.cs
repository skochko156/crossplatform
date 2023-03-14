using System;
using Gtk;
namespace MVC_pattern
{
    public class GuiView
    {
        private DataModel model;
        private Window window;
        private Entry entry;

        public GuiView(DataModel model)
        {
            this.model = model;

            Application.Init();
            window = new Window("GUI Mode");
            window.Resize(200, 100);

            entry = new Entry(model.GetData());
            entry.Changed += OnEntryChanged;

            window.Add(entry);
            window.ShowAll();
            Application.Run();
        }

        private void OnEntryChanged(object sender, EventArgs e)
        {
            model.SetData(entry.Text);
        }

        public void DisplayData()
        {
            entry.Text = model.GetData();
        }

    }
}
