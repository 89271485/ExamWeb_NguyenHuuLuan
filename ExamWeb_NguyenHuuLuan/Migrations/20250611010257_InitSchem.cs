﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_PhamHuynhAnh.Migrations
{
    public partial class InitSchem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaDe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DienVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaVe = table.Column<double>(type: "float", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phims");
        }
    }
}
