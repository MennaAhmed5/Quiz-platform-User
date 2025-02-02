using Quiz_platform_User.DAL.Models;
using Quiz_platform_User.DAL.Repositories.QuizRepostository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_platform_User.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly QuizSystemContext _context;
        public IQuizRepository QuizRepository { get; }
 
        public UnitOfWork(QuizSystemContext context, IQuizRepository quizRepository )
        {
            _context = context;
            QuizRepository = quizRepository;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
