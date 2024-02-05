using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.IO;
class Program
{
    static void Main()
    {
        for (int i = 1; i < 5;)
        {
            string filePath = (@"Questions/question.json");
            //string filePath = (@"Questions/question{0}.json", i);
            Convert_cs_to_json(filePath);
            i++;
        }
    }
    static void Convert_cs_to_json(string filePath)
    {
        string path = filePath;
        var question = quizQuestionCreate();
        var jsonFormattedContent = Newtonsoft.Json.JsonConvert.SerializeObject(question);
        System.IO.File.WriteAllText(path, jsonFormattedContent);
    }
    public class quizQuestion()
    {
        public string question {  get; set; }
        public string correctAnswer { get; set; }
        public string correctAnswerExplanation { get; set; }
    }

    static quizQuestion quizQuestionCreate()
    {
        var q = new quizQuestion();
        return q;
    }
}