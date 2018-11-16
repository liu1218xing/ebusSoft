using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Core.Entities.test
{
    public class Blog: CreationAuditedEntity<int>
    {
       
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
        
    }
}
