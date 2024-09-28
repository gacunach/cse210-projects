using System;
using System.Collections.Generic;

public class PromptGenerator
{

    private List<string> _prompts;

  
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "Describe a memorable moment from the past week.",
            "What personal goals are you working towards?",
            "How do you feel today and why?",
            "Write about someone who made an impact on your life."
        };
    }

    

    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}