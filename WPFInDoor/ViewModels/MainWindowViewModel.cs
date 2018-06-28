using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInDoor.ViewModels
{
    public class MainWindowViewModel
    {
        CanvasViewModel _helloWorld;
        public MainWindowViewModel()
        {
            _helloWorld = new CanvasViewModel();
        }


        public CanvasViewModel helloWord
        {
            get
            {
                return _helloWorld;
            } 
            set
            {
                _helloWorld = helloWord;
            }
        }
    }
}
