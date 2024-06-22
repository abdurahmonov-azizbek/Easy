using System.Text;

namespace Easy.Services
{
    public class EasyService
    {
        private string projectName;
        private string modelsFolderPath;
        private string projectFolderPath;
        private string header;
        private string connectionString;
        private List<Type> modelsType = new();
        private Dictionary<Type, string> modelsNameProp = new();

        private ProjectService projectService;

        public EasyService(
            string projectName,
            string modelsFolderPath,
            string projectFolderPath,
            string header,
            string connectionString,
            List<Type> modelsType,
            Dictionary<Type, string> modelsNameProp)
        {
            this.projectName = projectName;
            this.modelsFolderPath = modelsFolderPath;
            this.projectFolderPath = projectFolderPath;
            this.header = header;
            this.connectionString = connectionString;
            this.modelsType = modelsType;
            this.modelsNameProp = modelsNameProp;

            projectService = new ProjectService(
                projectName: projectName,
                modelsFolderPath: modelsFolderPath,
                projectFolderPath: projectFolderPath,
                header: header,
                connectionString: connectionString,
                models: modelsType,
                modelsNameProp: modelsNameProp);
        }

        public void Initialize()
        {
            Validate();

            var projectsPath = projectService.CreateProjectStructure();

            projectService.InitializeBuildProject();

            PackageManager.InstallPackagesToApiProject(projectsPath.ApiProjectPath);
            PackageManager.InstallPackagesToBuildProject(projectsPath.BuildProjectPath);
            PackageManager.InstallPackagesToTestProject(projectsPath.TestProjectPath);

            projectService.CreateModels();
            projectService.CreateExceptions();
            projectService.CreateBrokers();
            projectService.CreateServices();
            projectService.CreateControllers();
            projectService.ConfigureProject();
            projectService.WriteTests();
            projectService.BuildBuildProject();
        }

        private void Validate()
        {
            var modelsCount = Directory.GetFiles(this.modelsFolderPath).Count();

            if (modelsType.Count() != modelsCount)
            {
                throw new ArgumentException($"There are {modelsCount} models, but given {modelsType.Count()}");
            }

            if(modelsNameProp.Count() != modelsCount)
            {
                throw new ArgumentException($"There are {modelsCount}, but given {modelsNameProp.Count()} in modelsNameProp");
            }

            foreach (var modelType in modelsType)
            {
                if (!modelType.GetProperties().Any(x => x.Name == "CreatedDate"))
                    throw new InvalidOperationException($"There is no CreatedDate in {modelType.Name}");

                if (!modelType.GetProperties().Any(x => x.Name == "UpdatedDate"))
                    throw new InvalidOperationException($"There is no UpdatedDate in {modelType.Name}");
            }
        }
    }
}