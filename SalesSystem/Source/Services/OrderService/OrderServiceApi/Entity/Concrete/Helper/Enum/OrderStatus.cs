using OrderServiceApi.Entity.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Helper.Enum
{
    public class OrderStatus : BaseEnumeration
    {
        public OrderStatus(int id, string name) : base(id, name)
        {
            Id = id;
            Name = name;
        }
        public static OrderStatus IslemeAlinildi = new(1, nameof(IslemeAlinildi).ToLowerInvariant());
        public static OrderStatus DogrulamaBekleniyor = new(2, nameof(DogrulamaBekleniyor).ToLowerInvariant());
        public static OrderStatus StokOnaylandi = new(3, nameof(StokOnaylandi).ToLowerInvariant());
        public static OrderStatus Odenildi = new(4, nameof(Odenildi).ToLowerInvariant());
        public static OrderStatus Gonderildi = new(5, nameof(Gonderildi).ToLowerInvariant());
        public static OrderStatus Tamamlanildi = new(6, nameof(Tamamlanildi).ToLowerInvariant());
        public static OrderStatus IptalEdildi = new(7, nameof(IptalEdildi).ToLowerInvariant());

        public static IEnumerable<OrderStatus> List()
        {
            return new List<OrderStatus> { IslemeAlinildi, DogrulamaBekleniyor, StokOnaylandi, Odenildi, Gonderildi, Tamamlanildi, IptalEdildi };
        }
        public static OrderStatus FromName(string name)
        {
            var state = List().SingleOrDefault(p => p.Name == name);
            return state;
        }
        public static OrderStatus FromId(int id)
        {
            var state = List().SingleOrDefault(p => p.Id == id);
            return state;
        }
    }
}
