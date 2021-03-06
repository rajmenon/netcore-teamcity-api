﻿using FluentAssertions;
using NetCoreTeamCity.Api;
using NetCoreTeamCity.Locators;
using NUnit.Framework;

namespace NetCoreTeamCity.Tests.Locators.BuildConfiguration
{
    [TestFixture]
    public class BuildConfigurationLocatorTests
    {
        [Test]
        public void By_Id()
        {
            // Arrange
            var locator = By.BuildType.Id("testId");

            // Act
            var query = (locator as ILocator).GetLocatorQueryString();

            // Assert
            query.Should().Be("buildType:(id:testId)");
        }

        [Test]
        public void By_Name()
        {
            // Arrange
            var locator = By.BuildType.Name("Some Name With Spaces & special characters");

            // Act
            var query = (locator as ILocator).GetLocatorQueryString();

            // Assert
            query.Should().Be("buildType:(name:Some+Name+With+Spaces+%26+special+characters)");
        }
    }
}
