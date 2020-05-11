namespace interfaces
{
    public class Rattlesnake : IWalk, IDig
    {
        public bool WalksOnGround { get; set; } 

        public bool DigInGround { get; set; }
    }
}