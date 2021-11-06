using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUSDL.Migrations
{
    public partial class AddedDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StoreFront",
                columns: table => new
                {
                    StoreFront_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    List_of_Products = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    List_of_Orders = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreFront", x => x.StoreFront_ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    StoreFront_ID = table.Column<int>(type: "int", nullable: false),
                    LineItem_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK__Product__StoreFr__114A936A",
                        column: x => x.StoreFront_ID,
                        principalTable: "StoreFront",
                        principalColumn: "StoreFront_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPlacement",
                columns: table => new
                {
                    order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreFront_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    orderPlacementOrderId = table.Column<int>(type: "int", nullable: true),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Total_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderPla__464665E1B7D4693B", x => x.order_ID);
                    table.ForeignKey(
                        name: "FK_OrderPlacement_Customer_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPlacement_OrderPlacement_orderPlacementOrderId",
                        column: x => x.orderPlacementOrderId,
                        principalTable: "OrderPlacement",
                        principalColumn: "order_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderPlacement_Product_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPlacement_StoreFront_StoreFront_ID",
                        column: x => x.StoreFront_ID,
                        principalTable: "StoreFront",
                        principalColumn: "StoreFront_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    LineItem_ID = table.Column<int>(type: "int", nullable: false),
                    _quantity = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderPlacement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Order_ID = table.Column<int>(type: "int", nullable: false),
                    OrderPlacementOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.LineItem_ID);
                    table.ForeignKey(
                        name: "FK_LineItem_OrderPlacement_OrderPlacementOrderId",
                        column: x => x.OrderPlacementOrderId,
                        principalTable: "OrderPlacement",
                        principalColumn: "order_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LineItem_Product_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_OrderPlacementOrderId",
                table: "LineItem",
                column: "OrderPlacementOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_Product_ID",
                table: "LineItem",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlacement_Customer_ID",
                table: "OrderPlacement",
                column: "Customer_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlacement_orderPlacementOrderId",
                table: "OrderPlacement",
                column: "orderPlacementOrderId");

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
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "StoreFront");
        }
    }
}
