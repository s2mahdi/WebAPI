namespace Entities.SamplingOperations
{
    public class SamplingExpertStatusHistory : BaseEntity
    {
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int SamplingExpertId { get; set; }
        public SamplingExpert SamplingExpert { get; set; }
    }
}

