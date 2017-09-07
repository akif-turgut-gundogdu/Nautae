using CocosSharp;
using Nautae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nautae.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Simulation : ContentPage
    {
        GameScene gameScene;
        public Simulation()
        {
            {
                //This is the top - level grid, which will split our page in half

                 var grid = new Grid();
                this.Content = grid;
                grid.RowDefinitions = new RowDefinitionCollection {
            // Each half will be the same size:
            new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)},
            new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)},
        };
                CreateTopHalf(grid);
                CreateBottomHalf(grid);
            }
            void CreateTopHalf(Grid grid)
            {
                // This hosts our game view.
                var gameView = new CocosSharpView()
                {
                    // Notice it has the same properties as other XamarinForms Views
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    // This gets called after CocosSharp starts up:
                    ViewCreated = HandleViewCreated
                };
                // We'll add it to the top half (row 0)
                grid.Children.Add(gameView, 0, 0);
                
            }
            void HandleViewCreated(object sender, EventArgs e)
            {
                var gameView = sender as CCGameView;
                if (gameView != null)
                {
                    // This sets the game "world" resolution to 100x100:
                    gameView.DesignResolution = new CCSizeI(100, 100);
                    // GameScene is the root of the CocosSharp rendering hierarchy:
                    gameScene = new GameScene(gameView);
                    // Starts CocosSharp:
                    gameView.RunWithScene(gameScene);
                }
            }

            void CreateBottomHalf(Grid grid)
            {
                // We'll use a StackLayout to organize our buttons
                var stackLayout = new StackLayout();

                // The first button will move the circle to the left when it is clicked:
                var moveLeftButton = new Button
                {
                    Text = "Özellikler"
                };
                //moveLeftButton.Clicked += (sender, e) => gameScene.MoveCircleLeft();
                stackLayout.Children.Add(moveLeftButton);

                // The second button will move the circle to the right when clicked:
                var moveCircleRight = new Button
                {
                    Text = "Hesapla"
                };

                var windspeed = new Entry
                {
                    Placeholder = "Yelken Özellikleri"

                };

                var windDirection = new Entry
                {

                    Placeholder = "Rüzgarın geliş derecesini floğunuzu kerteriz alarak giriniz"

                };
                var windSpeed = new Entry
                {

                    Placeholder = "Rüzgarın hızını giriniz"

                };
  
                //moveCircleRight.Clicked += (sender, e) => gameScene.MoveCircleRight();
                stackLayout.Children.Add(moveCircleRight);
                stackLayout.Children.Add(windDirection);
                stackLayout.Children.Add(windspeed);

                //The stack layout will be in the bottom half(row 1):
                grid.Children.Add(stackLayout, 0, 1);
                grid.BackgroundColor = Constants.BackgroudColor;
            }
        }
    }
}
