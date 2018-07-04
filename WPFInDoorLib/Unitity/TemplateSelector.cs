using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using WPFInDoorLib.Controls;

namespace WPFInDoorLib.Unitity
{
    public class TemplateSelector:DataTemplateSelector
    {
        public DataTemplate ButtonTemplate { get; set; }
        public DataTemplate CheckBoxTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            ItemClass temp = item as ItemClass;
            switch(temp.itemType)
            {
                case ItemType.Button:
                    return ButtonTemplate;
                case ItemType.CheckBox:
                    return CheckBoxTemplate;
                default:
                    break;

            }   
            return base.SelectTemplate(item, container);
        }

    }
}
