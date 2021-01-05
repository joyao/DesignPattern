using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayContext context = new PlayContext();
            //音樂-上海灘
            Console.WriteLine("上海灘：");
            context.PlayText = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
            //音樂-隱形的翅膀
            //Console.WriteLine("隱形的翅膀："); 
            //context.PlayText = "T 1000 O 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 E 1 D 0.5 C 0.5 C 0.5 C 0.5 C 0.5 O 1 A 0.25 G 0.25 G 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 G 0.5 D 0.25 E 0.25 D 0.5 C 0.25 D 0.25 D 1 A 0.5 G 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 E 0.5 D 0.5 C 0.5 C 0.25 D 0.25 O 1 A 1 G 0.5 A 0.5 O 2 C 1.5 D 0.25 E 0.25 D 1 E 0.5 C 0.5 C 3 O 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 E 1 D 0.5 C 0.5 C 0.5 C 0.5 C 0.5 O 1 A 0.25 G 0.25 G 1 G 0.5 O 2 C 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 G 0.5 D 0.25 E 0.25 D 0.5 C 0.25 D 0.25 D 1 A 0.5 G 0.5 E 1.5 G 0.5 G 0.5 G 0.5 A 0.5 G 0.5 E 0.5 D 0.5 C 0.5 C 0.25 D 0.25 O 1 A 1 G 0.5 A 0.5 O 2 C 1.5 D 0.25 E 0.25 D 1 E 0.5 C 0.5 C 3 E 0.5 G 0.5 O 3 C 1.5 O 2 B 0.25 O 3 C 0.25 O 2 B 1 A 0.5 G 0.5 A 0.5 O 3 C 0.5 O 2 E 0.5 D 0.5 C 1 C 0.5 C 0.5 C 0.5 O 3 C 1 O 2 G 0.25 A 0.25 G 0.5 D 0.25 E 0.25 D 0.5 C 0.25 D 0.25 D 3 E 0.5 G 0.5 O 3 C 1.5 O 2 B 0.25 O 3 C 0.25 O 2 B 1 A 0.5 G 0.5 A 0.5 O 3 C 0.5 O 2 E 0.5 D 0.5 C 1 C 0.5 C 0.5 C 0.5 O 3 C 1 O 2 G 0.25 A 0.25 G 0.5 D 0.25 E 0.25 D 0.5 C 0.5 C 3 ";
            Expression expression = null;
            try
            {
                while (context.PlayText.Length > 0)
                {
                    string str = context.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        case "O":
                            expression = new Scale();
                            break;
                        case "T":
                            expression = new Speed();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new Note();
                            break;

                    }
                    expression.Interpret(context);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
