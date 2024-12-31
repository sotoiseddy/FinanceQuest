using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinanceQuest.Services
{
    public class LessonService
    {
        public List<Lesson> LoadLessons()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FinanceQuest.Resources.Raw.lessons.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Lesson>>(json);
                }
            }
        }
    }

    public class Lesson
    {
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<QuizQuestion> Quiz { get; set; }
    }

    public class QuizQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOption { get; set; }
    }

}
