using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace WpfAppEjemplo
{
    public partial class MainWindow : Window
    {
        //arreglar -> no funciona
        public MainWindow()
        {
            Grid mainGrid = new Grid();
            Button myButton = new Button
            {                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontWeight = FontWeights.Bold, 
                Padding = new Thickness(10)      
            };

            WrapPanel myWrapPanel = new WrapPanel();

            TextBlock tb1 = new TextBlock
            {
                Text = "Verde ",
                Foreground = Brushes.Green, 
                FontSize = 16
            };

            TextBlock tb2 = new TextBlock
            {
                Text = "Azul ",
                Foreground = Brushes.Blue, 
                FontSize = 16
            };

            TextBlock tb3 = new TextBlock
            {
                Text = "Sin formato",
                FontSize = 16
            };

            myWrapPanel.Children.Add(tb1);
            myWrapPanel.Children.Add(tb2);
            myWrapPanel.Children.Add(tb3);

            myButton.Content = myWrapPanel;

            mainGrid.Children.Add(myButton);

            this.Content = mainGrid;
        }
    }
}
