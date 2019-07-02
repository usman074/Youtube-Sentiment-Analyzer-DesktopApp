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
    /// Interaction logic for Individual.xaml
    /// </summary>
    public partial class Individual : Window
    {
        int btn_click = -1;
        List<AnalysisResult> receiveData;
        public Individual()
        {
            InitializeComponent();
        }
        public Individual(List<AnalysisResult> listtt)
        {
           
            InitializeComponent();
            if (btn_click == -1)
            {
                prevBtn.IsEnabled = false;
                nextBtn.IsEnabled = false;
            }
            receiveData = listtt;
            int x =receiveData.Count;
            
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            nextBtn.IsEnabled = true;
            btn_click = btn_click - 1;
            if (btn_click > -1)
            {

                label.Content = receiveData[btn_click].Label;
                sadness.Content = receiveData[btn_click].Sadness;
                joy.Content = receiveData[btn_click].Joy;
                anger.Content = receiveData[btn_click].Anger;
                disgust.Content = receiveData[btn_click].Disgust;
                fear.Content = receiveData[btn_click].Fear;
                score.Content = receiveData[btn_click].Score;
            }
            else
            {
                btn_click++;
                prevBtn.IsEnabled = false;
                MessageBox.Show("No more comments");
            }
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            btn_click = 0;
            label.Content = receiveData[0].Label;
            sadness.Content = receiveData[0].Sadness;
            joy.Content = receiveData[0].Joy;
            anger.Content = receiveData[0].Anger;
            disgust.Content = receiveData[0].Disgust;
            fear.Content = receiveData[0].Fear;
            score.Content = receiveData[0].Score;
            if (btn_click == 0)
            {
                
                nextBtn.IsEnabled = true;
                prevBtn.IsEnabled = false;
            }
            

        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            btn_click = btn_click + 1;
            if (btn_click < receiveData.Count)
            {
                label.Content = receiveData[btn_click].Label;
                sadness.Content = receiveData[btn_click].Sadness;
                joy.Content = receiveData[btn_click].Joy;
                anger.Content = receiveData[btn_click].Anger;
                disgust.Content = receiveData[btn_click].Disgust;
                fear.Content = receiveData[btn_click].Fear;
                score.Content = receiveData[btn_click].Score;
                //btn_click++;
            }
            else
            {
                btn_click = btn_click-1;
                nextBtn.IsEnabled = false;
                MessageBox.Show("No more comments");
            }
            
           
            if (btn_click == 1)
            {
                prevBtn.IsEnabled = true;
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {

            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
