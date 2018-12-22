using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models.SearchCriteria
{
  public  class QuestionSearchCriteria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Exam> Exams { get; set; }
       
        public List<SelectListItem> QuestionList { get; set; }
        public List<Question> Question { get; set; } 

    }
}
