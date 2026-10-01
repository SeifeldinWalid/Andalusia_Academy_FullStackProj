using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Full_Stack_Grad_Project.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HomepageContents",
                keyColumn: "Id",
                keyValue: 1,
                column: "HeroImageUrl",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HomepageContents",
                keyColumn: "Id",
                keyValue: 1,
                column: "HeroImageUrl",
                value: null);
        }
    }
}
