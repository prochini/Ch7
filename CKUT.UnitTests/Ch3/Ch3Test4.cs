﻿using CKUT.Core.Services.Ch3.No6;
using FluentAssertions;
using NUnit.Framework;

namespace CKUT.UnitTests.Ch3
{
    [TestFixture]
    public class Ch3Test4
    {
        private IFileExtensionManager _fileExtensionManager;
        private string _fileName;
        private LogAnalyzer _logAnalyer;

        [SetUp]
        public void SetUp()
        {
            _fileExtensionManager = new FakeManager();
            _logAnalyer = new LogAnalyzer();
            _logAnalyer.FileExtensionManager = _fileExtensionManager;
        }

        [Test]
        public void LogAnalyzer_Should_Support_TxtFile()
        {
            GivenTxtFileName();
            _logAnalyer.IsValidFileName(_fileName).Should().Be(true);
        }

        [Test]
        public void LogAnalyzer_Should_Not_Support_PngFile()
        {
            GivenPngFileName();
            _logAnalyer.IsValidFileName(_fileName).Should().Be(false);
        }

        private void GivenTxtFileName()
        {
            _fileName = "2.txt";
        }

        private void GivenPngFileName()
        {
            _fileName = "1.png";
        }
    }
}