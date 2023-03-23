namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> CapitialsofCountries = new Dictionary<string, string>();
            CapitialsofCountries.Add("England", "London");
            CapitialsofCountries.Add("France", "Paris");
            CapitialsofCountries.Add("Germany", "Berlin");
            CapitialsofCountries.Add("USA", "Washington DC");
            CapitialsofCountries.Add("Canada", "Ottawa");

            if (CapitialsofCountries.ContainsKey("England")) 
            {
                Console.WriteLine(CapitialsofCountries["England"]);
            }
            else 
            {
                Console.WriteLine("This key does not exist");
            }
        }
    }
}