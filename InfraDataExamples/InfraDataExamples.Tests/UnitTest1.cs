using System;
using InfraDataExamples.Domain;
using InfraDataExamples.Domain.Services;
using InfraDataExamples.Infra.Data.EF.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfraDataExamples.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Insercao()
        {
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
    }
}
