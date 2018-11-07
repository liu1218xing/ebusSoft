using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Entities.Auditing
{
    /// <summary>
	/// An entity can implement this interface if <see cref="P:Ebus.Domain.Entities.Auditing.IHasCreationTime.CreationTime" /> of this entity must be stored.
	/// <see cref="P:Ebus.Domain.Entities.Auditing.IHasCreationTime.CreationTime" /> is automatically set when saving <see cref="T:Abp.Domain.Entities.Entity" /> to database.
	/// </summary>
	public interface IHasCreationTime
    {
        /// <summary>
        /// Creation time of this entity.
        /// </summary>
        DateTime CreationTime
        {
            get;
            set;
        }
    }
}
