using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Infrastrcture.Migrations
{
    /// <inheritdoc />
    public partial class intial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "City",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_CountryId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "City");
        }
    }
}
