using Education.Models;
using Education.Repository;
using Moq;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace Education.Test
{
    public abstract class RepositoryTests<T> where T : IModel
    {
        private readonly IRepository<T> repository;

        protected RepositoryTests()
        {
            var resource = CreateMockResource();
            repository = new Repository<T>(resource);
        }

        private IResource<T> CreateMockResource()
        {
            var resource = new Mock<IResource<T>>();
            var entities = Enumerable.Empty<T>();

            resource
                .Setup(r => r.WriteAll(It.IsAny<IEnumerable<T>>()))
                .Callback<IEnumerable<T>>(e => entities = e);
            
            resource
                .Setup(r => r.ReadAll())
                .Returns(entities);

            return resource.Object;
        }

        protected abstract T CreateEntity();

        [Fact]
        public void AddTest()
        {
            var createdEntity = AddEntity();
            Assert.NotEqual(default, createdEntity.Id);
        }

        private T AddEntity()
        {
            var entity = CreateEntity();
            return repository.Add(entity);
        }

        [Fact]
        public void GetAllTest()
        {
            var createdEntity = AddEntity();
            var entities = repository.GetAll();

            Assert.Single(entities, createdEntity);
        }
    }
}