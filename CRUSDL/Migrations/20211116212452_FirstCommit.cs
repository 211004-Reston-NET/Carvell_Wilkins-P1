using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUSDL.Migrations
{
    public partial class FirstCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    LineItem_ID = table.Column<int>(type: "int", nullable: false),
                    _quantity = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.LineItem_ID);
                });

            migrationBuilder.CreateTable(
                name: "StoreFront",
                columns: table => new
                {
                    StoreFront_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreFront", x => x.StoreFront_ID);
                });

            migrationBuilder.CreateTable(
                name: "TestTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    StoreFront_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK__Product__StoreFr__114A936A",
                        column: x => x.StoreFront_ID,
                        principalTable: "StoreFront",
                        principalColumn: "StoreFront_ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderPlacement",
                columns: table => new
                {
                    order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreFront_ID = table.Column<int>(type: "int", nullable: false),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderPla__464665E1B7D4693B", x => x.order_ID);
                    table.ForeignKey(
                        name: "FK__OrderPlac__Custo__10566F31",
                        column: x => x.Customer_ID,
                        principalTable: "Customer",
                        principalColumn: "Customer_ID");
                    table.ForeignKey(
                        name: "FK__OrderPlac__Produ__0F624AF8",
                        column: x => x.Product_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__OrderPlac__Store__0E6E26BF",
                        column: x => x.StoreFront_ID,
                        principalTable: "StoreFront",
                        principalColumn: "StoreFront_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlacement_Customer_ID",
                table: "OrderPlacement",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlacement_Product_ID",
                table: "OrderPlacement",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlacement_StoreFront_ID",
                table: "OrderPlacement",
                column: "StoreFront_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_StoreFront_ID",
                table: "Product",
                column: "StoreFront_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineItem");

            migrationBuilder.DropTable(
                name: "OrderPlacement");

            migrationBuilder.DropTable(
                name: "TestTables");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "StoreFront");
        }
    }
}
