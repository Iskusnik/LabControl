using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LabControl
{
    public partial class ColorNumberBox : TextBox
    {
        protected event EventHandler NumberFormatChanged;

        public byte ColorValue;
        private bool decFormat;
        
        public bool DecFormat
        {
            get { return decFormat; }
            set
            {
                decFormat = value;
                if(!(this.NumberFormatChanged is null))
                    this.NumberFormatChanged.Invoke(this, new EventArgs());
            }
        }

        public ColorNumberBox()
        {
            decFormat = true;

            this.NumberFormatChanged += FormatChanged;

            Text = "";

            InitializeComponent();
        }

        public ColorNumberBox(IContainer container)
        {
            decFormat = true;

            this.NumberFormatChanged += FormatChanged;

            Text = "";

            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {

            if (DecFormat)
            {
                try
                {
                    ColorValue = byte.Parse(Text);
                }
                catch (Exception)
                {
                    int result = 0;
                    if (int.TryParse(Text, out result))
                    {
                        if (result > 255)
                            ColorValue = 255;

                        if (result < 0)
                            ColorValue = 0;

                    }
                }

                Text = ColorValue.ToString();
            }
            else
            {
                try
                {
                    ColorValue = Convert.ToByte(Text, 16);
                }
                catch (Exception)
                {
                    try
                    {
                        int result = Convert.ToInt32(Text, 16);

                        if (result > 255)
                            ColorValue = 255;

                        if (result < 0)
                            ColorValue = 0;


                    }
                    catch (Exception)
                    {
                    }
                }

                Text = ColorValue.ToString("X");
            }

            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (DecFormat)
                if (!char.IsDigit(e.KeyChar) &&
                    !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            else
                if (!char.IsDigit(e.KeyChar) &&
                    !"abcdefABCDEF".Contains(e.KeyChar) &&
                    !char.IsControl((e.KeyChar)))
                    e.Handled = true;

            base.OnKeyPress(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void FormatChanged(object sender, EventArgs e)

        {
            if (DecFormat)
                Text = ColorValue.ToString();
            else
                Text = ColorValue.ToString("X");
        }
    }
}
