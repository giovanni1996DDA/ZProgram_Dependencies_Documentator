﻿using Dom.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom.Composite
{
    public class ElementoDeDato : ObjetoZ
    {
        public ElementoDeDato() 
        {
            this.TipoObj = TipoObjetoZ.Elemento;
        }
        public override void Add(ObjetoZ component)
        {
            throw new NotImplementedException();
        }
        public override void Remove(ObjetoZ component)
        {
            throw new NotImplementedException();

        }
        public override List<ObjetoZ> GetChildren()
        {
            throw new NotImplementedException();
        }
    }
}
