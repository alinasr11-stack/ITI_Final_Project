using ItiProject_GRD.DLL.Data;
using ItiProject_GRD.DLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItiProject_GRD.DLL.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context) { }

        public async Task<Course> GetCourseWithSessionsAsync(int id)
        {
            return await _context.Courses.Include(c => c.Sessions).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Course>> SearchByNameAsync(string name)
        {
            return await _context.Courses.Where(c => c.Name.Contains(name)).ToListAsync();
        }
    }

}
