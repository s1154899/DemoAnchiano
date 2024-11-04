using DemoAnchiano.Controller;
using DemoAnchiano.Controller.CommandImplementations;
using DemoAnchiano.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace DemoAnchiano.Pages
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Page
    {
        public MainScreen()
        {
            InitializeComponent();
            new ReadUserCommand(UsersList).execute();
        }

        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {

            Button? updateButton = sender as Button;
            if (updateButton == null) { return; }

            StackPanel row = (StackPanel)updateButton.Parent;

            int id = 0;
            string name = "";
            int age = 0;
            DateTime subcribeDate = DateTime.MinValue;
            bool isActive = false;


            foreach (UIElement ui in row.Children)
            {
                Debug.WriteLine(ui.GetType());

                if (ui.GetType() == typeof(TextBlock))
                {
                    TextBlock textBlock = (TextBlock)ui;

                    Debug.WriteLine(textBlock.Text);
                    id = Int32.Parse(textBlock.Text);
                }

                if (ui.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)ui;

                    Debug.WriteLine(textBox.Text);
                    if (textBox.Name == "TextBloXName") { name = textBox.Text; }
                    if (textBox.Name == "TextBloXAge") { age = Int32.Parse(textBox.Text); }
                    if (textBox.Name == "TextBloXTimeSubscribed") { subcribeDate = DateTime.Parse(textBox.Text); }



                }

                if (ui.GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)ui;

                    Debug.WriteLine(checkBox.IsChecked);

                    isActive = checkBox.IsChecked != null ? (bool)checkBox.IsChecked : false;

                }


            }

            new UpdateUserCommand(new AUser(id, name, age, subcribeDate, isActive)).execute();
            refresh();


        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            Button? updateButton = sender as Button;
            if (updateButton == null) { return; }

            StackPanel row = (StackPanel)updateButton.Parent;

            int id = 0;
            string name = "";
            int age = 0;
            DateTime subcribeDate = DateTime.MinValue;
            bool isActive = false;


            foreach (UIElement ui in row.Children)
            {
                Debug.WriteLine(ui.GetType());

                if (ui.GetType() == typeof(TextBlock))
                {
                    TextBlock textBlock = (TextBlock)ui;

                    Debug.WriteLine(textBlock.Text);
                    id = Int32.Parse(textBlock.Text);
                }

                if (ui.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)ui;

                    Debug.WriteLine(textBox.Text);
                    if (textBox.Name == "TextBloXName") { name = textBox.Text; }
                    if (textBox.Name == "TextBloXAge") { age = Int32.Parse(textBox.Text); }
                    if (textBox.Name == "TextBloXTimeSubscribed") { subcribeDate = DateTime.Parse(textBox.Text); }



                }

                if (ui.GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)ui;

                    Debug.WriteLine(checkBox.IsChecked);

                    isActive = checkBox.IsChecked != null ? (bool)checkBox.IsChecked : false;

                }


            }

            new DeleteUserCommand(new AUser(id, name, age, subcribeDate, isActive)).execute();
            refresh();
        }
        private void CreateButtonClick(object sender, RoutedEventArgs e)
        {
            new CreateUserCommand(new AUser(0, NaamNieuweGebruiker.Text, Int32.Parse(LeeftijdNieuweGebruiker.Text), DateTime.Now, (bool)ActiefNieuweGebruiker.IsChecked != null ? (bool)ActiefNieuweGebruiker.IsChecked : false)).execute();
            refresh();
        }

        private void EmotiesButtonClick(object sender, RoutedEventArgs e) {
            Button? Button = sender as Button;
            if (Button == null) { return; }

            StackPanel row = (StackPanel)Button.Parent;

            int id = 0;
            string name = "";
            int age = 0;
            DateTime subcribeDate = DateTime.MinValue;
            bool isActive = false;


            foreach (UIElement ui in row.Children)
            {
                Debug.WriteLine(ui.GetType());

                if (ui.GetType() == typeof(TextBlock))
                {
                    TextBlock textBlock = (TextBlock)ui;

                    Debug.WriteLine(textBlock.Text);
                    id = Int32.Parse(textBlock.Text);
                }

                if (ui.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)ui;

                    Debug.WriteLine(textBox.Text);
                    if (textBox.Name == "TextBloXName") { name = textBox.Text; }
                    if (textBox.Name == "TextBloXAge") { age = Int32.Parse(textBox.Text); }
                    if (textBox.Name == "TextBloXTimeSubscribed") { subcribeDate = DateTime.Parse(textBox.Text); }



                }

                if (ui.GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)ui;

                    Debug.WriteLine(checkBox.IsChecked);

                    isActive = checkBox.IsChecked != null ? (bool)checkBox.IsChecked : false;

                }


            }

            MainWindow.ToEmotionScreen(new AUser(id, name, age, subcribeDate, isActive));

        }
        private void refresh()
        {

            new ReadUserCommand(UsersList).execute();


        }

        private void ShowOldActionsClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CommandController.GetPastCommands());
        }
    }
}
