namespace Retail.Domain
{
    public class Service : IService
    {

        public bool DoWork(int number)
        {
            return number > 10 ? true : false;
        }
    }
}