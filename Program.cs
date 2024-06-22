using Easy.Models;
using Easy.Services;

var service = new EasyService(
    projectName: "EZone",
    modelsFolderPath: "D:\\PROJECTS\\Easy\\Models\\",
    projectFolderPath: "D:\\EZone",
    header: "// --------------------------------------------------------\r\n// Copyright (c) Coalition of Good-Hearted Engineers\r\n// Developed by abdurahmonov-azizbek\r\n// --------------------------------------------------------",
    connectionString: "Host=localhost;Port=5432;Database=EZoneDB;UserName=postgres;Password=postgres",
    modelsType: new List<Type>()
    {
        typeof(Answer),
        typeof(Comment),
        typeof(Level),
        typeof(Like),
        typeof(Shared),
        typeof(Test),
        typeof(TestOption),
        typeof(User),
        typeof(Word)
    },
    modelsNameProp: new Dictionary<Type, string>()
    {
        { typeof(Answer), string.Empty },
        { typeof(Comment), string.Empty },
        { typeof(Level), nameof(Level.Name) },
        { typeof(Like), string.Empty },
        { typeof(Shared), nameof(Shared.Title) },
        { typeof(Test),  string.Empty},
        { typeof(TestOption), string.Empty},
        { typeof(User), nameof(User.FirstName) },
        { typeof(Word), nameof(Word.English) }
    }
    );

service.Initialize();