namespace Leaders.RedeemVoucher.Domain.Interfaces.Entities
{
    /// <summary>
    /// Represents a Entity
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// The entity identifier
        /// </summary>
        int AutoID { get; }
    }
}