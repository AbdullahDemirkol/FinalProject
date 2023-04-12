using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Base
{
    public abstract class BaseEnumeration : IComparable
    {
        public string Name { get; set; }

        public int Id { get; set; }

        protected BaseEnumeration(int id, string name)
        {
            Name = name;
            Id = id;
        }
        public override string ToString()
        {
            return Name;
        }

        public static IEnumerable<T> GetAll<T>() where T : BaseEnumeration
        {
            return typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly).Select(p => p.GetValue(null)).Cast<T>();
        }
        public override bool Equals(object obj)
        {
            if (obj is not BaseEnumeration otherValue)
            {
                return false;
            }
            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public static int AbsoluteDifference(BaseEnumeration firstValue, BaseEnumeration secondValue)
        {
            var absoluteDifference = Math.Abs(firstValue.Id - secondValue.Id);
            return absoluteDifference;
        }
        public static T FromValue<T>(int value) where T : BaseEnumeration
        {
            var matchingItem = Parse<T, int>(value, "value", item => item.Id == value);
            return matchingItem;
        }
        public static T FromDisplayName<T>(string displayName) where T : BaseEnumeration
        {
            var matchingItem = Parse<T, string>(displayName, "display name", item => item.Name == displayName);
            return matchingItem;
        }
        private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : BaseEnumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);
            if (matchingItem == null)
            {
                throw new InvalidOperationException($"'{value}' is not a valid {description} in {typeof(T)}");
            }
            return matchingItem;
        }
        public int CompareTo(object obj)
        {
            return Id.CompareTo(((BaseEnumeration)obj).Id);
        }
    }
}
