using Raylib_cs;
class pong_ball
{
    public float X;
    public float Y;
    public float speedX;
    public float speedY;
    public void moveball(ref int computescore,ref int playerscore)
    {
        //Moving the ball
        X += speedX * Raylib.GetFrameTime();
        Y += speedY * Raylib.GetFrameTime();
        if (Y > 350)
        {
            speedY = -speedY;
            Y = 349;
        }
        if (Y < 50)
        {
            speedY = -speedY;
            Y = 51;
        }
        if (X > 750)
        {
            playerscore += 1;
            speedX = -speedX;

        }
        if (X < 50)
        {
            computescore += 1;   
            speedX = -speedX;
        }
    }
}
