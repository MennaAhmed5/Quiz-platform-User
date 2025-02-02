using Quiz_platform_User.BL.ViewModels.Quizzes;
using Quiz_platform_User.DAL.Models;
using Quiz_platform_User.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_platform_User.BL.Managers.Quizzes
{
    public class QuizManager : IQuizManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuizManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<QuizReadVM> GetAll()
        {
            IEnumerable<Quize> quizzes =_unitOfWork.QuizRepository.GetAllUsingProc();

            IEnumerable<QuizReadVM> quizzesVM = quizzes
                .Select(q => new QuizReadVM(q.Id, q.Name, q.Description, q.Date));

            return quizzesVM;
        }

        public QuizDetailsVM? GetDetailsById(int id)
        {
            var quiz = _unitOfWork.QuizRepository.GetWithQuestionsById(id);
            if (quiz is null)
                return null;

            return new QuizDetailsVM(quiz.Id,
                quiz.Name,
                quiz.Description,
                quiz.Date,
                quiz.Image, quiz.Questions , quiz.Questions.Count());
        }
    }
}
