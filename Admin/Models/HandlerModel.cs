using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class HandlerModel
    {
        [Key]
        public int handlerId { get; set; }
        [Required]
        public string handlerName { get; set; }
    }
}
