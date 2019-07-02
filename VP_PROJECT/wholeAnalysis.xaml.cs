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
using System.Windows.Shapes;

namespace VP_PROJECT
{
    /// <summary>
    /// Interaction logic for wholeAnalysis.xaml
    /// </summary>
    public partial class wholeAnalysis : Window
    {
       
        public wholeAnalysis()
        {
            InitializeComponent();
        }
        public wholeAnalysis(double sc, double sad, double joy, double fear, double dis, double ang)
        {
            InitializeComponent();
            this.score.Content = sc.ToString();
            this.sadness.Content = sad.ToString();
            this.joy.Content = joy.ToString();
            this.fear.Content = fear.ToString();
            this.disgust.Content = dis.ToString();
            this.anger.Content = ang.ToString();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
