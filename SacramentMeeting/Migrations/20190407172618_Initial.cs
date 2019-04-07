﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeeting.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    Conducting = table.Column<string>(nullable: true),
                    Presiding = table.Column<string>(nullable: true),
                    Invocation = table.Column<string>(nullable: true),
                    Benediction = table.Column<string>(nullable: true),
                    OpeningHymn = table.Column<int>(nullable: false),
                    SacramentHymn = table.Column<int>(nullable: false),
                    ClosingHymn = table.Column<int>(nullable: false),
                    Speaker1 = table.Column<string>(nullable: true),
                    Topic1 = table.Column<string>(nullable: true),
                    Speaker2 = table.Column<string>(nullable: true),
                    Topic2 = table.Column<string>(nullable: true),
                    Speaker3 = table.Column<string>(nullable: true),
                    Topic3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
