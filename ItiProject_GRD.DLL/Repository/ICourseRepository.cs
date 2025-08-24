using ItiProject_GRD.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItiProject_GRD.DLL.Repository
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<Course> GetCourseWithSessionsAsync(int id);
        Task<IEnumerable<Course>> SearchByNameAsync(string name);
    }
}
