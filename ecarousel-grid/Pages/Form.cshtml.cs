using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecarouselGrid.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ecarouselGrid.Pages
{
    public class FormModel : PageModel
    {
        //WOWOCO: 1
        [BindProperty]
        public Greetings _myGreetings { get; set; }

        //WOWOCO: 2
        private DbBridge _myDbBridge { get; set; }

        //WOWOCO: 3
        private IConfiguration _myConfiguration { get; set; }

        //WOWOCO: 4 CONNECT TO MY DATABASE

        public FormModel(DbBridge DbBridge, IConfiguration Configuration)
        {
            _myDbBridge = DbBridge;
            _myConfiguration = Configuration;
        }




        public void OnGet()
        {

        }


    }
}
