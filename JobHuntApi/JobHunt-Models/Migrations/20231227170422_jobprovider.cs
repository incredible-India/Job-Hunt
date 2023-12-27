using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobHunt_Models.Migrations
{
    /// <inheritdoc />
    public partial class jobprovider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otherExpertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: true),
                    addressId = table.Column<int>(type: "int", nullable: true),
                    media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ratings = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobProviders_address_addressId",
                        column: x => x.addressId,
                        principalTable: "address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobProviders_addressId",
                table: "JobProviders",
                column: "addressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobProviders");
        }
    }
}
