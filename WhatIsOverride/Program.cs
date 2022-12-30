using System;

namespace WhatIsOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent= new Parent();
            parent.Say();
            parent.Walk();
            parent.Run();

            Child child= new Child();
            child.Say();
            child.Walk();
            child.Run();

            

            StoreButton storeButton = new StoreButton();
            storeButton.OnClickButton();

            QuestButton questbutton = new QuestButton();
            questbutton.OnClickButton();


            Slime slime = new Slime();
            
            Console.WriteLine("[]", slime.Name);
        }
    }
}