using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace HouresWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DateTime CurrentTime;
        static Thread timer;
        public MainWindow()
        {
            InitializeComponent();
            //SetArrows();

            timer = new Thread(new ThreadStart(TimeUpdateThread));
            timer.Start();
        }
        public void SetArrows()
        {
            RotateTransform rotate = new RotateTransform(-90,
                                                         HoursArrow.RenderTransformOrigin.X,
                                                         HoursArrow.RenderTransformOrigin.Y);


            HoursArrow.RenderTransform = rotate;

            rotate = new RotateTransform(-90,
                                                         MinutesArrow.RenderTransformOrigin.X,
                                                         MinutesArrow.RenderTransformOrigin.Y);
            MinutesArrow.RenderTransform = rotate;

            rotate = new RotateTransform(-90,
                                                         SecondsArrow.RenderTransformOrigin.X,
                                                         SecondsArrow.RenderTransformOrigin.Y);

            SecondsArrow.RenderTransform = rotate;

        }
        public void RefreshArrows()
        {
            float hours = 360 * DateTime.Now.Hour / 12 - 90;
            float minutes = 360 * DateTime.Now.Minute / 60 - 90;
            float seconds = 360 * DateTime.Now.Second / 60 - 90;

            RotateTransform rotate = new RotateTransform(hours);//,
                                                         //SecondsArrow.RenderTransformOrigin.X,
                                                        // SecondsArrow.RenderTransformOrigin.Y);


            HoursArrow.RenderTransform = rotate;

            rotate = new RotateTransform(minutes);
            MinutesArrow.RenderTransform = rotate;

            rotate = new RotateTransform(seconds);

            SecondsArrow.RenderTransform = rotate;
        }


        public delegate void UpdateTime();

        private void TimeUpdateThread()
        {

            while (true)
            {
                Thread.Sleep(1000);
                this.Dispatcher.Invoke(new UpdateTime(this.RefreshArrows));
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            timer.Abort();
        }
    }
}
