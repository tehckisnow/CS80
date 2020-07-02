//new engine
//TODO:
//empty constructor for Game

using System;
using System.Windows.Forms;
using System.Drawing;
//using System.Threading.Tasks;

namespace Cs80
{
  public class Engine
  {

    public class Game : Form
    {
      public Settings settings;
      public Graphics g;

      public Game(Settings settings)
      {
        this.settings = settings;
        Init();
      }

      void Init()
      {
        //Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Text = settings.titleText;
        ClientSize = new Size(settings.width, settings.height);
        Paint += new PaintEventHandler(OnPaint);
        CenterToScreen();
      }

      public void Start()
      {
        Application.Run(this);
        //this.Frame();
      }

      private void OnPaint(object sender, PaintEventArgs e)
      {
        g = e.Graphics;
      }

      public static void DrawSprite(Image image, float destinationX, float destinationY, float targetX, float targetY, float width, float height)
      {
        RectangleF sourceRect = new RectangleF(targetX, targetY, width, height);
        //g.DrawImage(image, destinationX, destinationY, sourceRect, GraphicsUnit.Pixel);
      }

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

    public class Assets
    {
      public static Image ImageAsset(string file)
      {
        return Image.FromFile(file);
      }
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