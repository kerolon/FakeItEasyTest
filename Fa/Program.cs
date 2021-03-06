﻿using System;
using FakeItEasy;
using Xunit;

namespace FakeIeEasyTest
{
    public class FakeIeEasyTest
    {
        [Fact]
        public void BuyTastiestCandy_should_buy_top_selling_candy_from_shop()
        {
            // make some fakes for the test
            var lollipop = A.Fake<ICandy>();
            var shop = A.Fake<ICandyShop>();

            // set up a call to return a value
            A.CallTo(() => shop.GetTopSellingCandy()).Returns(lollipop);

            // use the fake as an actual instance of the faked type
            var developer = new SweetTooth();
            developer.BuyTastiestCandy(shop);

            shop.BuyCandy(lollipop);
            // asserting uses the exact same syntax as when configuring calls—
            // no need to learn another syntax
            A.CallTo(() => shop.BuyCandy(lollipop)).MustHaveHappened();
            
        }
    }

    internal class SweetTooth
    {
        public SweetTooth()
        {
        }

        internal void BuyTastiestCandy(ICandyShop shop)
        {
            throw new NotImplementedException();
        }
    }

    internal interface ICandyShop
    {
        void BuyCandy(ICandy lollipop);
        ICandy GetTopSellingCandy();
    }

    internal interface ICandy
    {
    }
}