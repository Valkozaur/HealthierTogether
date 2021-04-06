namespace HealthierTogether.Server.Infrastructure.Mapper
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}
