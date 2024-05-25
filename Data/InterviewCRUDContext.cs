using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InterviewCRUD.Models;

namespace InterviewCRUD.Data
{
    public class InterviewCRUDContext : DbContext
    {
        public InterviewCRUDContext (DbContextOptions<InterviewCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<InterviewCRUD.Models.CarModel> CarModel { get; set; } = default!;
    }
}
