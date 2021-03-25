using System;

namespace _3_Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
        
        public abstract void Excluir();
    }
}
