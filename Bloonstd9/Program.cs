using Raylib_cs;

Raylib.InitWindow(1024, 768, "Topdown game");
Raylib.SetTargetFPS(60);

Color myColor = new Color(255, 120, 60, 255);

Rectangle character = new Rectangle(0, 60, 50, 50);
float speed = 5f;

while (Raylib.WindowShouldClose() == false)
{
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        character.x += speed;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        character.x -= speed;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        character.y -= speed;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        character.y += speed;
    }

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);
    Raylib.DrawRectangleRec(character, myColor);
    Raylib.EndDrawing();
}