using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCompany.MyProject.MyApi.Controllers;
using MyCompany.MyProject.MyApi.Dtos;
using MyCompany.MyProject.MyApi.Interfaces;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using System;
using Xunit;

namespace MyCompany.MyProject.MyApi.Test.Controllers
{
    public class BaseControllerTest
    {
        protected readonly Fixture fixture;
        protected readonly ILogger<MyController> _logger;
        protected readonly IMyService _service;
        protected readonly MyController _controller;
        protected readonly FilterDto _filter;

        public BaseControllerTest()
        {
            fixture = new Fixture();
            _logger = Substitute.For<ILogger<MyController>>();
            _service = Substitute.For<IMyService>();
            _controller = new MyController(_logger, _service);
            _filter = new FilterDto();
        }

        [Fact]
        public async void Get_QuandoExistirExcecao_DeveRetornarStatusCode500()
        {
            //Arrange
            _service.Get(0).Throws(new Exception());
            var myId = 0;

            //Act
            var resultado = await _controller.Get(myId) as ObjectResult;

            //Assert
            resultado.StatusCode.Should().Be(StatusCodes.Status500InternalServerError);
        }

        [Fact]
        public async void GetAll_QuandoExistirExcecao_DeveRetornarStatusCode500()
        {
            //Arrange
            _service.GetAll(_filter).Throws(new Exception());

            //Act
            var resultado = await _controller.GetAll(_filter) as ObjectResult;

            //Assert
            resultado.StatusCode.Should().Be(StatusCodes.Status500InternalServerError);
        }
    }
}