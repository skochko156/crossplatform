using System;
using Gtk;
namespace MVC_pattern
{
    public class Controller
    {
        private DataModel model;
        private IView view;

        public Controller(DataModel model, IView view)
        {
            this.model = model;
            this.view = view;

            this.view.UpdateView(model.GetData());
        }

        public void SetData(string data)
        {
            this.model.SetData(data);
            this.view.UpdateView(this.model.GetData());
        }
    }
}
