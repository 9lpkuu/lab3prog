namespace lab3prog
{
    class Point
    {
        int xPosition;
        int yPosition;
        char symbol;

        public void SetX(int x)
        {
            if (x >= 0)
                xPosition = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                yPosition = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym(char sym)
        {
            symbol = sym;
        }
        public void Draw(int x1, int y1, char sym1)
        {
            SetX(x1);
            SetY(y1);
            SetSym(sym1);
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(symbol);
        }
    }
}
