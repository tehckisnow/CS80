using Cs80;

class Game
{

  static void Main(string[] args)
  {
    Engine.Settings settings = new Engine.Settings();
    settings.height = 450;
    settings.width = 800;
    settings.titleText = "woot!";
    Engine engine = new Engine(settings);

    var spriteSheet = engine.ImageAsset("spritesheet.png");

    engine.Start();
  }

}

//extension methods
//  these methods are added to engine instance
public static class extensions
{
  public static void Frame(this Engine engine)
  {
    //engine.DrawSprite(spriteSheet, 16, 16, 16, 16, 16, 16);
  }
}