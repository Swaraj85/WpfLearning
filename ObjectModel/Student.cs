using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Student: ObjectModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }


        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                _age = value;
                NotifyPropertyChanged();
            }
        }
    }
}
