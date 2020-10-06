using System;

public class NewText
{
    public NewText()
    {
        string str = "asdjkhija&*%^!@..#87124687ячс.юьисмбюэжджлолдорпаыавыфйцугшекегшщзхъъйД,ЛФЫ,!*ВЛДПТЬБФЫВЙЩЦШКГЕН";
        Console.WriteLine("Исходный текст:\n" + str);
        OurText newtxt = new OurText(str);
        newtxt.Modification();

    }
}