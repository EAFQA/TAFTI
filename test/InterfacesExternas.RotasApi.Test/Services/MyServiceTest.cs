using AutoFixture;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MyCompany.MyProject.MyApi.Dtos;
using MyCompany.MyProject.MyApi.Interfaces;
using MyCompany.MyProject.MyApi.Services;
using NSubstitute;
using Xunit;

namespace MyCompany.MyProject.MyApi.Test.Services
{
    public class MyServiceTest
    {
        protected readonly Fixture _fixture;
        protected readonly IMapper _mapper;
        protected readonly IConfiguration _configuration;
        protected readonly IMyService _service;
        protected readonly IMyRepository _repository;

        public MyServiceTest()
        {
            _fixture = new Fixture();
            _configuration = Substitute.For<IConfiguration>();
            _repository = Substitute.For<IMyRepository>();
            _service = new MyService(_mapper, _repository, _configuration);
        }

        [Fact]
        public async void Get_CasoNaoEncontrePeloId_DeveRetornar404NotFound()
        {
            //Arrange
            var myId = 0;
            _repository.Get(Arg.Any<int>()).Returns(default(FilterDto));

            //Act
            var result = await _service.Get(myId);

            //Assert
            Assert.Equal(result.StatusCode, StatusCodes.Status404NotFound);
        }
    }
}