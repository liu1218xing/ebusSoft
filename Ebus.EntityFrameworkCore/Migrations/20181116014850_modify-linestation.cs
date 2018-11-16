using Microsoft.EntityFrameworkCore.Migrations;

namespace Ebus.EntityFrameworkCore.Migrations
{
    public partial class modifylinestation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Province_ProvinceId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Line_City_CityId",
                table: "Line");

            migrationBuilder.DropForeignKey(
                name: "FK_LineStation_Line_LineId",
                table: "LineStation");

            migrationBuilder.DropForeignKey(
                name: "FK_LineStation_Stations_StationId",
                table: "LineStation");

            migrationBuilder.DropForeignKey(
                name: "FK_Stations_City_CityId",
                table: "Stations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Province",
                table: "Province");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LineStation",
                table: "LineStation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Line",
                table: "Line");

            migrationBuilder.DropIndex(
                name: "IX_Line_CityId",
                table: "Line");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Line");

            migrationBuilder.RenameTable(
                name: "Province",
                newName: "Provinces");

            migrationBuilder.RenameTable(
                name: "LineStation",
                newName: "LineStations");

            migrationBuilder.RenameTable(
                name: "Line",
                newName: "Lines");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_LineStation_StationId",
                table: "LineStations",
                newName: "IX_LineStations_StationId");

            migrationBuilder.RenameIndex(
                name: "IX_LineStation_LineId",
                table: "LineStations",
                newName: "IX_LineStations_LineId");

            migrationBuilder.RenameIndex(
                name: "IX_City_ProvinceId",
                table: "Cities",
                newName: "IX_Cities_ProvinceId");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Stations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndStation",
                table: "Lines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartStation",
                table: "Lines",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineStations",
                table: "LineStations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lines",
                table: "Lines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provinces_ProvinceId",
                table: "Cities",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LineStations_Lines_LineId",
                table: "LineStations",
                column: "LineId",
                principalTable: "Lines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LineStations_Stations_StationId",
                table: "LineStations",
                column: "StationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stations_Cities_CityId",
                table: "Stations",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provinces_ProvinceId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_LineStations_Lines_LineId",
                table: "LineStations");

            migrationBuilder.DropForeignKey(
                name: "FK_LineStations_Stations_StationId",
                table: "LineStations");

            migrationBuilder.DropForeignKey(
                name: "FK_Stations_Cities_CityId",
                table: "Stations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LineStations",
                table: "LineStations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lines",
                table: "Lines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "EndStation",
                table: "Lines");

            migrationBuilder.DropColumn(
                name: "StartStation",
                table: "Lines");

            migrationBuilder.RenameTable(
                name: "Provinces",
                newName: "Province");

            migrationBuilder.RenameTable(
                name: "LineStations",
                newName: "LineStation");

            migrationBuilder.RenameTable(
                name: "Lines",
                newName: "Line");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_LineStations_StationId",
                table: "LineStation",
                newName: "IX_LineStation_StationId");

            migrationBuilder.RenameIndex(
                name: "IX_LineStations_LineId",
                table: "LineStation",
                newName: "IX_LineStation_LineId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_ProvinceId",
                table: "City",
                newName: "IX_City_ProvinceId");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Stations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Line",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Province",
                table: "Province",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineStation",
                table: "LineStation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Line",
                table: "Line",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Line_CityId",
                table: "Line",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Province_ProvinceId",
                table: "City",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Line_City_CityId",
                table: "Line",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LineStation_Line_LineId",
                table: "LineStation",
                column: "LineId",
                principalTable: "Line",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LineStation_Stations_StationId",
                table: "LineStation",
                column: "StationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stations_City_CityId",
                table: "Stations",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
