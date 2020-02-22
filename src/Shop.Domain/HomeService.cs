namespace Shop.Domain
{
    public class HomeService: IHomeService
    {
        public HomeModel Get(int id)
        {
            return new HomeModel
            {
                Name = $"MyFirstHome: {id}"
            };
        }
    }
}