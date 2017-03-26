using System.Collections.Generic;
using System.Linq;

namespace FakeItEasyQuickstart
{
    class LolipopShop : ICandyShop
    {
        Dictionary<string, int> _sales;

        public LolipopShop()
        {
            _sales = new Dictionary<string, int>();
        }

        public void BuyCandy(ICandy lollipop)
        {
            if (_sales.ContainsKey(lollipop.Name))
            {
                _sales.Add(lollipop.Name, 0);
            }
            _sales[lollipop.Name]++;
        }

        public ICandy GetTopSellingCandy()
        {
            return new Lolipop();
        }
    }
}
