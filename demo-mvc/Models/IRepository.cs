using System.Collections.Generic;

namespace demo_mvc.Models
{
    public interface IRepository
    {
        IEnumerable<ProdutoModel> Produtos { get; }
    }
}