using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Entities.Auditing
{
    //
    // 摘要:
    //     This interface ads Abp.Domain.Entities.Auditing.IDeletionAudited to Abp.Domain.Entities.Auditing.IAudited
    //     for a fully audited entity.
    public interface IFullAudited : IAudited, ICreationAudited, IHasCreationTime, IModificationAudited, IHasModificationTime, IDeletionAudited, IHasDeletionTime, ISoftDelete
    {
    }
}
