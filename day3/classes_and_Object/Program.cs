
namespace classes_and_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car(100, "toyota", "M12", 2012, 3000000);
            #region problem1
            //car1.addCarDetails();
            #endregion

            #region problem3
            car1.displyCarDetails();
            #endregion

            #region problem3
            /* Problem - 3 */
            Console.WriteLine("Enter Password::");
            string pass = Console.ReadLine();
            validatePassword(pass);
            #endregion
        }
        public static Boolean validatePassword(String password)
        {

            if (password.Length < 6)
            {
                Console.WriteLine("Password must be at least 6 characters long.");
                return false;
            }
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
                return false;
            }
            if (!Regex.IsMatch(password, "\\d"))
            {
                Console.WriteLine("Password must contain at least one digit.");
                return false;

            }
            Console.WriteLine("Password is valid.");
            return true;
        }
    }
}
