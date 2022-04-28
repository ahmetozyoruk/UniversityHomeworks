// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SkinnedApplication.MVCPattern;
using System.Windows;
using System.Windows.Controls;

namespace SkinnedApplication
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Add choices to combo box
            // Create the StackPanel 
            StackPanel stackPanel = new StackPanel();
            StackPanel stackPane2 = new StackPanel();
            this.Content = stackPanel;

            ComboBox skinComboBox = new ComboBox();
            skinComboBox.Name = "skinComboBox";
            skinComboBox.Width = 194;
            skinComboBox.Height = 30;

            skinComboBox.Items.Add("Blue");
            skinComboBox.Items.Add("Yellow");
            skinComboBox.SelectedIndex = 0;

            //ComboBoxItem item = new ComboBoxItem();
            //item.Content = "Coffie";

            //cbx.Items.Add(item);
            //cbx.Items.Add("Tea");
            //cbx.Items.Add("Orange");
            //cbx.Items.Add("Milk");


            // Create the TextBlock 
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Skin:";
            textBlock.Height = 20;
            textBlock.Width = 200;
            textBlock.Margin = new Thickness(5);
            stackPanel.Children.Add(textBlock);

            // Create the Button 
            Button button = new Button();
            button.Content = "newChildWindowButton";
            button.Height = 20;
            button.Width = 50;
            button.Margin = new Thickness(20);
            stackPanel.Children.Add(skinComboBox);
            stackPanel.Children.Add(button);
            
            stackPanel.Children.Add(stackPane2);

            // Set initial skin
            Application.Current.Resources = (ResourceDictionary) Application.Current.Properties["Blue"];
            button.Click += newChildWindowButton_Click;
            // Detect when skin changes
            skinComboBox.SelectionChanged += skinComboBox_SelectionChanged;
        }

        private void newChildWindowButton_Click(object sender, RoutedEventArgs e)
        {
            //IProje projectModel = new Proje();
            //IProjeView projectView = new ProjeView();

            ////projectModel.Lesson = "OOP";
            ////projectModel.project = "proje";
            ////projectModel.Time = "22 01 2020";

            //ProjeController projeContreller = new ProjeController(projectModel, projectView);
            //projeContreller.DisplayProjeInfo();


            // Create a new skind child window
            var window = new ChildWindow();
            window.Show();
        }

        private void skinComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Change the skin
            var selectedValue = (string) e.AddedItems[0];
            Application.Current.Resources = (ResourceDictionary) Application.Current.Properties[selectedValue];
        }
    }
}