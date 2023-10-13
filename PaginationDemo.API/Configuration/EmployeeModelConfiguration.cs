using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaginationDemo.API.Model;

namespace PaginationDemo.API.Configuration
{
    public class EmployeeModelConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employee_pagination");
            builder.HasKey(e => e.EmployeeId);

            builder
                .Property(e => e.EmployeeId)
                .HasColumnName("employee_id")
                .HasColumnType("Bigint")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
               .Property(e => e.EmployeeName)
               .HasColumnName("employee_name")
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder
               .Property(e => e.EmployeeAge)
               .HasColumnName("employee_age")
               .HasColumnType("Bigint")
               .IsRequired();
        }
    }
}
