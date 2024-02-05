class Program
{
    static void Main()
    {
        for (int i = 1; i < 5;)
        {
            string filePath = (@"Questions/Question.json");
            //string filePath = (@"Questions/Question{0}.json", i.ToString());
            Convert_object_to_json(filePath);
            i++;
        }
        Console.Write("Complete!");
        Console.ReadKey();
    }
    public class QuizQuestion()
    {
        public string question { get; set; }
        public string correctAnswer { get; set; }
        public string correctAnswerExplanation { get; set; }
    }
    static QuizQuestion quizQuestionCreate()
    {
        var q = new QuizQuestion();
        return q;
    }
    static void Convert_object_to_json(string filePath)
    {
        string path = filePath;
        var question = quizQuestionCreate();
        var jsonFormating = Newtonsoft.Json.JsonConvert.SerializeObject(question);
        System.IO.File.WriteAllText(path, jsonFormating);
    }
}