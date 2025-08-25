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
    public class SessionRepository : GenericRepository<Session>, ISessionRepository
    {
        public SessionRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Session>> GetByCourseIdAsync(int courseId)
        {
            return await _context.Sessions.Where(s => s.CourseId == courseId).ToListAsync();
        }
    }
}
