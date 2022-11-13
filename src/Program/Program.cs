using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            NodoPersona n1 = new NodoPersona(new Persona("abuelo", 70));
            NodoPersona n2 = new NodoPersona(new Persona("abuela", 80));
            NodoPersona n3 = new NodoPersona(new Persona("madre", 45));
            NodoPersona n4 = new NodoPersona(new Persona("padre", 46));
            NodoPersona n5 = new NodoPersona(new Persona("hijo", 20));
            NodoPersona n6 = new NodoPersona(new Persona("hija", 23));
            NodoPersona n7 = new NodoPersona(new Persona("nieto", 5));
            NodoPersona n8 = new NodoPersona(new Persona("nieta", 3));

            n1.AddChildren(n4);
            n2.AddChildren(n4);

            n3.AddChildren(n5);
            n3.AddChildren(n6);

            n4.AddChildren(n6);
            n4.AddChildren(n5);

            n6.AddChildren(n7);
            n6.AddChildren(n8);

            VisitorCalcularEdad Visitor1 = new VisitorCalcularEdad();
            n1.AcceptVisit(Visitor1);
            n2.AcceptVisit(Visitor1);
            n3.AcceptVisit(Visitor1);
            n4.AcceptVisit(Visitor1);
            n5.AcceptVisit(Visitor1);
            n6.AcceptVisit(Visitor1);
            n7.AcceptVisit(Visitor1);
            n8.AcceptVisit(Visitor1);
            
            Console.WriteLine(Visitor1.suma);

            VisitorMayor Visitor2 = new VisitorMayor();
            n1.AcceptVisit(Visitor2);
            n2.AcceptVisit(Visitor2);
            n3.AcceptVisit(Visitor2);
            n4.AcceptVisit(Visitor2);
            n5.AcceptVisit(Visitor2);
            n6.AcceptVisit(Visitor2);
            n7.AcceptVisit(Visitor2);
            n8.AcceptVisit(Visitor2);

            Console.WriteLine(Visitor2.Mayor);

            VisitorNombre Visitor3 = new VisitorNombre();
            n1.AcceptVisit(Visitor3);
            n2.AcceptVisit(Visitor3);
            n3.AcceptVisit(Visitor3);
            n4.AcceptVisit(Visitor3);
            n5.AcceptVisit(Visitor3);
            n6.AcceptVisit(Visitor3);
            n7.AcceptVisit(Visitor3);
            n8.AcceptVisit(Visitor3);

            Console.WriteLine(Visitor3.MasLargo);

        }
    }
}
