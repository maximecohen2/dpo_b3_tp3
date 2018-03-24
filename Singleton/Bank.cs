using System.Collections.Generic;

namespace Singleton
{
    public class Bank : IPlayer
    {
        private int _money;

        private List<IProperty> _properties;

        private static Bank _instance;

        static readonly object instanceLock = new object();

        private Bank(int money, List<IProperty> properties)
        {
            _money = money;
            _properties = properties;
        }


        public int Money { get => _money; }
        public List<IProperty> Properties { get => _properties; }

        public string Name { get => "La Banque"; }

        public static Bank getInstance(int money, List<IProperty> properties) 
        {
            lock (instanceLock)
            {
                if (_instance == null)
                    _instance = new Bank(money, properties);
                return _instance;
            }
        }

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