using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Core.Entities.test
{
    public class Post : FullAuditedEntity<int>
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public Blog Blog { get; set; }
    }
}
