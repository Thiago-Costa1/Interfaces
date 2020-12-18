namespace Nova_pasta.Classes
{
    public interface ICarrinho
    {
         // CRUD
         // Create
        void Cadastrar(Produto produto);

         // Read
        void Listar();

         // Update
        void Alterar(int cod, Produto novoProduto);

         // Delete
         void Deletar(int cod);

    }          
    
}