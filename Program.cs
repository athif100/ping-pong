using Raylib_cs;
int width = 800;
int height = 400;
Raylib.InitWindow(width, height, "My window");

pong_ball gamebal = new pong_ball();
gamebal.X = 500;
gamebal.Y = 200;
gamebal.speedX = 100;
gamebal.speedY = 100;
paddle Player = new paddle();
Player.X = 100;
Player.Y = 100;
paddle compute = new paddle();
compute.X = 730;
compute.Y = 100;
compute.rect.X = 730;
int Playerscore = 0;
    int computescore = 0;
 float timmer = 0;
while (!Raylib.WindowShouldClose())

{
    if (timmer > 2)
    {
        timmer = 0;
     if (gamebal.Y > compute.rect.Y)
        {
            compute.rect.Y += 0.3f;

        }
    if (gamebal.Y < compute.rect.Y)
    {
        compute.rect.Y -= 0.3f;
    }   
    }
    timmer += Raylib.GetFrameTime();
    bool circlehascollidedwithplayer = Raylib.CheckCollisionCircleRec(new System.Numerics.Vector2(gamebal.X, gamebal.Y), 50, Player.rect);
    if (circlehascollidedwithplayer == true)
    {
        gamebal.speedX = -gamebal.speedX;
        gamebal.X = 150;
    }
    bool circlehascollidedwithcompute = Raylib.CheckCollisionCircleRec(new System.Numerics.Vector2(gamebal.X, gamebal.Y), 50, compute.rect);
    if (circlehascollidedwithcompute == true)
    {
        gamebal.speedX = -gamebal.speedX;
    }
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Black);
    Raylib.DrawRectangleRec(Player.rect, Color.Green);
    Raylib.DrawRectangleRec(compute.rect, Color.Blue);
    Raylib.DrawCircle((int)gamebal.X, (int)gamebal.Y, 50, Color.Red);
    Raylib.DrawText(Playerscore.ToString(), 375, 50, 20, Color.Orange);
    Raylib.DrawText(computescore.ToString(), 425, 50, 20, Color.Orange);
    Raylib.EndDrawing();
    gamebal.moveball(ref computescore, ref Playerscore);
    Player.moveplayer();
    
}


