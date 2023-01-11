using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class ProductionPlanMapConfig : EntityMappingConfiguration<ProductionPlan>
    {
        public override void Map(EntityTypeBuilder<ProductionPlan>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

