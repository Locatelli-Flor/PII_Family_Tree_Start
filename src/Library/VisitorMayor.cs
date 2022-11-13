namespace Library
{
    public class VisitorMayor : Visitor
    {
        public int Mayor {get;set;}
        public override void Visit(NodoPersona n)
        {
            if (n.Children.Count == 0 && n.Person.Edad > Mayor)
            {
                this.Mayor = n.Person.Edad;
            }
        }
    }
}