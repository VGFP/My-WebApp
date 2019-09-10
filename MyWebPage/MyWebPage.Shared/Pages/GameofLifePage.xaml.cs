using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

using GameofLife;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyWebPage.Shared.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GameofLifePage : Page
    {
        bool isloopON;

        GameOfLifeController lifeController = new GameOfLifeController();
        private void displayGame()
        {
            for (int i = 0; i < 10; i++)
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Horizontal;

                for (int j = 0; j < 10; j++)
                {
                    Rectangle aliveRectangle = new Rectangle
                    {
                        Fill = new SolidColorBrush(Windows.UI.Colors.Black),
                        Height = 50,
                        Width = 50

                    };
                    Rectangle deadRectangle = new Rectangle
                    {
                        Fill = new SolidColorBrush(Colors.AntiqueWhite),
                        Height = 50,
                        Width = 50
                    };

                    if (lifeController.gamearray[i, j] == 1)
                    {
                        stackPanel.Children.Add(aliveRectangle);
                    }
                    else
                    {
                        stackPanel.Children.Add(deadRectangle);
                    }
                }
                gamePanel.Children.Add(stackPanel);
            }
        }
        private void clearPanel()
        {
            gamePanel.Children.Clear();
        }
        public GameofLifePage()
        {
            this.InitializeComponent();
            displayGame();
            isloopON = false;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {

            //left for debug
            /*for (int i = 0; i < 10; i++)
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Horizontal;
                string locstr="";
                TextBlock textBlock = new TextBlock
                {
                    FontSize = 24
                };
                for (int j = 0; j < 10; j++)
                {
                    if (lifeController.gamearray[i, j] == 1)
                    {
                        locstr = locstr + "1";
                    }
                    else
                    {
                        locstr = locstr + "0";
                    }
                    locstr = locstr + lifeController.gamearray[i, j];
                }
                textBlock.Text = locstr;
                gamePanel.Children.Add(textBlock);
            }*/
            clearPanel();
            lifeController.newlifecicle();
            displayGame();
        }



    }
}

