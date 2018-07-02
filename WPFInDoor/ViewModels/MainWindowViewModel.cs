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
        GridShowViewModel _GridShow;
        public MainWindowViewModel()
        {
            _helloWorld = new CanvasViewModel();
            _GridShow = new GridShowViewModel();
        }

        public GridShowViewModel GridShow
        {
            get
            {
                return _GridShow;
            }
            set
            {
                _GridShow = value;
            }
        }

        public CanvasViewModel helloWord
        {
            get
            {
                return _helloWorld;
            } 
            set
            {
                _helloWorld = value;
            }
        }
    }
}
