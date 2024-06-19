using System.Text;
using Microsoft.AspNetCore.Mvc;

public class PersonController: Controller {
    
     public IActionResult Index() => View();

      [Route("[controller]/{name:alpha:minlength(3)}/{age:int:min(1)}")]
     public IActionResult HandlePerson(string name, int age) {

          ViewBag.Name = name;
          ViewBag.Age = age;
          return View();
     }
}