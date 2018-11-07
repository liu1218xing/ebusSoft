using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Entities
{
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id
        {
            get;
            set;
        }
        /// <inheritdoc />
		public override int GetHashCode()
        {
            if (Id == null)
            {
                return 0;
            }
            return Id.GetHashCode();
        }
        /// <inheritdoc />
		public override string ToString()
        {
            return $"[{base.GetType().Name} {Id}]";
        }
    }
}
