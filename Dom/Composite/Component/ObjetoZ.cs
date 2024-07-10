using Dom.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom.Composite
{
    public abstract class ObjetoZ
    {
        public Guid ID { get; set; }
        public string Nombre { get; set; }
        public TipoObjetoZ TipoObj { get; set; }
        public abstract void Add(ObjetoZ component);
        public abstract void Remove(ObjetoZ component);
        public abstract List<ObjetoZ> GetChildren();
    }
}
