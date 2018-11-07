using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Entities.Auditing
{
    //
    // 摘要:
    //     This interface is implemented by entities which wanted to store deletion information
    //     (who and when deleted).
    public interface IDeletionAudited : IHasDeletionTime, ISoftDelete
    {
        //
        // 摘要:
        //     Which user deleted this entity?
        long? DeleterUserId { get; set; }
    }
}
