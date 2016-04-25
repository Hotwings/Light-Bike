using Microsoft.Graphics.Canvas.UI.Xaml;
using Windows.UI;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Light_Bike
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}

		void canvasControl_Draw(CanvasControl sender, CanvasDrawEventArgs args)
		{
			args.DrawingSession.DrawEllipse(155, 115, 80, 30, Colors.Black, 3);
			args.DrawingSession.DrawText("Hello, world!", 100, 100, Colors.Yellow);

		}
	}
}
