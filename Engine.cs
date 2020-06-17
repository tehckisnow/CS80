using System;
using System.Windows.Forms;
using System.Drawing;
//using System.Threading.Tasks;

namespace Cs80
{

  public class Engine : Form
  {

    //graphics object used to draw graphics
    Graphics g;

    public Engine(Settings settings)
    {
      //initialize engine with passed settings
      Init(settings);
      //call main game loop from extensions in game file
      this.Frame();
    }

    //uses default settings
    public Engine()
    {
      Settings settings = new Settings();
      Init(settings);
      this.Frame();
    }

    //default settings
    public class Settings
    {
      public int width = 800;
      public int height = 450;
      public string titleText = "engine";
      //!replace this method with generated getter
      public string getInfo()
      {
        return width.ToString() + " " + height.ToString() + " " + titleText;
      }
    }

    //call to start game
    public void Start()
    {
      Application.Run(this);
    }

    //create an image object
    public Image ImageAsset(string file)
    {
      return Image.FromFile(file);
    }

    //draw an image object
    public void DrawSprite(Image image, float destinationX, float destinationY, float targetX, float targetY, float width, float height)
    {
      RectangleF sourceRect = new RectangleF(targetX, targetY, width, height);
      g.DrawImage(image, destinationX, destinationY, sourceRect, GraphicsUnit.Pixel);
    }

    //initialization of engine
    private void Init(Settings settings)
    {
      //Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Text = settings.titleText;
      ClientSize = new Size(settings.width, settings.height);
      Paint += new PaintEventHandler(OnPaint);
      CenterToScreen();
    }

    //create and store graphics object from OnPaint event
    private void OnPaint(object sender, PaintEventArgs e)
    {
      g = e.Graphics;
    }

  }

}


//-----------------
//notes

    // [STAThread]
    
      //g.DrawImage(spriteSheet, x, y, sourceRect, units);
      //g.DrawImage(testImage, 100, 100);
      //g.FillRectangle(Brushes.Green, 130, 15, 90, 60);

      //Label
        // var lab = new Label();
        // lab.Parent = this;
        // lab.Text = "text test";
        // lab.Font = new Font("Serif", 10);
        // lab.Location = new Point(10, 10);
        // lab.AutoSize = true;
        // AutoSize = true;
