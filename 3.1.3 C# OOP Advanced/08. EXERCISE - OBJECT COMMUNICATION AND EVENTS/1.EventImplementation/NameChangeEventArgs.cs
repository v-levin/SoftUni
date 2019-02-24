using System;

namespace _1.EventImplementation
{
    public class NameChangeEventArgs : EventArgs
    {
        private string _name;

        public NameChangeEventArgs(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
    }
}
