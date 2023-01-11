using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class CarScrewConfigMapConfig : EntityMappingConfiguration<CarScrewConfig>
    {
        public override void Map(EntityTypeBuilder<CarScrewConfig>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

