using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class ExamManagementDbContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public ExamManagementDbContext() : base("name=ExamManagementDbContext")
    {
    }

    public System.Data.Entity.DbSet<Models.Question> Questions { get; set; }

    public System.Data.Entity.DbSet<Models.Exam> Exams { get; set; }

    public System.Data.Entity.DbSet<Models.Course> Courses { get; set; }

    public System.Data.Entity.DbSet<Models.ExamType> ExamTypes { get; set; }

    public System.Data.Entity.DbSet<Models.Organization> Organizations { get; set; }

}
