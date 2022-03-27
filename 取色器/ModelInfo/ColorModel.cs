using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 取色器.ViewModel;

namespace 取色器.ModelInfo
{
    public class ColorModel : ViewModelBase
    {
        public ColorModel() { }
        public ColorModel(int _r,int _g,int _b,int _a)
        {
            this.r = _r;
            this.g = _g;
            this.b = _b;
            this.a = _a;
        }

        private int r;
        public int R
        {
            get { return r; }
            set
            { 
                 r = value;
                OnPropertyChanged("R");
            }
        }
        private int g;
        public int G
        {
            get { return g; }
            set
            {
                g = value;
                OnPropertyChanged("G");
            }
        }
        private int b;
        public int B
        {
            get { return b; }
            set
            {
                b = value;
                OnPropertyChanged("B");
            }
        }
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                a = value;
                OnPropertyChanged("A");
            }
        }
        
    }
}
