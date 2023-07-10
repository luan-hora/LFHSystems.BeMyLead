using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LFHSystems.BeMyLead.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_Leads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observations",
                table: "Tb_Lead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observations",
                table: "Tb_Lead");
        }
    }
}
