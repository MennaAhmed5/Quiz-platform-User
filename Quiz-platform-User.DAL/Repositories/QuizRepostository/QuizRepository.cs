using Microsoft.EntityFrameworkCore;
using Quiz_platform_User.DAL.Models;
using Quiz_platform_User.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_platform_User.DAL.Repositories.QuizRepostository
{
    public class QuizRepository : GenericRepository<Quize>, IQuizRepository
    {
        private readonly QuizSystemContext _context;
        public QuizRepository(QuizSystemContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Quize> GetAllUsingProc()
        {
            var quizzes = _context.Quizes.FromSqlRaw("EXEC GetAllQuizes").ToList();
            return quizzes;
        }

        public Quize? GetWithQuestionsById(int id)
        {
            return _context.Set<Quize>()
            .AsNoTracking()
            .Include(q => q.Questions)
            .ThenInclude(qu=>qu.Answers)
            .FirstOrDefault(q => q.Id == id);
        }

    }
}
