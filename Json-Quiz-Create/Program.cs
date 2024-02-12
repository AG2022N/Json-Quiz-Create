class Program
{
    static void Main()
    {
        Console.WriteLine("Writing...");
        for (int i = 1; i <= 6;)
        {
            Console.WriteLine(i + "/6");
            string Filepath = (@"Questions/Question" + i + ".json");
            ObjectToJson(Filepath);
            i++;
        }
        Console.Write("Finished!");
        Console.ReadKey();
    }
    public class QuizQuestion(string ConstQuestion, string ConstAnswerOptions, string ConstCorrectAnswer, string ConstCorrectAnswerExplanation)
    {
        public string Question = ConstQuestion;
        public string AnswerOptions = ConstAnswerOptions;
        public string CorrectAnswer = ConstCorrectAnswer;
        public string CorrectAnswerExplanation = ConstCorrectAnswerExplanation;
    }
    static QuizQuestion QuizQuestionCreate()
    {
        QuizQuestion q = new QuizQuestion("QuestionTemp", "AnswerOptionsTemp", "CorrectAnswerTemp", "CorrectAnswerExplanationTemp");
        return q;
    }
    static void ObjectToJson(string Filepath)
    {
        string Path = Filepath;
        QuizQuestion Question = QuizQuestionCreate();
        var JsonFormatting = Newtonsoft.Json.JsonConvert.SerializeObject(Question);
        System.IO.File.WriteAllText(Path, JsonFormatting);
    }
}