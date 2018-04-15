using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QAManagement.Migrations
{
    public partial class Addintitalentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QACardId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QAHomeId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "QABranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    GoogleUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    Telephone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QABranch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QACard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Qty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QACard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QAAssets",
                columns: table => new
                {
                    Author = table.Column<string>(nullable: true),
                    DataLoc = table.Column<string>(nullable: true),
                    QATCI = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DbName = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    LocUrl = table.Column<string>(nullable: true),
                    NumberOfDataSets = table.Column<int>(nullable: false),
                    QABranchId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    TcId = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QAAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QAAssets_QAAssets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "QAAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QAAssets_QABranch_QABranchId",
                        column: x => x.QABranchId,
                        principalTable: "QABranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<int>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    QACardId = table.Column<int>(nullable: true),
                    RecentUse = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkout_QAAssets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "QAAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkout_QACard_QACardId",
                        column: x => x.QACardId,
                        principalTable: "QACard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckoutHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<int>(nullable: false),
                    InUse = table.Column<DateTime>(nullable: true),
                    NoUse = table.Column<DateTime>(nullable: false),
                    QACardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_QAAssets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "QAAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_QACard_QACardId",
                        column: x => x.QACardId,
                        principalTable: "QACard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hold",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<int>(nullable: true),
                    HoldPlaced = table.Column<DateTime>(nullable: false),
                    QACardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hold", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hold_QAAssets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "QAAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hold_QACard_QACardId",
                        column: x => x.QACardId,
                        principalTable: "QACard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_QACardId",
                table: "Patrons",
                column: "QACardId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_QAHomeId",
                table: "Patrons",
                column: "QAHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_AssetId",
                table: "Checkout",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_QACardId",
                table: "Checkout",
                column: "QACardId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_AssetId",
                table: "CheckoutHistories",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_QACardId",
                table: "CheckoutHistories",
                column: "QACardId");

            migrationBuilder.CreateIndex(
                name: "IX_Hold_AssetId",
                table: "Hold",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Hold_QACardId",
                table: "Hold",
                column: "QACardId");

            migrationBuilder.CreateIndex(
                name: "IX_QAAssets_AssetId",
                table: "QAAssets",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_QAAssets_QABranchId",
                table: "QAAssets",
                column: "QABranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_QACard_QACardId",
                table: "Patrons",
                column: "QACardId",
                principalTable: "QACard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_QABranch_QAHomeId",
                table: "Patrons",
                column: "QAHomeId",
                principalTable: "QABranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_QACard_QACardId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_QABranch_QAHomeId",
                table: "Patrons");

            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "CheckoutHistories");

            migrationBuilder.DropTable(
                name: "Hold");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "QAAssets");

            migrationBuilder.DropTable(
                name: "QACard");

            migrationBuilder.DropTable(
                name: "QABranch");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_QACardId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_QAHomeId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "QACardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "QAHomeId",
                table: "Patrons");
        }
    }
}
