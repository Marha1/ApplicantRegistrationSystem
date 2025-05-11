using ApplicantRegistrationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.Repository.Interfaces
{
    public interface IAbiturientSubjectRepository : IBaseRepository<AbiturientSubject>
    {
        Task<List<AbiturientSubject>> GetByAbiturientIdAsync(int abiturientId);
    }
}
