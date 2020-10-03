using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

public static class Engine
{
  public class Settings
    {
      public int width = 800;
      public int height = 450;
      public string titleText = "engine";
    }
  

  public class Game : Form
  {
    public Settings settings;
    public Graphics g;
    
    private ObjectsToRender objectsToRender = new ObjectsToRender();
    
    public Game(Settings settings)
    {
      this.settings = settings;
      Init();
    }
    
    public void Start()
    {
      Application.Run(this);
    }

    private void Init()
    {
      Application.EnableVisualStyles();
      Text = settings.titleText;
      ClientSize = new Size(settings.width, settings.height);
      Paint += new PaintEventHandler(OnPaint);
      CenterToScreen();
      g = this.CreateGraphics();
    }

    public void OnPaint(object sender, PaintEventArgs e)
    {
      Console.WriteLine("OnPaint");
      
      //sprites
      foreach(RenderEntity renderEntity in objectsToRender.renderEntities)
      {
        if(renderEntity.type == RenderType.sprite)
        {
          e.Graphics.DrawImage(renderEntity.image, renderEntity.x, renderEntity.y);
        }
        //...
      }
    }

    public void DrawSprite(string image, int x = 0, int y = 0, int z = 0)
    {
      //this adds image to "to be rendered" object
      this.objectsToRender.renderEntities.Add(new RenderEntity(RenderType.sprite, image, x, y, z));
    }
  }

  //public void DrawRect(int x, int y, int width, int height)
  //{
      //g.FillRectangle(Brushes.Sienna, 10, 15, 90, 60);
  //}

  public static class Assets
  {
    public static Image ImageAsset(string file)
    {
      return Image.FromFile(file);
    }
  }

  public enum RenderType
  {
    sprite,
    rect,
    circ,
    line
  } 

  //renderEntity
  public class RenderEntity
  {
    public RenderType type;
    public string filename;
    public Image image;
    public int x;
    public int y;
    public int z;
    public int width;
    public int height;

    //sprite
    public RenderEntity(RenderType type, string filename, int x = 0, int y = 0, int z = 0)
    {
      this.type = type;
      this.filename = filename;
      this.image = Image.FromFile(filename);
      this.x = x;
      this.y = y;
      this.z = z;
    }

    //rect
    //!fill and outline color
    public RenderEntity(RenderType type, int x, int y, int z, int width, int height)
    {
      this.type = type;
      this.x = x;
      this.y = y;
      this.z = z;
      this.width = width;
      this.height = height;
      //outline
      //fill
    }

  }

  //holds renderEntities (and other) and is accessed from OnPaint()
  public class ObjectsToRender
  {
    public List<RenderEntity> renderEntities = new List<RenderEntity>();
    //...
  }

}