using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControl
{
    public partial class UserColorControl : UserControl
    {
        private Color colorValue;

        protected event EventHandler ColorValueChanged;

        public Color ColorValue
        {
            get { return colorValue; }
            set
            {
                colorValue = Color.FromArgb(colorNumberBoxRed.ColorValue,
                                            colorNumberBoxGreen.ColorValue,
                                            colorNumberBoxBlue.ColorValue);
                if (!(ColorValueChanged is null))
                    ColorValueChanged.Invoke(this, new EventArgs());
            }
        }
        public UserColorControl()
        {
            InitializeComponent();
        }

       
    }
}
