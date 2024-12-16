using Windows.UI.Xaml;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Chess.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChessCanvas
    {
        public ChessCanvas()
        {
            this.InitializeComponent();
        }

        private void loadChessBackground(object sender, RoutedEventArgs e)
        {
            this.drawChessBackground(8, 8);
        }

        private void drawChessBackground(int row, int column)
        {
            double cellWidth = this.canvas.Width / column;
            double cellHeight = this.canvas.Height / row;

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Rectangle rect = new Rectangle
                    {
                        Width = cellWidth,
                        Height = cellHeight,
                        Fill = (r + c) % 2 == 0
                            ? new SolidColorBrush(Windows.UI.Colors.Khaki)
                            : new SolidColorBrush(Windows.UI.Colors.Chocolate)
                    };
                    Canvas.SetLeft(rect, c * cellWidth);
                    Canvas.SetTop(rect, r * cellHeight);
                    this.canvas.Children.Add(rect);
                }
            }
        }
    }
}
