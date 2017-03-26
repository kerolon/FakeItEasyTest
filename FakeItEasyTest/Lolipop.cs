using System;

namespace FakeItEasyQuickstart
{
    class Lolipop : ICandy
    {
        public string Name { get; set; }

        public Lolipop()
        {
            Name = "lolipop";
        }
    }
}
