using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows;

namespace WPFInDoorLib
{
    public class GridShowModel : DependencyObject
    {
        
        public GridShowModel(double panelW, double panelH)
        {
            PanelW = panelW;
            PanelH = PanelW;
        }
        //MAXY
        public static readonly DependencyProperty MaxYProperty =
            DependencyProperty.Register("MaxY", typeof(double), typeof(GridShowModel), new PropertyMetadata(), ValidateValueCallback_MaxY);

        static bool ValidateValueCallback_MaxY(object value)
        {
            return true;
        }
        public double MaxY
        {
            get { return (double)GetValue(MaxYProperty); }
            set { SetValue(MaxYProperty, value); }
        }

        //MINY
        public static readonly DependencyProperty MinYProperty =
            DependencyProperty.Register("MinY", typeof(double), typeof(GridShowModel), new PropertyMetadata(), ValidateValueCallback_MinY);

        static bool ValidateValueCallback_MinY(object value)
        {
            return true;
        }
        public double MinY
        {
            get { return (double)GetValue(MinYProperty); }
            set { SetValue(MinYProperty, value); }
        }

        //Panel width
        public static readonly DependencyProperty PanelWProperty =
            DependencyProperty.Register("PannelW", typeof(double), typeof(GridShowModel), new PropertyMetadata(), ValidateValueCallback_PanelW);

        static bool ValidateValueCallback_PanelW(object value)
        {
            return true;
        }
        public double PanelW
        {
            get { return (double)GetValue(PanelWProperty); }
            set { SetValue(PanelWProperty, value); }
        }
        
        //Panel heigh
        public static readonly DependencyProperty PanelHProperty =
            DependencyProperty.Register("PanelH", typeof(double), typeof(GridShowModel), new PropertyMetadata(), ValidateValueCallback_PanelH);

        static bool ValidateValueCallback_PanelH(object value)
        {
            return true;
        }
        public double PanelH
        {
            get { return (double)GetValue(PanelHProperty); }
            set { SetValue(PanelHProperty, value); }
        }
    }

}
