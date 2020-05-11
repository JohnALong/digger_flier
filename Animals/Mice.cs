namespace interfaces
{
    public class Mice : IWalk, IDig
    {
        public bool WalksOnGround { get; set; } 

        public bool DigInGround { get; set; }
    }
}