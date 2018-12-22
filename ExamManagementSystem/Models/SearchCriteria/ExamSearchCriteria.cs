using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models.SearchCriteria
{
    public class ExamSearchCriteria
    {
        public int Id { get; set; }
         [Display(Name = " Organization")]
        public int OrganizationId { get; set; }
         [Display(Name = " Course")]
        public int CourseId { get; set; }
        [Display(Name = " ExamType")]
        public int ExamTypeId { get; set; }
        public string Code { get; set; }
        [Display(Name = "Exam Topic")]
        public string Topic { get; set; }
        public double FullMarks { get; set; }
        [Display(Name = " Question")]
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public bool IsDeleted { get; set; }

       

        public List<SelectListItem> OrganizationListItem { get; set; }
        public List<SelectListItem> ExamTypeListItem { get; set; }
        public List<SelectListItem> QuestionListItem { get; set; }
        public List<Exam> ExamlisList { get; set; }
    }
}
