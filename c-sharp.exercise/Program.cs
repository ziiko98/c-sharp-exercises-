using c_sharp.exercise;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

// Exercise 2

List<Tool> tools = new List<Tool>();

    tools.Add(new Tool { Id = 1, Title = "Strawberry" });
    tools.Add(new Tool { Id = 2, Title = "Raspberry" });
    tools.Add(new Tool { Id = 3, Title = "Wildberry" });
    tools.Add(new Tool { Id = 4, Title = "Watermelon" });
    tools.Add(new Tool { Id = 5, Title = "Honeydew"});
    
    tools.Remove(tools[1]);
    Tool? foundTool = tools.Find(p => p.Id == 3);
   if (foundTool != null)
   { 
       Console.WriteLine(foundTool.Title);

   }
    foreach (Tool tool in tools)
    {
        Console.WriteLine(tool.Title);
    }


// Exercise 1 
List<string> words = new List<string>();    
words.Add("Blueberry");
words.Add("Cherry");
words.Add("Kiwi");
words.Add("Ananas");
words.Sort();
foreach (string word in words)
{
    Console.WriteLine(word);
}
