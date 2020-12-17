﻿//namespace RubiksWorld.Services.Data.Tests
//{
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Threading.Tasks;

//    using RubiksWorld.Data;
//    using RubiksWorld.Data.Common.Repositories;
//    using RubiksWorld.Data.Models;
//    using RubiksWorld.Data.Repositories;

//    using Microsoft.EntityFrameworkCore;

//    using Moq;

//    using Xunit;

//    public class SettingsServiceTests
//    {
//        [Fact]
//        public void GetCountShouldReturnCorrectNumber()
//        {
//            var repository = new Mock<IDeletableEntityRepository<Setting>>();
//            repository.Setup(r => r.All()).Returns(new List<Setting>
//                                                        {
//                                                            new Setting(),
//                                                            new Setting(),
//                                                            new Setting(),
//                                                        }.AsQueryable());
//            var service = new SettingsService(repository.Object);
//            Assert.Equal(3, service.GetCount());
//            repository.Verify(x => x.All(), Times.Once);
//        }

//        [Fact]
//        public async Task GetCountShouldReturnCorrectNumberUsingDbContext()
//        {
//            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
//                .UseInMemoryDatabase(databaseName: "SettingsTestDb").Options;
//            using var dbContext = new ApplicationDbContext(options);
//            await dbContext.SaveChangesAsync();

//            using var repository = new EfDeletableEntityRepository<Setting>(dbContext);
//            var service = new SettingsService(repository);
//            Assert.Equal(3, service.GetCount());
//        }
//    }
//}
