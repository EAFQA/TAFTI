using FluentAssertions;
using MyCompany.MyProject.MyApi.Dtos;
using MyCompany.MyProject.MyApi.Utils.Validators;
using System.Collections.Generic;
using Xunit;

namespace MyCompany.MyProject.MyApi.Test.Validators
{
    public class MyValidatorTest
    {
        protected readonly MyValidator _validator;
        protected readonly FilterDto _filter;

        public MyValidatorTest()
        {
            _filter = new FilterDto();
            _validator = new MyValidator();
        }

        [Fact]
        public void FilterDto_QuandoPaginaForMenorQue1_DeveInvalidar()
        {
            //Arrange
            _filter.Page = 0;

            //Act
            var result = _validator.Validate(_filter);

            //Assert
            result.IsValid.Should().BeFalse();
        }

        [Fact]
        public void FilterDto_QuandoPaginaForMaiorQue0_DeveValidar()
        {
            //Arrange
            _filter.Page = 1;

            //Act
            var result = _validator.Validate(_filter);

            //Assert
            result.IsValid.Should().BeTrue();
        }
    }
}
