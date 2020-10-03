using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrionInnovation.Domain;

namespace OrionInnovation.Persistence
{
  public class TextConfiguration : IEntityTypeConfiguration<Text>
    {
        public void Configure(EntityTypeBuilder<Text> builder)
        {
            builder.ToTable("Text");
            builder.HasKey(x => x.Id)
                   .HasAnnotation("MySql:ValueGeneratedOnAdd", true);
        }
    }
}