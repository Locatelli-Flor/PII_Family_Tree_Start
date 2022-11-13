namespace Library
{
    public class VisitorCalcularEdad : Visitor
    {
        public int suma {get;set;}
        public override void Visit(NodoPersona n)
        {
            suma += n.Person.Edad;
        }
    }
}