using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFInDoorLib.Command;

namespace WPFInDoorLib.Controls
{
    public class ItemClass:ControlBase
    {
        public ItemClass(Action a)
        {
            Doexecute = a;
            _execute = new RelayCommand(OnExecute);
        }

        private ItemType _itemType = ItemType.Button;
        public ItemType itemType
        {
            get
            {
                return _itemType;
            }
            set
            {
                _itemType = value;
                OnPropertyChanged("itemType");
            }
        }

        private ICommand _execute;
        public ICommand execute
        {
            get
            {
                return _execute;
            }
            set
            {
                _execute = value;
            }
        }

        private Action Doexecute;
        private void OnExecute(object para)
        {
            Doexecute?.Invoke();
        }
    }



    public enum ItemType
    {
        Button,
        CheckBox,
    }
}
