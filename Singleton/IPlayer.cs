using System.Collections.Generic;

namespace Singleton
{
    public interface IPlayer
    {
        string Name { get; }
        int Money { get; }
        List<IProperty> Properties { get; }

        void earn(int money);
        void pay(int money);

        void buy(IProperty newProperty);
        void sale(IProperty property);
        
    }
}