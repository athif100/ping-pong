using Raylib_cs;
class paddle
{
    public float X;
    public float Y;
    public Rectangle rect = new Rectangle(50, 50, 30, 150);
    public void moveplayer()
    {
        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            Y -= 0.2f;
            rect.Y = Y;
        }
        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            Y += 0.2f;
            rect.Y = Y;
        }
        if (Y > 400)
        {
            Y = 0;
        }
        if (Y < 0)
        {
            Y = 400;
        }

    }

}
