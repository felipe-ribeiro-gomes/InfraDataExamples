using System;
using InfraDataExamples.Domain;
using InfraDataExamples.Domain.Services;
using InfraDataExamples.Infra.Data;
using InfraDataExamples.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfraDataExamples.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Initializer.Initialize();
        }

        [TestMethod]
        public void Insercao()
        {
            Initializer.Initialize();
            var teste = new ProdutoService(new ProdutoRepository());

            var obj = new Produto
            {
                Nome = "teste nome",
                Marca = "teste marca",
                Modelo = "teste modelo",
                CriadoPor = "teste",
                CriadoEm = DateTime.Now,
            };

            teste.Create(obj);
        }

        [TestMethod]
        public void Listar()
        {
            var teste = new ProdutoService(new ProdutoRepository());

            teste.GetAll(q => q.Nome == "nome 1");
        }
    }
}
