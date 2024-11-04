using DemoAnchiano.Controller.CommandImplementations;
using DemoAnchiano.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DemoAnchiano.Pages
{
    /// <summary>
    /// Interaction logic for UserEmotions.xaml
    /// </summary>
    public partial class UserEmotions : Page
    {
        private AUser _usersEmotions;
        public UserEmotions(AUser usersEmotions)
        {
            InitializeComponent();
            _usersEmotions = usersEmotions;
            refresh();
        }



        private void ReturnButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.ToMainScreen();
        }


        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {

            Button? updateButton = sender as Button;
            if (updateButton == null) { return; }

            StackPanel row = (StackPanel)updateButton.Parent;

      
            int id = 0;
            int userID = 0;
            string? emotionName = "";
            int level = 0;
            string? color = "";
            DateTime timeCreated = DateTime.MinValue;
            foreach (UIElement ui in row.Children)
            {
                Debug.WriteLine(ui.GetType());

                if (ui.GetType() == typeof(TextBlock))
                {
                    TextBlock textBlock = (TextBlock)ui;

                    Debug.WriteLine(textBlock.Text);

                    if (textBlock.Name == "EmotionName") { emotionName = textBlock.Text; }
                    if (textBlock.Name == "TimeCreated") { timeCreated = DateTime.Parse(textBlock.Text); }
                    if (textBlock.Name == "UserID") { userID = Int32.Parse(textBlock.Text); }
                    if (textBlock.Name == "ID") { id = Int32.Parse(textBlock.Text); }
                }

                if (ui.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)ui;

                    Debug.WriteLine(textBox.Text);
                    if (textBox.Name == "level") { level = Int32.Parse(textBox.Text); }
                    if (textBox.Name == "color") { color = textBox.Text; }



                }




            }

            new UpdateEmotionCommand(new AEmotion(id,userID,emotionName,timeCreated,level,color)).execute();
            refresh();


        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            Button? updateButton = sender as Button;
            if (updateButton == null) { return; }

            StackPanel row = (StackPanel)updateButton.Parent;

            int id = 0;
            int userID = 0;
            string? emotionName = "";
            int level = 0;
            string? color = "";
            DateTime timeCreated = DateTime.MinValue;
            foreach (UIElement ui in row.Children)
            {
                Debug.WriteLine(ui.GetType());

                if (ui.GetType() == typeof(TextBlock))
                {
                    TextBlock textBlock = (TextBlock)ui;

                    Debug.WriteLine(textBlock.Text);

                    if (textBlock.Name == "EmotionName") { emotionName = textBlock.Text; }
                    if (textBlock.Name == "TimeCreated") { timeCreated = DateTime.Parse(textBlock.Text); }
                    if (textBlock.Name == "UserID") { userID = Int32.Parse(textBlock.Text); }
                    if (textBlock.Name == "ID") { id = Int32.Parse(textBlock.Text); }

                }

                if (ui.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)ui;

                    Debug.WriteLine(textBox.Text);
                    if (textBox.Name == "level") { level = Int32.Parse(textBox.Text); }
                    if (textBox.Name == "color") { color = textBox.Text; }



                }




            }

            new DeleteEmotionCommand(new AEmotion(id,userID, emotionName, timeCreated, level, color)).execute();
            refresh();
        }
        private void CreateButtonClick(object sender, RoutedEventArgs e)
        {
            new CreateEmotionCommand(_usersEmotions.ID,EmotieNaam.Text, (int)EmotieLevel.Value,EmotieKleur.Text).execute();
            refresh();
        }
        private void refresh()
        {

            new ReadEmotionsCommand(UsersList,_usersEmotions).execute();


        }
    }
}
