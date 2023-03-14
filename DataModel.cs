using System;
using Gtk;
namespace MVC_pattern
{
    public class DataModel
    {
        private string data;

        public DataModel(string data)
        {
            this.data = data;
        }

        public string GetData()
        {
            return data;
        }

        public void SetData(string data)
        {
            this.data = data;
        }
    }

}
