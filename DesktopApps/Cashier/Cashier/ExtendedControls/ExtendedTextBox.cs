using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Cashier.ExtendedControls
{
    public class ExtendedTextBox : TextBox
    {
        private string placeHolder;
        public string PlaceHolder
        {
            get => placeHolder;
            set
            {
                placeHolder = value;
                Foreground = Brushes.Gray;
                Text = placeHolder;
            }
        }
        private string text = "";
        protected override void OnLostFocus(RoutedEventArgs e)
        {
            text = Text;
            if (string.IsNullOrWhiteSpace(Text))
            {
                Text = PlaceHolder;
                Foreground = Brushes.Gray;
            }
            else text = Text;
            base.OnLostFocus(e);
        }
        protected override void OnGotFocus(RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Text = "";
                Foreground = Brushes.Black;
            }
            base.OnGotFocus(e);
        }
        public ExtendedTextBox()
        {
            VerticalContentAlignment = VerticalAlignment.Center;
        }
    }
}
