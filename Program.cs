using System;
namespace InheritenceMethod
{
    public class Program
    {
        static void Main()
        {
            var basic = new DocumentProgram("basic","pro","expert");
            Console.WriteLine(basic.OpenDocument());

            var pro = new ProDocumentProgram("basic", "pro", "expert");
            Console.WriteLine(pro.EditDocument());

            var expert = new ExpertDocumentProgram("basic", "pro", "expert");
            Console.WriteLine(expert.SaveDocument());
        }
    }
}

