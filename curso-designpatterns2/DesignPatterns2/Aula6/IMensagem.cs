namespace DesignPatterns2
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();

        string Formata();
    }

}
