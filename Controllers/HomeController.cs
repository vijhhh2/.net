using Microsoft.AspNetCore.Mvc;

namespace bookstore
{
    public class HomeController : Controller
    {
        public string Index() {
            return "Hello World From controller";
        }
    }
}