namespace Form
{
    interface IShape
    {
        int Height { get; }
        int Width { get; }
        void Print(int x, int y);
    }
}