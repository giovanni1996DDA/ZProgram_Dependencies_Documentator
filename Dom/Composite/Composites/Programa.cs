using Dom.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom.Composite
{
    public class Programa : ObjetoZ
    {
        private List<ObjetoZ> _children = new List<ObjetoZ>();

        public Programa() 
        {
            this.TipoObj = TipoObjetoZ.Programa;
        }
        public override void Add(ObjetoZ component)
        {
            _children.Add(component);
        }

        public override void Remove(ObjetoZ component)
        {
            _children.Remove(component);
        }

        public override List<ObjetoZ> GetChildren()
        {
            return _children;
        }
    }
}
