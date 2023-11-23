namespace pratica3;

class ProdutoNaoEncontrado : Exception{
    public ProdutoNaoEncontrado()
        :base("Produto nao encontrado")
    {}
}