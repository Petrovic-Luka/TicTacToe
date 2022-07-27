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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Potez = 0;
        private int ScoreX = 0;
        private int ScoreO = 0;
        public MainWindow()
        {
            InitializeComponent();
            ClearField();
            this.FontSize = this.Height / 25;
        }

        private void Field_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if(Potez==0)
            {
                b.Content = "X";
                b.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                Potez = 1;
                b.IsEnabled = false;
                if (RoundOver()) ClearField();
            }
            else
            {
                b.Content = "O";
                b.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                Potez = 0;
                b.IsEnabled = false;
                if (RoundOver()) ClearField();
            }
        }

        public bool RoundOver()
        {
            //check first row
            if (a1.Content == a2.Content && a1.Content == a3.Content && a1.Content != null && a1.Content.ToString() != "")
            {
                MessageBox.Show($"{a1.Content} wins");
                if (a1.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
            }
            // check 2nd row
            else if(b1.Content == b2.Content && b1.Content == b3.Content && b1.Content != null && b1.Content.ToString() != "")
             {
                MessageBox.Show($"{b1.Content} wins");
                if (b1.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
             }
            // check 3rd row
            else if (c1.Content == c2.Content && c1.Content == c3.Content && c1.Content != null && c1.Content.ToString() != "")
            {
                MessageBox.Show($"{c1.Content} wins");
                if (c1.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
            }
            // check 1st coll
            else if (a1.Content == b1.Content && a1.Content == c1.Content && a1.Content != null && a1.Content.ToString() != "")
            {
                MessageBox.Show($"{a1.Content} wins");
                if (a1.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
            }
            // check 2nd coll
            else if (a2.Content == b2.Content && a2.Content == c2.Content && a2.Content != null && a2.Content.ToString() != "")
            {
                MessageBox.Show($"{a2.Content} wins");
                if (a2.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
            }
            // check 3rd coll
            else if (a3.Content == b3.Content && a3.Content == c3.Content && a3.Content != null && a3.Content.ToString() != "")
            {
                MessageBox.Show($"{a3.Content} wins");
                if (a3.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
            }
            //main diagonal
            else if (a1.Content == b2.Content && a1.Content == c3.Content && a1.Content != null && a1.Content.ToString() != "")
            {
                MessageBox.Show($"{a1.Content} wins");
                if (a1.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
            }
            // other diagonal
            else if (a3.Content == b2.Content && a3.Content == c1.Content && a3.Content != null && a3.Content.ToString() != "")
            {
                MessageBox.Show($"{a3.Content} wins");
                if (a3.Content.ToString() == "X") ScoreX++;
                else ScoreO++;
                return true;
            }
            //if its tie
            if (a1.IsEnabled==false&&a2.IsEnabled == false && a3.IsEnabled == false &&
                 b1.IsEnabled ==false && b2.IsEnabled == false && b3.IsEnabled ==false &&
                 c1.IsEnabled == false && c2.IsEnabled ==false && c3.IsEnabled == false)
            {
                MessageBox.Show("Tie");
                return true;
            }
            return false;
        }

        public void ClearField()
        {
            Score.Text = $"Score X: {ScoreX} O: {ScoreO}";
            a1.Content = "";
            a1.IsEnabled = true;
            a2.Content = "";
            a2.IsEnabled = true;
            a3.Content = "";
            a3.IsEnabled = true;
            b1.Content = "";
            b1.IsEnabled = true;
            b2.Content = "";
            b2.IsEnabled = true;
            b3.Content = "";
            b3.IsEnabled = true;
            c1.Content = "";
            c1.IsEnabled = true;
            c2.Content = "";
            c2.IsEnabled = true;
            c3.Content = "";
            c3.IsEnabled = true;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.FontSize = this.Height / 25;
        }
    }
}
