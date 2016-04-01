using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PathButton
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class PathButton : Button
    {
        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PathData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PathDataProperty =
            DependencyProperty.Register("PathData", typeof(Geometry), typeof(PathButton), new PropertyMetadata(new PathGeometry()));

        public Brush DefaultFillBrush
        {
            get { return (Brush)GetValue(DefaultFillBrushProperty); }
            set { SetValue(DefaultFillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DefaultFillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DefaultFillBrushProperty =
            DependencyProperty.Register("DefaultFillBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.DarkGray));

        public Brush MouseOverBrush
        {
            get { return (Brush)GetValue(MouseOverBrushProperty); }
            set { SetValue(MouseOverBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBrushProperty =
            DependencyProperty.Register("MouseOverBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.DeepSkyBlue));

        public Brush IsPressedBrush
        {
            get { return (Brush)GetValue(IsPressedBrushProperty); }
            set { SetValue(IsPressedBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsPressedBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPressedBrushProperty =
            DependencyProperty.Register("IsPressedBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.DodgerBlue));

        public Brush IsEnabledBrush
        {
            get { return (Brush)GetValue(IsEnabledBrushProperty); }
            set { SetValue(IsEnabledBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsEnabledBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEnabledBrushProperty =
            DependencyProperty.Register("IsEnabledBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.LightGray));

        public PathButton()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
