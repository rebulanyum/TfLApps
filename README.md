# TfLApps
This project is for assesment given by TfL.

- How to build the code?
Make the RoadStatus project a "Startup Project". And then build the solution.

- How to run the output
From the commandline, locate to the RoadStatus.exe directory and type the following
RoadStatus.exe <ROADNAME>
Where <ROADNAME> is the name of the road. For example:
RoadStatus.exe A1
  
- How to run any tests that that have been written
Inside the solution there is RoadStatus.Test project. You can build it and then run the tests by using Test Explorer.

- Any assumptions that has been made
For the development process it's assumed that the developer downloaded this repository is using Visual Studio 2017.
In order to run this application from the commandline it's required to make the right configuration. For the configuration please open appsettings.json file and put the required values.

- Other relevant information
UnitTests inside the RoadStatus.Test project uses pre-generated fake data and not accessing to the TfL's API hosted on https://api.tfl.gov.uk . However, during the debugging & executing the application, it is accessing to the real TfL's API hosted on https://api.tfl.gov.uk . So, in that case you have to configure the application correct by editing the application.json file.

# Note for implementors/contributors
Here is the program structure
Startup.cs contains the logic to initialize Application instance.
This application uses IRoadApi only but if it's required to use more APIs in it please follow these 2 steps

1) Add the needed interface into the constructor of Application class.
2) Add the needed interface & it's implementation class into the ApplicationConfigurator.Configure method.

After these 2 steps it will be ready to implement requirements inside the Application class.

If it's required to use another application class other than the existing Application class then after creating the class definition please do necessary changes on Startup.Main method. Or it's preferable to create another project.

If you want to contribute to my project please folow this rule: fork it --> change it --> create pull request --> wait for me to merge :). And it would be nice if you drop an issue also.

# Used technologies
For unit tests Moq v4.10.1 & MSTest is used.

For the RoadStatus application Microsoft's DependencyInjection v2.2.0 is used.

The TfL prefixed projects are created by Swagger's code generator: This is used because of TfL's API definition is created with Swagger again.

All the projects are written with C# & used .NetCore v2.1.0 with Visual Studio 2017.
