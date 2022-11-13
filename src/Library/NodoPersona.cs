using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NodoPersona
    {
        private Persona person;

        private List<NodoPersona> children = new List<NodoPersona>();

        public Persona Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<NodoPersona> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public NodoPersona(Persona p)
        {
            this.person = p;
        }

        public void AddChildren(NodoPersona p)
        {
            this.children.Add(p);
        }

        public void AcceptVisit(Visitor v)
        {
            v.Visit(this);
        }
        
    }
}
