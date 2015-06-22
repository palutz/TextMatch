using System;
using Microsoft.AspNet.Mvc;

using TextMatch.Interfaces;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TextMatch.Controllers
{
    public class TextMatchController : Controller
    {
        private ITextMatcher _matcher;
        private IResultPrint _printer;
        public TextMatchController(ITextMatcher matcher, IResultPrint printer)
        {
            this._matcher = matcher;
            this._printer = printer;
        }
        
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string text, string subtext)
        {
            var res = this._printer.PrintResult(this._matcher.MatchText(text, subtext));
            Console.WriteLine("Result {0}", res);
            TempData["textmatchRes"] = res;  // TODO - 1st version solution.. ;)
            return View("TextMatchResult");
        }
    }
}
