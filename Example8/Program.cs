Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 1;
int ya = 1;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

int xb = 1;
int yb = 30;

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

int xc = 80;
int yc = 30;

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa;
int y = xb;

int count = 0;

while(count < 10000)
{
    int random = new Random().Next(0, 3);
    if(random == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(random == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(random == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x , y);
    Console.WriteLine("+");
    count = count + 1;
}