
namespace DataEntities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return string.Format("FullName:{0} {1},Title:{2}", FirstName, LastName, Title);
        }
    }


}
