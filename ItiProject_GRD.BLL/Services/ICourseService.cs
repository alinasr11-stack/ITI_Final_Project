using ItiProject_GRD.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItiProject_GRD.BLL.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseVM>> GetAllAsync();
        Task<CourseVM?> GetByIdAsync(int id);
        Task<CourseVM?> GetWithSessionsAsync(int id);
        Task<IEnumerable<CourseVM>> SearchByNameAsync(string name);

        Task AddAsync(CourseVM vm);
        Task UpdateAsync(CourseVM vm);
        Task DeleteAsync(int id);
    }

}
