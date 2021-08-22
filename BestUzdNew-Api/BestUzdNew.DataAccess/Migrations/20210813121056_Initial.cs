using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestUzdNew.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameAlias = table.Column<string>(maxLength: 100, nullable: false),
                    DescriptionAlias = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    ShortName = table.Column<string>(maxLength: 6, nullable: false),
                    ImageSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    StartTime = table.Column<DateTime>(type: "date", nullable: true),
                    EndTime = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameAlias = table.Column<string>(maxLength: 100, nullable: false),
                    DescriptionAlias = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameAlias = table.Column<string>(maxLength: 100, nullable: false),
                    DescriptionAlias = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    FamilyName = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameAlias = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Alias = table.Column<string>(maxLength: 100, nullable: false),
                    Translation = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translation", x => x.Id);
                    table.ForeignKey(
                        name: "Translation_LanguageFK",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    FamilyName = table.Column<string>(maxLength: 100, nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "Order_ServiceFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceGroupToService",
                columns: table => new
                {
                    ServiceGroupId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceGroupToService", x => new { x.ServiceId, x.ServiceGroupId });
                    table.ForeignKey(
                        name: "ServiceGroupToService_ServiceGroupFK",
                        column: x => x.ServiceGroupId,
                        principalTable: "ServiceGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceGroupToService_ServiceFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Login = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    UserInformationId = table.Column<int>(nullable: false),
                    UserRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "User_UserInformationFK",
                        column: x => x.UserInformationId,
                        principalTable: "UserInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserRole",
                        column: x => x.UserRoleId,
                        principalTable: "UserRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameAlias = table.Column<string>(maxLength: 100, nullable: false),
                    DescriptionAlias = table.Column<string>(nullable: false),
                    ServiceId = table.Column<int>(nullable: true),
                    DiscountTypeId = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "ServiceDiscount_DiscountTypeFK",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceDiscount_ServiceFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceDiscount_UserFK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceGroupDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameAlias = table.Column<string>(maxLength: 100, nullable: false),
                    DescriptionAlias = table.Column<string>(nullable: false),
                    ServiceGroupId = table.Column<int>(nullable: true),
                    DiscountTypeId = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceGroupDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "ServiceGroupDiscount_DiscountTypeFK",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceGroupDiscount_ServiceGroupFK",
                        column: x => x.ServiceGroupId,
                        principalTable: "ServiceGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceGroupDiscount_UserFK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSetDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DiscountTypeId = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSetDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "ServiceSetDiscount_DiscountTypeFK",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceSetDiscount_UserFK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSetDiscountToService",
                columns: table => new
                {
                    ServiceSetDiscountId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSetDiscountToService", x => new { x.ServiceSetDiscountId, x.ServiceId });
                    table.ForeignKey(
                        name: "ServiceSetDiscountToService_ServiceFK",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ServiceSetDiscountToService_ServiceSetDiscountFK",
                        column: x => x.ServiceSetDiscountId,
                        principalTable: "ServiceSetDiscount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_IsDeleted",
                table: "DiscountType",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Language_IsDeleted",
                table: "Language",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IsDeleted",
                table: "Order",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ServiceId",
                table: "Order",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_IsDeleted",
                table: "Schedule",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Service_IsDeleted",
                table: "Service",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDiscount_DiscountTypeId",
                table: "ServiceDiscount",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDiscount_IsDeleted",
                table: "ServiceDiscount",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDiscount_ServiceId",
                table: "ServiceDiscount",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDiscount_UserId",
                table: "ServiceDiscount",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroup_IsDeleted",
                table: "ServiceGroup",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupDiscount_DiscountTypeId",
                table: "ServiceGroupDiscount",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupDiscount_IsDeleted",
                table: "ServiceGroupDiscount",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupDiscount_ServiceGroupId",
                table: "ServiceGroupDiscount",
                column: "ServiceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupDiscount_UserId",
                table: "ServiceGroupDiscount",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupToService_IsDeleted",
                table: "ServiceGroupToService",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupToService_ServiceGroupId",
                table: "ServiceGroupToService",
                column: "ServiceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceGroupToService_ServiceId",
                table: "ServiceGroupToService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscount_DiscountTypeId",
                table: "ServiceSetDiscount",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscount_IsDeleted",
                table: "ServiceSetDiscount",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscount_UserId",
                table: "ServiceSetDiscount",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscountToService_IsDeleted",
                table: "ServiceSetDiscountToService",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscountToService_ServiceId",
                table: "ServiceSetDiscountToService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSetDiscountToService_ServiceSetDiscountId",
                table: "ServiceSetDiscountToService",
                column: "ServiceSetDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_IsDeleted",
                table: "Translation",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_LanguageId",
                table: "Translation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_User_IsDeleted",
                table: "User",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserInformationId",
                table: "User",
                column: "UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRoleId",
                table: "User",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_IsDeleted",
                table: "UserInformation",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_IsDeleted",
                table: "UserRole",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "ServiceDiscount");

            migrationBuilder.DropTable(
                name: "ServiceGroupDiscount");

            migrationBuilder.DropTable(
                name: "ServiceGroupToService");

            migrationBuilder.DropTable(
                name: "ServiceSetDiscountToService");

            migrationBuilder.DropTable(
                name: "Translation");

            migrationBuilder.DropTable(
                name: "ServiceGroup");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ServiceSetDiscount");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserInformation");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
