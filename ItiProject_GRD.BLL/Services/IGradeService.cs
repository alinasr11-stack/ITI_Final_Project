using ItiProject_GRD.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItiProject_GRD.BLL.Services
{
    public interface IGradeService
    {
        Task<IEnumerable<GradeVM>> GetAllAsync();
        Task<GradeVM?> GetByIdAsync(int id);
        Task<IEnumerable<GradeVM>> GetByTraineeIdAsync(int traineeId);

        Task AddAsync(GradeVM vm);
        Task UpdateAsync(GradeVM vm);
        Task DeleteAsync(int id);
    }

}
