using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities
{
    public sealed class Produto : EntityBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Stock { get; private set; }
        public string Imagem { get; private set; }

        public Produto(int id, string nome, string descricao, decimal preco, int stock, string imagem)
        {
            DomainExceptionValidation.When(id < 0, "valor do Id Invalido.");
            Id = id;
            ValidateDomain(nome, descricao, preco, stock, imagem);

        }

        public Produto(string nome, string descricao, decimal preco, int stock, string imagem)
        {
            ValidateDomain(nome, descricao, preco, stock, imagem);
        }

        public void UpdateProduto(string nome, string descricao, decimal preco, int stock, string imagem,int categoriaId)
        {
            ValidateDomain(nome, descricao, preco, stock, imagem);
            CategoryId = categoriaId;
        }

        private void ValidateDomain(string nome, string descricao, decimal preco, int stock, string imagem) 
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome Invalido nome.Name");

            DomainExceptionValidation.When(nome.Length < 3, "Nome Invalido nome.Name");

            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao), "Descrição Invalido descricao.Name");

            DomainExceptionValidation.When(descricao.Length < 5, "Descrição Invalido descricao.Name");

            DomainExceptionValidation.When(preco < 0, "preço Invalido preco.Name");
            
            DomainExceptionValidation.When(stock < 0, "ação Invalido stock.Name");

            DomainExceptionValidation.When(imagem.Length > 250, "imagem invalida maximum 250 caracteres.");

            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Stock = stock;
            Imagem = imagem;



        }


        public int CategoryId { get; set; }
        public Categoria Categoria { get; set; }


    }
}
