using System.Collections.Generic;

namespace Singleton
{
    public class HumanPlayer : IPlayer
    {
        private string _name;
        private int _money;

        private List<IProperty> _properties;

        public HumanPlayer(string name, int money)
        {
            _name = name;
            _money = money;
            _properties = new List<IProperty>();
        }

        public string Name { get => _name; }
        public int Money { get => _money; }
        public List<IProperty> Properties { get => _properties; }

        public void earn(int money)
        {
            this._money += money;
        }

        public void pay(int money)
        {
            this._money -= money;
        }

        public void buy(IProperty newProperty)
        {
            this.pay(newProperty.Price);
            this._properties.Add(newProperty);
        }

        public void sale(IProperty property)
        {
            this.earn(property.Price);
            this._properties.Remove(property);
        }

        public override string ToString()
        {
            return string.Format("{0} possède {1:N0} €", Name, Money);
        }
    }
}