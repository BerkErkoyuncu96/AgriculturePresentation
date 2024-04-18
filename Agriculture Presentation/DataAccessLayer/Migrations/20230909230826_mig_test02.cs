using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_test02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrition4",
                table: "Adresses",
                newName: "Description4");

            migrationBuilder.RenameColumn(
                name: "Descrition3",
                table: "Adresses",
                newName: "Description3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description4",
                table: "Adresses",
                newName: "Descrition4");

            migrationBuilder.RenameColumn(
                name: "Description3",
                table: "Adresses",
                newName: "Descrition3");
        }
    }
}
