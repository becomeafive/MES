using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class ComponentMaintenanceMapConfig : EntityMappingConfiguration<ComponentMaintenance>
    {
        public override void Map(EntityTypeBuilder<ComponentMaintenance>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

