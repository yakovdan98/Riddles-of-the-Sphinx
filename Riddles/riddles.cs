
using System.Collections.Generic;

namespace Questions
{
  public class Riddle
  {
    public List<string> RiddleList { get; set; } = new List<string>();
    public List<string> AnswerList { get; set; } = new List<string>();
    public int NumRiddles { get; set; } = 0;

    public void addRiddle(string riddle, string answer)
    {
      RiddleList.Add(riddle);
      AnswerList.Add(answer);
      NumRiddles++;
    }
  }
}