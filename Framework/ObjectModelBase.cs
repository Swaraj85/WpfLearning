using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public abstract class ObjectModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName=null)
        {
            var localPrpertyChanged = PropertyChanged;
            localPrpertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
