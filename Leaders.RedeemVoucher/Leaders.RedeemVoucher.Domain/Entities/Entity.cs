using System;
using Leaders.RedeemVoucher.Domain.Interfaces.Entities;

namespace Leaders.RedeemVoucher.Domain.Entities
{
    /// <summary>
    /// Standard Implementation for Entity
    /// </summary>
    public class Entity : IEntity
    {
        /// <summary>
        /// The entity identifier
        /// </summary>
        public int AutoID { get; protected set; }

        public Entity() { } //EF Constructor

        public Entity(int autoId)
        {
            AutoID = autoId;
        }

        public override int GetHashCode()
        {
            return AutoID.GetHashCode();
        }

        public override string ToString()
        {
            return "Entity:" + AutoID.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            try
            {
                if (((Entity)obj).AutoID.Equals(AutoID))
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
    }
}