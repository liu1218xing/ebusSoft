using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Entities.Auditing
{
    /// <summary>
	/// An entity can implement this interface if <see cref="P:Abp.Domain.Entities.Auditing.IHasDeletionTime.DeletionTime" /> of this entity must be stored.
	/// <see cref="P:Abp.Domain.Entities.Auditing.IHasDeletionTime.DeletionTime" /> is automatically set when deleting <see cref="T:Abp.Domain.Entities.Entity" />.
	/// </summary>
	public interface IHasDeletionTime : ISoftDelete
    {
        /// <summary>
        /// Deletion time of this entity.
        /// </summary>
        DateTime? DeletionTime
        {
            get;
            set;
        }
    }
}
