using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFInDoorLib;
using WPFInDoorLib.Controls;
using System.Windows;

namespace WPFInDoor.ViewModels
{
    public class GridShowViewModel:ControlBase
    {
        public GridShowViewModel()
        {
            _ItemList = new List<ItemClass>();
            _ItemList.Add(new ItemClass(Execute1) { itemType = ItemType.Button});
            _ItemList.Add(new ItemClass(Execute1) { itemType = ItemType.CheckBox });
        }

        GridShowModel gridShowModel = new GridShowModel(400,400);


        private List<ItemClass> _ItemList;
        public List<ItemClass> ItemList
        { 
            get
            {
                return _ItemList;
            }
            set
            {
                _ItemList = value;
                OnPropertyChanged("ItemList");   
            }
        }

        private void Execute1()
        {
            MessageBox.Show("templateselector is on.");
        }
        
    }
}
