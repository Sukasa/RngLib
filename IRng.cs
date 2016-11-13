namespace RngLib
{
    public interface IRng
    {
        void SetSeed(ulong Seed);
        void UseDefaultSeed();
        byte NextByte();
        int Next(int Low, int High);
        double NextDouble();
        ulong NextULong();
    }
}
