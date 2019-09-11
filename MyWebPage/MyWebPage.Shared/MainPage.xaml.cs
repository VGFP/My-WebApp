using MyWebPage.Shared.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyWebPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            showMessage();
            ContentFrame.Navigate(typeof(HomePage));
        }
        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(MainPage));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                switch (item.Tag.ToString())
                {
                    case "mltag":
                        ContentFrame.Navigate(typeof(MachineLearningPage));
                        break;
                    case "xamtag":
                        ContentFrame.Navigate(typeof(XamarinAppsPage));
                        break;
                    case "scitag":
                        ContentFrame.Navigate(typeof(ScienceProjectsPage));
                        break;
                    case "gametag":
                        ContentFrame.Navigate(typeof(GameofLifePage));
                        break;
                    case "mainpage":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                    
                }
               
            }
        }
        private async void showMessage()
        {
            var messageDialog = new MessageDialog("Due to the fact that this site is an application written in C# and XAML and then converted to WebAssembly, it is not as well optimized as a website written in JavaScript and HTML. It is recomended to open this website in Google Chrome and on large widescreen monitor.");
            await messageDialog.ShowAsync();
        }
    }
}
/*
 <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <RelativePanel>
            <Button x:Name="HamburgerButton" Content="&#xE700;" FontFamily="Segoe MDL2 Assets" FontSize="36"  Click="HamburgerButtonClicked"/>
        </RelativePanel>
        <SplitView Grid.Row="1" x:Name="MySplitView" DisplayMode="CompactOverlay" OpenPaneLength="200" CompactPaneLength="56" HorizontalAlignment="Left">
            <SplitView.Pane>
                <ListBox SelectionMode="Single" Name="MyListBox">
                    <ListBoxItem>
                        <StackPanel Orientation="Horizontal">
                            <TextBlock Text="&#xE99A;" FontSize="36" FontFamily="Segoe MDL2 Assets"/>
                            <TextBlock Text="  Machine Learning"/>
                        </StackPanel>
                    </ListBoxItem>
                    <StackPanel Orientation="Horizontal">
                        <TextBlock FontSize="36" Text="&#xED35;" FontFamily="Segoe MDL2 Assets"/>
                        <TextBlock Text="  Xamarin Apps"/>
                    </StackPanel>
                    <ListBoxItem>
                        <StackPanel Orientation="Horizontal">
                            <TextBlock FontSize="36" Text="&#xEA80;" FontFamily="/Assets/Fonts/SegMDL2.ttf#Segoe MDL2 Assets"/>
                            <TextBlock Text="  Science Projects"/>
                        </StackPanel>
                    </ListBoxItem>
                </ListBox>
            </SplitView.Pane>
        </SplitView>
*/
