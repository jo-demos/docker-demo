using System.Collections.Generic;

namespace demo_mvc.Models
{
    class TesteRepository : IRepository
    {
        private static ProdutoModel[] _produtos => new ProdutoModel[]
        {
            new ProdutoModel()
            {
                IdProduto = 10,
                Nome = "Caneta",
                Categoria = "Material",
                Preco = 2.0M,
            },
            new ProdutoModel()
            {
                IdProduto = 20,
                Nome = "Borracha",
                Categoria = "Material",
                Preco = 1.5M,
            },
            new ProdutoModel()
            {
                IdProduto = 30,
                Nome = "Estojo",
                Categoria = "Material",
                Preco = 3.0M,
            }
        };

        public IEnumerable<ProdutoModel> Produtos => _produtos;
    }
}