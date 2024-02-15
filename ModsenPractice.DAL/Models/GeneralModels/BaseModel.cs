using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Models.GeneralModels
{
    public class BaseModel
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
