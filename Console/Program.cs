// See https://aka.ms/new-console-template for more information
using LoggerLib;


ILayout simpleLayout = new SimpleLayout();

IAppender consoleAppender = new ConsoleAppender(simpleLayout);
consoleAppender.ReportLevel = ReportLevel.INFO;


var file = new LogFile();
var fileAppender = new FileAppender(simpleLayout);
fileAppender.ReportLevel = ReportLevel.INFO;
fileAppender.File = file;


//ILogger logger = new Logger(consoleAppender);
ILogger logger = new Logger(consoleAppender, fileAppender); 



logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
logger.Warn("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");





