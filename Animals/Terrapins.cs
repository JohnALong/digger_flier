namespace interfaces
{
    public class Terrapin : IWalk, ISwim
    {
        public bool WalksOnGround { get; set; } 

        public bool SwimInWater { get; set; }
    }
}