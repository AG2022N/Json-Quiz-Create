class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5;)
        {
            string Filepath = (@"Questions/Question" + i + ".json");
            ObjectToJson(Filepath);
            i++;
        }
        Console.Write("Complete!");
        Console.ReadKey();
    }
    public class QuizQuestion()
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string CorrectAnswerExplanation { get; set; }
    }
    static QuizQuestion QuizQuestionCreate()
    {
        var q = new QuizQuestion();
        return q;
    }
    static void ObjectToJson(string Filepath)
    {
        string Path = Filepath;
        QuizQuestion Question = QuizQuestionCreate();
        var JsonFormating = Newtonsoft.Json.JsonConvert.SerializeObject(Question);
        System.IO.File.WriteAllText(Path, JsonFormating);
    }
}