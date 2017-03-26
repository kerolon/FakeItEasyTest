using System;

namespace FakeItEasyQuickstart
{
    internal class SweetTooth
    {
        public SweetTooth()
        {
        }

        public ICandy Favorite { get; internal set; }

        internal void BuyTastiestCandy(ICandyShop shop)
        {
            shop.BuyCandy(Favorite);
        }
    }
}