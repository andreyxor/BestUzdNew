using BestUzdNew.Domain.Constants;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestUzdNew.DataAccess.Migrations
{
    public partial class FillUsersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                INSERT INTO UserRole(NameAlias)
                VALUES ('{UserRoleAliases.AdminRoleAlias}')

                INSERT INTO UserRole(NameAlias)
                VALUES ('{UserRoleAliases.BasicRoleAlias}')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
