using OrderServiceApi.Entity.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Helper.Enum
{
    public class CardType : BaseEnumeration
    {
        public static CardType Amex = new(1, nameof(Amex));
        public static CardType Visa = new(2, nameof(Visa));
        public static CardType MasterCard = new(3, nameof(MasterCard));

        public CardType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<CardType> List()
        {
            return new List<CardType> { Amex, Visa, MasterCard };
        }
    }
}
