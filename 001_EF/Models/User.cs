

namespace _001_EF.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FName { get; private set; }
        public string LName { get; private set; }

        public int Age {  get; private set; }

        public User(string fName, string lName, int age)
        {
            this.FName = fName; 
            this.LName = lName;
            this.Age = age;
        }

    }
}
