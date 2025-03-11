using System.Data.SqlClient;
using Collections_Hackathon_day8.models;
using Collections_Hackathon_day8.exceptions;
using Collections_Hackathon_day8.Utility;
using System.Data;


namespace Collections_Hackathon_day8.repository
{
    class PolicyRepository : IPolicyInsuranceRepository
    {
        SqlCommand command = null;
        string connString;
      
        List<Policy> policies;

        public PolicyRepository()
        {

            command = new SqlCommand();
            connString = DBConnectionUtility.GetConnectionString();
        }

        public int AddPolicy(Policy policy)
        {

                using (SqlConnection sqlconnection = new SqlConnection(connString))
                {
                    command.CommandText = "INSERT INTO Policies (PolicyHolderName, PolicyType, StartDate, EndDate) VALUES (@PolicyHolderName,@PolicyType,@StartDate,@EndDate)";

                    command.Parameters.AddWithValue("@PolicyHolderName", policy.PolicyHolder);
                    command.Parameters.AddWithValue("@PolicyType", policy.Type.ToString());
                    command.Parameters.AddWithValue("@StartDate", policy.StartDate);
                    command.Parameters.AddWithValue("@EndDate", policy.EndDate);

                    Console.WriteLine("we are in the addPolicy"+policy.Type.ToString());
                    
                    command.Connection = sqlconnection;

                    
                    sqlconnection.Open();
                    int tocheck = command.ExecuteNonQuery();
                    return tocheck;

                    

            }
            
           
        }

        public int DeletePolicyById(int PolicyId)
        {

            using (SqlConnection sqlconnection = new SqlConnection(connString))
            {

                command.CommandText = "DELETE FROM Policies WHERE PolicyID = @PolicyID";

                command.Parameters.AddWithValue("PolicyID", PolicyId);

                command.Connection = sqlconnection;
                sqlconnection.Open();

                int tocheck = command.ExecuteNonQuery();
                return tocheck;

            }

        }
            //var policy = policies.FirstOrDefault(p => p.PolicyId == PolicyId);
            //if (policy != null)
            //{
            //    policies.Remove(policy);
            //}
            //else
            //{
            //    throw new InsurancePolicyExceptionHandling("Enter valid Policy Id to delete!");
            //}
        
        public List<Policy> GetAllPolicies()
        {
            List<Policy> policies = new List<Policy>();


            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connString))
                {
                    command.CommandText = "select * from Policies";
                    command.Connection = sqlconnection;
                    sqlconnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                   
                    while (reader.Read())
                    {
                        Policy policy = new Policy(
                            reader.GetInt32("PolicyID"),               
                            reader.GetString("PolicyHolderName"),      
                            Enum.Parse<PolicyType>(reader.GetString("PolicyType")),
                            reader.GetDateTime("StartDate"),         
                            reader.GetDateTime("EndDate")             
                        );
                             policies.Add(policy);

                       
                    }

                }
            }
            catch (InsurancePolicyExceptionHandling ex)
            {
                Console.WriteLine("Error while fetching data from database: " + ex.Message);
            }

            return policies;


        }

        public Policy GetPolicyById(int PolicyId)
        {

            using (SqlConnection sqlconnection = new SqlConnection(connString))
            {
                command.CommandText = "SELECT * FROM Policies WHERE PolicyID = @PolicyID ";
                command.Connection = sqlconnection;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@PolicyID" , PolicyId);
                sqlconnection.Open();

                SqlDataReader reader =command.ExecuteReader();

                if (reader.Read())
                {
                    return new Policy(

                        reader.GetInt32("PolicyID"),
                        reader.GetString("PolicyHolderName"),
                        Enum.Parse<PolicyType>(reader.GetString("PolicyType")),
                        reader.GetDateTime("StartDate"),
                        reader.GetDateTime("EndDate")    
                        );
                }
                else
                {
                    throw new InsurancePolicyExceptionHandling("No policy find in database");
                }

            }

            //var policy = policies.FirstOrDefault(p => p.PolicyId == PolicyId);
            //if (policy == null)
            //{
            //    throw new InsurancePolicyExceptionHandling("Policy not found.");
            //}
            //return policy;
        }

        public void UpdatePolicy(int policyId, Policy updatedPolicy)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                command.CommandText = "UPDATE Policies SET PolicyHolderName = @PolicyHolderName, PolicyType = @PolicyType, EndDate = @EndDate WHERE PolicyID = @PolicyID";

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@PolicyHolderName", updatedPolicy.PolicyHolder);  
                command.Parameters.AddWithValue("@PolicyType", updatedPolicy.Type.ToString()); 
                command.Parameters.AddWithValue("@EndDate", updatedPolicy.EndDate);  
                command.Parameters.AddWithValue("@PolicyID", policyId);  

                command.Connection = sqlConnection;

                try
                {
                    sqlConnection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Policy updated successfully in the database.");
                    }
                    else
                    {
                        Console.WriteLine("No policy found with the given PolicyID.");
                    }
                }
                catch (InsurancePolicyExceptionHandling ex)
                {
                    Console.WriteLine("An error occurred while updating the policy: " + ex.Message);
                }
            }
        }
        
        public List<Policy> GetAllActivePolicy()
        {
            try
            {
                List<Policy> allPolicies = GetAllPolicies();
                return allPolicies.Where(p => DateTime.Now >= p.StartDate && DateTime.Now <= p.EndDate).ToList();
            }
            catch (InsurancePolicyExceptionHandling ex)
            {
                Console.WriteLine("Error while checking all active policy: " + ex.Message);
                return new List<Policy>();
            }
        }

        public List<Policy> GetActivePolicies()
        {
            return GetAllPolicies();
        }
    }
}
