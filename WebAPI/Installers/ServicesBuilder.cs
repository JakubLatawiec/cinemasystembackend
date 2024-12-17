namespace WebAPI.Installers
{
    public class ServicesBuilder : IBuilder
    {
        private readonly IBuilder _applicationBuilder = new ApplicationBuilder();
        private readonly IBuilder _infrastructureBuilder = new InfrastructureBuilder();
        public void Build(IServiceCollection services)
        {
            _applicationBuilder.Build(services);
            _infrastructureBuilder.Build(services);
        }
    }
}
