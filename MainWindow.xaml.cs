using DemoAnchiano.Controller.CommandImplementations;
using DemoAnchiano.Data;
using DemoAnchiano.Pages;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace DemoAnchiano
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Frame _mainFrame;
        public MainWindow()
        {
            InitializeComponent();
            _mainFrame = MainFrame;
            ToMainScreen();

        }

        public static void ToMainScreen() {
            if (_mainFrame == null) { return; }
            _mainFrame.Navigate(new MainScreen());

        }

        public static void ToEmotionScreen(AUser userToSeeEmotionsOf)
        {
            if (_mainFrame == null) { return; }
            _mainFrame.Navigate(new UserEmotions(userToSeeEmotionsOf));

        }


    }
}