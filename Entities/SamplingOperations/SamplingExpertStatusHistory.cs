using System.Collections.Generic;

namespace Entities.SamplingOperations
{
    public class SamplingExpertStatusHistory : BaseEntity
    {
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int SamplingExpertId { get; set; }
        public ICollection<SamplingExpert> SamplingExpert { get; set; }
    }
}

