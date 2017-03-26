using FakeItEasy;
using Xunit;

namespace FakeItEasyQuickstart
{
    
    public class SweetToothTests
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
            developer.Favorite = lollipop;
            developer.BuyTastiestCandy(shop);
            
            // asserting uses the exact same syntax as when configuring calls—
            // no need to learn another syntax
            A.CallTo(() => shop.BuyCandy(lollipop)).MustHaveHappened();
        }
    }
}
