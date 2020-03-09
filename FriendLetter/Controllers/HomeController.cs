using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hi")]
    public string Hi() { return "Hello there good buddy"; }

    [Route("/bye")]
    public string Bye() { return "See ya later alligator"; }
  }
}