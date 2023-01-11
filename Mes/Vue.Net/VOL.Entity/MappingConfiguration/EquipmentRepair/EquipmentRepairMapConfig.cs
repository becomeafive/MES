using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class EquipmentRepairMapConfig : EntityMappingConfiguration<EquipmentRepair>
    {
        public override void Map(EntityTypeBuilder<EquipmentRepair>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

