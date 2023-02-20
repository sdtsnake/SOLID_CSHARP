namespace InterfaceSegregation
{
    public class Developer : IWorkingActivities, IDevelopActivities
    {
        public Developer()
        {
        
        }

        public void Comunicate()
        {
            throw new ArgumentException();
        }

        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Plan()
        {
            throw new ArgumentException();
        }

        public void Test() 
        {
            throw new ArgumentException();
        }
    }
}