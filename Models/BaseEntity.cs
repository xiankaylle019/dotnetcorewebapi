using System;

namespace dotnetcorewebapi.Models
{
    /// <summary>
    /// Base Entity Class represent as the base class
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Id property
        /// This property will represent as the primary key when BaseEntity inherited to any Derived Class
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        /// <summary>
        /// Created At property 
        /// This will always have value which is the current date time upon instatiation the object.
        /// </summary>
        /// <returns></returns>
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Updated At property
        /// Nullable date time
        /// </summary>
        /// <returns></returns>
        public Nullable<DateTime> UpdatedAt { get; set; }
    }
}