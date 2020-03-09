using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hi")]
    public string Hi() { return "Hello there good buddy"; }

    [Route("/bye")]
    public string Bye() { return "See ya later alligator"; }

    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Joe";
      myLetterVariable.Sender = "Gregory";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location = location;
      myLetterVariable.Souvenir = souvenir;
      return View(myLetterVariable);
    }
  }
}