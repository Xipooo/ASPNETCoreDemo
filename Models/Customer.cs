namespace ASPNETCoreDemo.Models
{
    public class Customer
    {
        private int _id = 1;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstName = "Steve";
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName = "Bishop";
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}