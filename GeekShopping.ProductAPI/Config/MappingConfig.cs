using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public static class MappingConfig
    {
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVo, Product>();
                config.CreateMap<Product, ProductVo>();
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            mappingConfig.CompileMappings();

            return services;
        }
    }
}
