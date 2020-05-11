namespace interfaces
{
    public class Ant : IWalk, IDig
    {
        public string Name;
        public bool WalksOnGround { get; set; } 

        public bool DigInGround { get; set; }
    }
}