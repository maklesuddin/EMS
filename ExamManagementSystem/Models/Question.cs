using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Exam> Exams { get; set; }
        [NotMapped]
        public List<SelectListItem> QuestionList { get; set; } 

    }
}
