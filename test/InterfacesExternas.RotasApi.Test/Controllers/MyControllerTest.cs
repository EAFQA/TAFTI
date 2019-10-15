using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCompany.MyProject.MyApi.Controllers;
using MyCompany.MyProject.MyApi.Dtos;
using MyCompany.MyProject.MyApi.Interfaces;
using NSubstitute;
using Xunit;

namespace MyCompany.MyProject.MyApi.Test.Controllers
{
    public class MyControllerTest
    {
        protected readonly Fixture fixture;
        protected readonly ILogger<MyController> _logger;
        protected readonly IMyService _service;
        protected readonly MyController _controller;
        protected readonly FilterDto _filter;
        protected readonly MyBaseDto _baseDto;

        public MyControllerTest()
        {
            fixture = new Fixture();
            _logger = Substitute.For<ILogger<MyController>>();
            _service = Substitute.For<IMyService>();
            _controller = new MyController(_logger, _service);
            _filter = new FilterDto();
            _baseDto = new MyBaseDto();
        }

        [Fact]
        public async void Get_QuandoExecutarComSucesso_DeveRetornarStatusCode200Ok()
        {
            //Arrange
            _baseDto.StatusCode = StatusCodes.Status200OK;
            _service.Get(0).Returns(_baseDto);
            var myId = 0;

            //Act
            var resultado = await _controller.Get(myId) as ObjectResult;

            //Assert
            resultado.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact]
        public async void GetAll_QuandoExecutarComSucesso_DeveRetornarStatusCode200Ok()
        {
            //Arrange
            _baseDto.StatusCode = StatusCodes.Status200OK;
            _service.GetAll(_filter).Returns(_baseDto);

            //Act
            var resultado = await _controller.GetAll(_filter) as ObjectResult;

            //Assert
            resultado.StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}