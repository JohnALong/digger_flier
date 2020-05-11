using System;
using System.Collections.Generic;

namespace interfaces
{
    public class SwimContainer
    {
        public List<ISwim> Swimmers = new List<ISwim>();
    }

    public class DiggerContainer
    {
        public List<IDig> Diggers = new List<IDig>();
    }

    public class WalkersContainer
    {
        public List<IWalk> Walkers = new List<IWalk>();
    }

    public class FlierContainer
    {
        public List<IFly> Fliers = new List<IFly>();
    }
}