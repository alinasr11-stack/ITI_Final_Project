using ItiProject_GRD.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItiProject_GRD.BLL.Services
{
    public interface ISessionService
    {
        Task<IEnumerable<SessionVM>> GetAllAsync();
        Task<SessionVM?> GetByIdAsync(int id);
        Task<IEnumerable<SessionVM>> GetByCourseIdAsync(int courseId);

        Task AddAsync(SessionVM vm);
        Task UpdateAsync(SessionVM vm);
        Task DeleteAsync(int id);
    }

}
