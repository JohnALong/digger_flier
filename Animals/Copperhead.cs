namespace interfaces
{
    public class Copperhead : IWalk, IDig
    {
        public bool WalksOnGround { get; set; } 

        public bool DigInGround { get; set; }
    }
}