using BestUzdNew.Domain.Constants;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestUzdNew.DataAccess.Migrations
{
    public partial class FillDiscountTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                INSERT INTO DicountType(NameAlias, DescriptionAlias)
                VALUES (N'{DefaultDiscountTypes.Percent.NameAlias}', N'{DefaultDiscountTypes.Percent.DescriptionAlias}')

                INSERT INTO DicountType(NameAlias, DescriptionAlias)
                VALUES (N'{DefaultDiscountTypes.Value.NameAlias}', N'{DefaultDiscountTypes.Value.DescriptionAlias}')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
