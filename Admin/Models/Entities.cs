using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Admin.Models
{
    public class Entities:DbContext
    {
        public Entities() : base("SASdb") { }

        public IDbSet<HandlerModel> handlerModel { get; set; }

    }

}
