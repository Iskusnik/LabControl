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
            ColorValueChanged += RefreshColorBox;
            InitializeComponent();
            radioButtonDec.Checked = true;
        }

        private void RefreshColorBox(object sender, EventArgs e)
        {
            pictureBoxColor.BackColor = ColorValue;
        }

        private void colorNumberBoxBlue_TextChanged(object sender, EventArgs e)
        {
            ColorValue = new Color();
        }

        private void colorNumberBoxGreen_TextChanged(object sender, EventArgs e)
        {
            ColorValue = new Color();
        }

        private void colorNumberBoxRed_TextChanged(object sender, EventArgs e)
        {
            ColorValue = new Color();
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            colorNumberBoxRed.DecFormat = radioButtonDec.Checked;
            colorNumberBoxGreen.DecFormat = radioButtonDec.Checked;
            colorNumberBoxBlue.DecFormat = radioButtonDec.Checked;
        }
    }
}
