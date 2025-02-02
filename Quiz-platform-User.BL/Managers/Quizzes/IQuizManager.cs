using Quiz_platform_User.BL.ViewModels.Quizzes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_platform_User.BL.Managers.Quizzes
{
    public interface IQuizManager
    {
        IEnumerable<QuizReadVM> GetAll();
        QuizDetailsVM? GetDetailsById(int id);
   
    }
}
