using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Parakeet pauly = new Parakeet()
            {
                FlyInAir = true
            };
            Parakeet polly = new Parakeet()
            {
                FlyInAir = true
            };
            Earthworm eddy = new Earthworm()
            {
                DigInGround = true
            };
            Earthworm eric = new Earthworm()
            {
                DigInGround = true
            };
            Terrapin tom = new Terrapin()
            {
                SwimInWater = true
            };
            Terrapin tyler = new Terrapin()
            {
                SwimInWater = true
            };
            Rattlesnake ryan = new Rattlesnake()
            {
                WalksOnGround = true,
                DigInGround = true
            };
            Rattlesnake robert = new Rattlesnake()
            {
                WalksOnGround = true,
                DigInGround = true
            };
            Mice mike = new Mice()
            {
                WalksOnGround = true,
                DigInGround = true
            };
            Mice morris = new Mice()
            {
                WalksOnGround = true,
                DigInGround = true
            };
            Ant alfred = new Ant()
            {
                Name = "Alfred",
                WalksOnGround = true,
                DigInGround = true
            };
            Ant aggie = new Ant()
            {
                Name = "Aggie",
                WalksOnGround = true,
                DigInGround = true
            };
            Finch fred = new Finch()
            {
                FlyInAir = true
            };
            Finch felicia = new Finch()
            {
                FlyInAir = true
            };
            BettaFish bryan = new BettaFish()
            {
                SwimInWater = true
            };
            BettaFish brad = new BettaFish()
            {
                SwimInWater = true
            };
            Copperhead corri = new Copperhead()
            {
                WalksOnGround = true,
                DigInGround = true
            };
            Copperhead chris = new Copperhead()
            {
                WalksOnGround = true,
                DigInGround = true
            };
            Gerbil greg = new Gerbil()
            {
                WalksOnGround = true
            };
            Gerbil greyson = new Gerbil()
            {
                WalksOnGround = true
            };

            DiggerContainer diggers = new DiggerContainer();
            SwimContainer swimmers = new SwimContainer();
            WalkersContainer walkers = new WalkersContainer();
            FlierContainer fliers = new FlierContainer();

            fliers.Fliers.Add(pauly);
            fliers.Fliers.Add(polly);
            fliers.Fliers.Add(felicia);
            fliers.Fliers.Add(fred);
            walkers.Walkers.Add(aggie);
            walkers.Walkers.Add(alfred);
            diggers.Diggers.Add(alfred);
            diggers.Diggers.Add(aggie);
            swimmers.Swimmers.Add(brad);
            swimmers.Swimmers.Add(bryan);
            walkers.Walkers.Add(ryan);
            walkers.Walkers.Add(robert);
            walkers.Walkers.Add(corri);
            walkers.Walkers.Add(chris);
            diggers.Diggers.Add(corri);
            diggers.Diggers.Add(chris);
            diggers.Diggers.Add(robert);
            diggers.Diggers.Add(ryan);
            diggers.Diggers.Add(eddy);
            diggers.Diggers.Add(eric);
            walkers.Walkers.Add(greg);
            walkers.Walkers.Add(greyson);
            diggers.Diggers.Add(mike);
            diggers.Diggers.Add(morris);
            walkers.Walkers.Add(mike);
            walkers.Walkers.Add(morris);
            walkers.Walkers.Add(tom);
            walkers.Walkers.Add(tyler);
            swimmers.Swimmers.Add(tom);
            swimmers.Swimmers.Add(tyler);

            foreach (IWalk item in walkers.Walkers)
            {
                Console.WriteLine(item);
            }
            foreach (IFly item in fliers.Fliers)
            {
                Console.WriteLine(item);
            }
            foreach (IDig item in diggers.Diggers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
