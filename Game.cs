//new game.cs
using System;
using Cs80;

class NewGame
{
  static void Main(string[] args)
  {
    Engine.Settings settings = new Engine.Settings();
    settings.height = 450;
    settings.width = 800;
    settings.titleText = "success!";
    
    Engine.Game game1 = new Engine.Game(settings);

    Console.Write(game1.settings.width);

    var spriteSheet = Engine.Assets.ImageAsset("spritesheet.png");

    game1.Start();
  }

}

//------------
//extension methods
//  these methods are added to engine instance
public static class extensions
{
  public static void Frame(this Engine.Game game)
  {
    ////var spriteSheet = engine.ImageAsset("spritesheet.png");
    //game.DrawSprite(spriteSheet, 16, 16, 16, 16, 16, 16);
  }
}