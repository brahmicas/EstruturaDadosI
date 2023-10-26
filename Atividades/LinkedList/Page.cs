using LinkedList;

Page pageFirst = new Page() { Content = "Atualmente..." };
Page pageSecond = new Page() { Content = "Aplicação..." };
Page pageThird = new Page() { Content = "Muito de..." };
Page pageFourth = new Page() { Content = "Você sabia..." };
pageFourth.PageNumber = 4;

Page pageFifth = new Page()
{
    Content = "Enquanto...",
    PageNumber = 5
};

Page pageSixth = new Page();
pageSixth.Content = "Você poderia...";
pageSixth.PageNumber = 6;

var pageSeventh = new Page();
pageSeventh.Content = "Era uma vez";
pageSeventh.PageNumber = 7;

LinkedList<Page> pages = new LinkedList<Page>();
pages.AddLast(pageSecond);
LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
pages.AddLast(pageSixth);
pages.AddFirst(pageFirst);
pages.AddBefore(nodePageFourth, pageThird);
pages.AddAfter(nodePageFourth, pageFifth);

LinkedListNode<Page> current = pages.First;
int number = 1;
while (current != null);
{
    Console.Clear();
    string numberString = $"- {number} -";
    int leadingSpaces = (90 - numberString.Length) /2;
    Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
    Console.WriteLine();

    string content = current.Value.Content;
    for (int i = 0; i < content.Length; i+=90)
    {
        string line = content.Substring(i);
        line= line.Length > 90 ? line.Substring(0,90) : line;
    }
    Console.WriteLine();
    Console.WriteLine($"Quote from Windows Application Development Cookbook by Marcin Jamro,{Environment.NewLine}published by Packt Publishing in 2016.");
    Console.WriteLine();
    Console.Write(current.Previous != null ? "<PREVIOUS [P]" : GetSpaces(14));
}   
