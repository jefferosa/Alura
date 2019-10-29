using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var cliente = contexto
                    .Clientes
                    .Include(e => e.EnderecoDeEntrega)
                    .FirstOrDefault();

                Console.WriteLine($"Endereço de Entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                var produto = contexto
                    .Produtos
                    .Where(p => p.Id == 2002)
                    .FirstOrDefault();

                contexto.Entry(produto)
                    .Collection(p => p.Compras)
                    .Query()
                    .Where(c => c.Preco > 10)
                    .Load();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine("\t" + item);
                }
            }
        }

        private static void ExibeProdutosPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                var promocao = contexto2
                    .Promocoes
                    .Include(p => p.Produtos)
                    .ThenInclude(pp => pp.Produto)
                    .FirstOrDefault();

                Console.WriteLine("\nMostrando os Produtos...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Promoção Queima de Estoque";
                promocao.DataInicio = new DateTime(2019, 06, 04);
                promocao.DataTermino = new DateTime(2019, 07, 04);

                var produtos = contexto
                    .Produtos
                    .Where(p => p.Categoria == "Mangá")
                    .ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }

                contexto.Promocoes.Add(promocao);
                contexto.SaveChanges();
            }
        }

        private static void UmParaUm()
        {
            var cad = new Cliente();
            cad.Nome = "Berry";
            cad.EnderecoDeEntrega = new Endereco()
            {
                Numero = 42,
                Logradouro = "Rua do Irineu",
                Complemento = "Perto da Irineia",
                Bairro = "Konoha",
                Cidade = "Tókyo"
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(cad);
                contexto.SaveChanges();

            }
        }

        private static void MuitoParaMuitos()
        {
            var p1 = new Produto() { Nome = "NoteBook", Categoria = "Informática", PrecoUnitario = 2000.99, Unidade = "Unidade" };
            var p2 = new Produto() { Nome = "Memória Ram NoteBook", Categoria = "Informática", PrecoUnitario = 200, Unidade = "Unidade" };
            var p3 = new Produto() { Nome = "Capa p/Notebook", Categoria = "Informática", PrecoUnitario = 100.50, Unidade = "Unidade" };
            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(2);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();

                //contexto.Promocoes.Add(promocaoDePascoa);
                var promocao = contexto.Promocoes.Find(1);
                contexto.Promocoes.Remove(promocao);

                //contexto.SaveChanges();

            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }
    }
}

