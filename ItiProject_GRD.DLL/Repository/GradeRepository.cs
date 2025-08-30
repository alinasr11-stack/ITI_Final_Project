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
    public class GradeRepository : GenericRepository<Grade>, IGradeRepository
    {
        public GradeRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Grade>> GetGradesByTraineeIdAsync(int traineeId)
        {
            return await _context.Grades
                .Include(g => g.Session)
                    .ThenInclude(s => s.Course)  // << هنا ضفت الـ Include للكورس
                .Where(g => g.TraineeId == traineeId)
                .ToListAsync();
        }
    }

}
