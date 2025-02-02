using Quiz_platform_User.DAL.Repositories.QuizRepostository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_platform_User.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IQuizRepository QuizRepository { get; }
        void SaveChanges();
    }
}
