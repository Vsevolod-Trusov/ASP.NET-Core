using System.Text;
using Microsoft.AspNetCore.Mvc;

public class SquareController: Controller {
     public IActionResult Index() => View();

      [Route("[controller]/{square:int}")]
     public IActionResult HandleSquare(int square) {

          ViewBag.Square = square;
          return View();
     }
}