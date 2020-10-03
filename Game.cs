using System;
using System.Drawing;

class NewGame
{
  static void Main(string[] args)
  {
    Engine.Settings settings = new Engine.Settings();
    //settings.height = 450;
    //settings.width = 800;
    //settings.titleText = "yay";

    Engine.Game game = new Engine.Game(settings);

    //Image spriteSheet1 = Engine.Assets.ImageAsset("spritesheet.png");

    game.DrawSprite("spritesheet.png", 0, 0);
    game.DrawSprite("spritesheet.png", 50, 50);

    game.Start();
  }
}