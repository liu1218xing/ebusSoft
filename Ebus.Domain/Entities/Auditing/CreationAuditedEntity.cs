using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Entities.Auditing
{
    /// <summary>
	/// This class can be used to simplify implementing <see cref="T:Abp.Domain.Entities.Auditing.ICreationAudited" />.
	/// </summary>
	/// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
	[Serializable]
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited, IHasCreationTime
    {
        /// <summary>
        /// Creation time of this entity.
        /// </summary>
        public virtual DateTime CreationTime
        {
            get;
            set;
        }

        /// <summary>
        /// Creator of this entity.
        /// </summary>
        public virtual long? CreatorUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor. 原来为Clock
        /// </summary>
        protected CreationAuditedEntity()
        {
            CreationTime = DateTime.Now;
        }
    }
    }
