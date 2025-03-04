using Collections_Hackathon_day8.models;
using Collections_Hackathon_day8.exceptions;
using System.Linq;

namespace Collections_Hackathon_day8.repository
{
    class PolicyRepository : IPolicyInsuranceRepository
    {
        List<Policy> policies;

        public PolicyRepository()
        {
            policies = new List<Policy>
            {
                new Policy(101, "Atharva", PolicyType.Life, DateTime.Parse("01/01/2020"), DateTime.Parse("12/31/2025"))
            };
        }
        public void AddPolicy(Policy policy)
        {
            if (policies.Any(p => p.PolicyId == policy.PolicyId))
            {
                throw new InsurancePolicyExceptionHandling("Policy ID Already exist Try with different Policy Id");
            }
            else
            {
                policies.Add(policy);

            }
        }


        public List<Policy> GetActivePolicies()
        {
            if(policies == null)
            {
                return policies;
                throw new InsurancePolicyExceptionHandling("NO! , Policy are currently available in database!");
            }
            else
            {
                 return policies.Where(p => DateTime.Now >= p.StartDate && DateTime.Now <= p.EndDate).ToList();
            }
        }
  

        public void DeletePolicyById(int PolicyId)
        {
            var policy = policies.FirstOrDefault(p => p.PolicyId == PolicyId);
            if (policy != null)
            {
                policies.Remove(policy);
            }
            else
            {
                throw new InsurancePolicyExceptionHandling("Enter valid Policy Id to delete!");
            }
        }

        public List<Policy> GetAllPolicies()
        {
            return policies;
        }

        public Policy GetPolicyById(int PolicyId)
        {
            var policy = policies.FirstOrDefault(p => p.PolicyId == PolicyId);
            if (policy == null)
            {
                throw new InsurancePolicyExceptionHandling("Policy not found.");
            }
            return policy;
        }

        public void UpdatePolicy(int PolicyId, Policy UpdatedPolicy)
        {
            var policy = policies.FirstOrDefault(p => p.PolicyId == PolicyId);

            if (policy == null)
            {
                throw new InsurancePolicyExceptionHandling("Policy not Found Please enter valid Policy");
            }

            policy.PolicyHolder = UpdatedPolicy.PolicyHolder;
            policy.Type = UpdatedPolicy.Type;
            policy.StartDate = UpdatedPolicy.StartDate;
            policy.EndDate = UpdatedPolicy.EndDate;

        }

        public List<Policy> GetAllActivePolicy()
        {
            throw new NotImplementedException();
        }
    }
}
