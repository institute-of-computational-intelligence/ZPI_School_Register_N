using AutoMapper;

namespace Kolokwium.Web.Configuration
{
    public static class AutoMapperConfig
    {
        public static IMapperConfigurationExpression Mapping(this IMapperConfigurationExpression configurationExpression)
        {
            Mapper.Initialize(mapper =>
            {
                //....... other maps.........
                //....
            });
            return configurationExpression;
        }
    }
}
