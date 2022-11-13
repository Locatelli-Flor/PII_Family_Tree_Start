namespace Library
{
    public class VisitorNombre : Visitor
    {
        public string MasLargo = "";
        public override void Visit(NodoPersona n)
        {
            if (n.Person.Nombre.Length > this.MasLargo.Length)
            {
                this.MasLargo = n.Person.Nombre;
            }
        }
    }
}