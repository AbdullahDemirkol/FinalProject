using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Base
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public DateTime CreateDate { get; set; }

        int? _requestedHashCode;
        private List<INotification> domainEvents = new List<INotification>();
        public IReadOnlyCollection<INotification> DomainEvents => domainEvents.AsReadOnly();

        public void AddDomainEvent(INotification domainEvent)
        {
            domainEvents = domainEvents ?? new List<INotification>();
            domainEvents.Add(domainEvent);
        }
        public void RemovaDomainEvent(INotification domainEvent)
        {
            domainEvents?.Remove(domainEvent);
        }
        public void ClearDomainEvent()
        {
            domainEvents?.Clear();
        }
        public bool IsTransient()
        {
            return Id == default;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BaseEntity))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }

            BaseEntity baseEntity = (BaseEntity)obj;
            if (baseEntity.IsTransient() || IsTransient())
            {
                return false;
            }
            else
            {
                return baseEntity.Id == Id;
            }
        }
        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                {
                    _requestedHashCode = Id.GetHashCode() ^ 31;
                }
                return _requestedHashCode.Value;
            }
            else
            {
                return base.GetHashCode();
            }
        }
        public static bool operator ==(BaseEntity left, BaseEntity right)
        {
            if (Equals(left, null))
            {
                return Equals(right, null) ? true : false;
            }
            else
            {
                return left.Equals(right);
            }
        }
        public static bool operator !=(BaseEntity left, BaseEntity right)
        {
            return !(left == right);
        }


    }
}
