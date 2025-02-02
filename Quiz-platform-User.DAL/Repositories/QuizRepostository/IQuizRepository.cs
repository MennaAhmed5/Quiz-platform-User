using Microsoft.EntityFrameworkCore;
using Quiz_platform_User.DAL.Models;
using Quiz_platform_User.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_platform_User.DAL.Repositories.QuizRepostository
{
    public interface IQuizRepository : IGenericRepository<Quize>
    {

        IEnumerable<Quize> GetAllUsingProc();
        Quize? GetWithQuestionsById(int id);
    }
}
