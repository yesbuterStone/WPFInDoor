using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPFInDoorLib.Controls
{
    public class ControlBase:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string paraname)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this,new PropertyChangedEventArgs(paraname));
            }
        }
    }
}
