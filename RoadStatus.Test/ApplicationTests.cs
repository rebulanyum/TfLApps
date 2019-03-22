using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TfL.TransportAPI.Client;
using System.Linq;
using System;
using TfLApps.RoadStatus;
using System.IO;
using System.Text;
using TfL.TransportAPI.Client.Model;

namespace RoadStatus.Test
{
    [TestClass]
    public class ApplicationTests : ConsoleTestBase
    {
        Mock<IRoadApi> RoadApiMock { get; set; }

        const string validRoadId = "A1";
        const string invalidRoadId = "A1qweqweqweqweqweqweqw";
        readonly TflApiPresentationEntitiesRoadCorridor road;

        public ApplicationTests()
        {
            RoadApiMock = new Mock<IRoadApi>();
            RoadApiMock.Setup(api => api.RoadGet_1(It.Is<List<string>>(listOfString => listOfString.Count == 1 && validRoadId.Equals(listOfString[0], StringComparison.InvariantCultureIgnoreCase))))
                       .Returns(new SampleData().Get_Road_A1_Response);

            RoadApiMock.Setup(api => api.RoadGet_1(It.Is<List<string>>(listOfString => listOfString.Count == 1 && invalidRoadId.Equals(listOfString[0], StringComparison.InvariantCultureIgnoreCase))))
                       .Throws(new SampleData().Get_Road_Invalid_Response);

            var roadApi_roadGet_args = new List<string>() { validRoadId };
            road = RoadApiMock.Object.RoadGet_1(roadApi_roadGet_args)[0];
            RoadApiMock.Invocations.Clear();
        }

        [TestMethod]
        public void Given_ValidRoadId_Then_RoadApiIsCalled()
        {
            var app = new Application(RoadApiMock.Object);
            var appArgs = new string[] { validRoadId };

            var appState = app.Run(appArgs);

            Assert.AreEqual(appState, ApplicationState.Successful);
            RoadApiMock.Verify(roadApi => roadApi.RoadGet_1(new List<string>() { validRoadId }), Times.Once, "Not called the api: IRoadApi.RoadGet_1");
        }

        [TestMethod]
        public void Given_ValidRoadId_Then_RoadDisplayNameIsDisplayed()
        {
            var app = new Application(RoadApiMock.Object);
            var appArgs = new string[] { validRoadId };

            var appState = app.Run(appArgs);

            Assert.AreEqual(appState, ApplicationState.Successful);

            string consoleOutput = ReadConsoleOut();
            Assert.IsTrue(consoleOutput.Contains(road.DisplayName));
        }

        [TestMethod]
        public void Given_ValidRoadId_Then_RoadStatusSeverityIsDisplayed()
        {
            var app = new Application(RoadApiMock.Object);
            var appArgs = new string[] { validRoadId };

            var appState = app.Run(appArgs);

            Assert.AreEqual(appState, ApplicationState.Successful);

            string consoleOutput = ReadConsoleOut();
            Assert.IsTrue(consoleOutput.Contains(road.StatusSeverity));
            Assert.IsTrue(consoleOutput.Contains("Road Status"));
        }

        [TestMethod]
        public void Given_ValidRoadId_Then_RoadStatusSeverityDescriptionIsDisplayed()
        {
            var app = new Application(RoadApiMock.Object);
            var appArgs = new string[] { validRoadId };

            var appState = app.Run(appArgs);

            Assert.AreEqual(appState, ApplicationState.Successful);

            string consoleOutput = ReadConsoleOut();
            Assert.IsTrue(consoleOutput.Contains(road.StatusSeverityDescription));
            Assert.IsTrue(consoleOutput.Contains("Road Status Description"));
        }

        [TestMethod]
        public void Given_InvalidRoadId_Then_InformativeErrorMessageDisplayed_And_ReturnsNonZeroState()
        {
            var app = new Application(RoadApiMock.Object);
            var appArgs = new string[] { invalidRoadId };

            var appState = app.Run(appArgs);

            Assert.AreEqual(appState, ApplicationState.UserError);

            string consoleOutput = ReadConsoleOut();
            Assert.IsTrue(!string.IsNullOrWhiteSpace(consoleOutput));
        }
    }
}
