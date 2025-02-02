using Quiz_platform_User.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_platform_User.BL.ViewModels.Quizzes
{
    public class QuizDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public string Image { get; set; } = string.Empty;

        public int TotalQuestions { get; set; }
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

        public QuizDetailsVM(int id, string name, string description, DateTime date, string image, ICollection<Question> questions , int totalQuestions)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            Image = image;
            Questions=questions;
            TotalQuestions = totalQuestions;
        }

    }
}
