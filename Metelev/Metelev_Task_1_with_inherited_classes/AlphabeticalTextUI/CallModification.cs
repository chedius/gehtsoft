using System;

public class CallModification
{
    public CallModification()
    {
        string str = "asdjkhija&*%^!@..#87124687ячс.юьисмбюэжджлолдорпаыавыфйцугшекегшщзхъъйД,ЛФЫ,!*ВЛДПТЬБФЫВЙЩЦШКГЕН";
        Console.WriteLine("Исходный текст:\n" + str);
        Modification newtxt = new Modification(str);
        newtxt.Modificate();

    }
}