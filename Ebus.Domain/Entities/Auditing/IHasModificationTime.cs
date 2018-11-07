using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Entities.Auditing
{
    //
    // 摘要:
    //     An entity can implement this interface if Abp.Domain.Entities.Auditing.IHasModificationTime.LastModificationTime
    //     of this entity must be stored. Abp.Domain.Entities.Auditing.IHasModificationTime.LastModificationTime
    //     is automatically set when updating Abp.Domain.Entities.Entity.
    public interface IHasModificationTime
    {
        //
        // 摘要:
        //     The last modified time for this entity.
        DateTime? LastModificationTime { get; set; }
    }
}
