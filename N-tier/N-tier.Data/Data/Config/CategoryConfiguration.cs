using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N_tier.Models;


namespace N_tier.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    { 
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x=>x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.DisplayOrder);

            builder.HasData(GetCategories());
        } 

        private static List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category(){ID=1,Name="Action"},
                new Category(){ID=2,Name="Drama"},
                new Category(){ID=3,Name="Romantic"}
            };
        }
    }
}
