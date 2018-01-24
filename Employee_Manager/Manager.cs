namespace Employee_Manager
{
    public class Manager
    {
        public bool manage()
        {
            Employee E1 = new Employee();
            bool result = E1.WorksUnder();
            return result;
        }
    }
}