

using Collections_Hackathon_day8.models;

namespace Collections_Hackathon_day8.repository
{
    interface IPolicyInsuranceRepository
    {
        int AddPolicy(Policy policy);
        List<Policy> GetActivePolicies();
        List<Policy> GetAllPolicies();
        Policy GetPolicyById(int PolicyId);
        void UpdatePolicy(int PolicyId, Policy updatedPolicy);
        int DeletePolicyById(int PolicyId);
        List<Policy> GetAllActivePolicy();
    }
}
