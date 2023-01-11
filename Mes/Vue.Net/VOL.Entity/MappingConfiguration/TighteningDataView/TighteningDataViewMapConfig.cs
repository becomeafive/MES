using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class TighteningDataViewMapConfig : EntityMappingConfiguration<TighteningDataView>
    {
        public override void Map(EntityTypeBuilder<TighteningDataView>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

