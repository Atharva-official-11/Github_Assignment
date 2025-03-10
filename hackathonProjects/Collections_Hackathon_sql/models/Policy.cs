

namespace Collections_Hackathon_day8.models
{

    // create the enum PolicyTypes
    public enum PolicyType
    {
        Life,
        Health,
        Vehicle,
        Property
    }


    class Policy
    {
        public int PolicyId { get; set; }
        public string PolicyHolder { get; set; }
        public PolicyType Type { get; set; }

        public DateTime StartDate { get; set; } 

        public DateTime EndDate { get; set; }


        public Policy(int InsaurancePolicyId, string InsaurancePolicyHolder, PolicyType InsauranceType, DateTime InsauranceStartdate , DateTime InsauranceEndDate)
        {
            this.PolicyId = InsaurancePolicyId;
            this.PolicyHolder = InsaurancePolicyHolder;
            this.Type = InsauranceType;
            this.StartDate = InsauranceStartdate;
            this.EndDate = InsauranceEndDate;
        }
     

        public override string ToString()
        {
            return $"PolicyID: {PolicyId}, PolicyHolder: {PolicyHolder}, Type: {Type}, Start Date: {StartDate.ToShortDateString()}, End Date: {EndDate.ToShortDateString()}";
        }
    }
}
