using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Greta.BO.Api.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    Description = table.Column<string>(type: "varchar(254)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(64)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(64)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScaleBrand",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScaleCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScaleLabelType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleLabelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(64)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(64)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TenderType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(64)", nullable: false),
                    OpenDrawer = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DisplayAs = table.Column<string>(type: "varchar(64)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenderType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Contact = table.Column<string>(type: "varchar(30)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(14)", nullable: true),
                    Email = table.Column<string>(type: "varchar(60)", nullable: true),
                    Note = table.Column<string>(type: "varchar(254)", nullable: true),
                    MinimalOrder = table.Column<decimal>(type: "numeric(15,3)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "varchar(20)", nullable: true),
                    Province = table.Column<string>(type: "varchar(2)", nullable: true),
                    Country = table.Column<string>(type: "varchar(30)", nullable: true),
                    Zip = table.Column<string>(type: "varchar(12)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountFamily",
                columns: table => new
                {
                    DiscountsId = table.Column<long>(type: "bigint", nullable: false),
                    FamiliesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountFamily", x => new { x.DiscountsId, x.FamiliesId });
                    table.ForeignKey(
                        name: "FK_DiscountFamily_Discount_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountFamily_Family_FamiliesId",
                        column: x => x.FamiliesId,
                        principalTable: "Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UPC = table.Column<string>(type: "varchar(254)", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", nullable: false),
                    Description = table.Column<string>(type: "varchar(254)", nullable: true),
                    StoreProductId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    FamilyId = table.Column<long>(type: "bigint", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    MinimumAge = table.Column<int>(type: "int", nullable: false),
                    PosVisible = table.Column<bool>(type: "bit", nullable: false),
                    ScaleVisible = table.Column<bool>(type: "bit", nullable: false),
                    AllowZeroStock = table.Column<bool>(type: "bit", nullable: false),
                    QtyHand = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    OrderTrigger = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    OrderAmount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    PLUNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ScaleCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    PLUType = table.Column<int>(type: "int", nullable: true),
                    Description1 = table.Column<string>(type: "varchar(40)", nullable: true),
                    Description2 = table.Column<string>(type: "varchar(40)", nullable: true),
                    Description3 = table.Column<string>(type: "varchar(40)", nullable: true),
                    Text1 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Text2 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Text3 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Text4 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Tare1 = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Tare2 = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ForceTare = table.Column<bool>(type: "bit", nullable: true),
                    TareIsPercent = table.Column<bool>(type: "bit", nullable: true),
                    ScaleLabelType1Id = table.Column<long>(type: "bigint", nullable: true),
                    ScaleLabelType2Id = table.Column<long>(type: "bigint", nullable: true),
                    ScaleLabelType3Id = table.Column<long>(type: "bigint", nullable: true),
                    ScaleLabelType4Id = table.Column<long>(type: "bigint", nullable: true),
                    ServingPerContainer = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ServingSize = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    AmountPerServingCalories = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TotalFatGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TotalFat = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SaturedFatGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SaturedFat = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CholesterolMGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Cholesterol = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SodiumMGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Sodium = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TotalCarbohydrateGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TotalCarbohydrate = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DietaryFiberGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DietaryFiber = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TotalSugarGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    AddedSugarGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    AddedSugar = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ProteinGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    VitDMGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    VitD = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CalciumMGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Calcium = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    IronMGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Iron = table.Column<double>(type: "float", nullable: true),
                    PotasMGrams = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Potas = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ScaleCategory_ScaleCategoryId",
                        column: x => x.ScaleCategoryId,
                        principalTable: "ScaleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ScaleLabelType_ScaleLabelType1Id",
                        column: x => x.ScaleLabelType1Id,
                        principalTable: "ScaleLabelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_ScaleLabelType_ScaleLabelType2Id",
                        column: x => x.ScaleLabelType2Id,
                        principalTable: "ScaleLabelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_ScaleLabelType_ScaleLabelType3Id",
                        column: x => x.ScaleLabelType3Id,
                        principalTable: "ScaleLabelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_ScaleLabelType_ScaleLabelType4Id",
                        column: x => x.ScaleLabelType4Id,
                        principalTable: "ScaleLabelType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExternalScale",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ip = table.Column<string>(type: "varchar(64)", nullable: false),
                    Port = table.Column<string>(type: "varchar(64)", nullable: false),
                    ScaleBrandId = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalScale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalScale_ScaleBrand_ScaleBrandId",
                        column: x => x.ScaleBrandId,
                        principalTable: "ScaleBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExternalScale_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitProductProduct",
                columns: table => new
                {
                    KitProductId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitProductProduct", x => new { x.ProductId, x.KitProductId });
                    table.ForeignKey(
                        name: "FK_KitProductProduct_Product_KitProductId",
                        column: x => x.KitProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KitProductProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreProduct",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    GrossProfit = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProduct_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VendorProduct",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    VendorId = table.Column<long>(type: "bigint", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PackQty = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Price = table.Column<double>(type: "float", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatorId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendorProduct_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountStoreProduct",
                columns: table => new
                {
                    DiscountsId = table.Column<long>(type: "bigint", nullable: false),
                    StoreProductsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountStoreProduct", x => new { x.DiscountsId, x.StoreProductsId });
                    table.ForeignKey(
                        name: "FK_DiscountStoreProduct_Discount_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountStoreProduct_StoreProduct_StoreProductsId",
                        column: x => x.StoreProductsId,
                        principalTable: "StoreProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreProductTax",
                columns: table => new
                {
                    StoreProductsId = table.Column<long>(type: "bigint", nullable: false),
                    TaxsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProductTax", x => new { x.StoreProductsId, x.TaxsId });
                    table.ForeignKey(
                        name: "FK_StoreProductTax_StoreProduct_StoreProductsId",
                        column: x => x.StoreProductsId,
                        principalTable: "StoreProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreProductTax_Tax_TaxsId",
                        column: x => x.TaxsId,
                        principalTable: "Tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "State", "UpdatedAt", "UserCreatorId" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description0", "Category 0", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "94e03fea-6f03-4d5c-a546-beb291379576" },
                    { 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description72", "Category 72", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8940ed26-acb2-4b9c-adef-fcd839f0995c" },
                    { 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description71", "Category 71", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "babcfcb6-f304-4b3c-87fc-9a4b579b36d2" },
                    { 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description70", "Category 70", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fe2d2ba1-6fde-4c83-9852-e12d4b70e02c" },
                    { 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description69", "Category 69", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c6f2cbb7-2ce4-4fcc-921f-7eb165f6e0eb" },
                    { 69L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description68", "Category 68", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "559735ae-d805-46bf-9861-598f22aa3b8d" },
                    { 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description67", "Category 67", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2288e6ed-1f11-43e0-af30-94fdea4265a7" },
                    { 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description66", "Category 66", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "358fdf57-3207-4019-a3ef-45d5c1b22576" },
                    { 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description65", "Category 65", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f6e3fd71-435c-4a8c-a494-c90c3e1cddf2" },
                    { 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description64", "Category 64", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "93d39099-cdf3-48c3-8396-9d5ffbcc1805" },
                    { 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description63", "Category 63", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "43b35712-b3ec-4f9c-90da-fc45580287ed" },
                    { 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description62", "Category 62", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c991a034-1c5f-4184-8a4f-d5dacd30b55a" },
                    { 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description61", "Category 61", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1b40cb2b-79c7-42c4-a7f3-3f8540e69b68" },
                    { 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description60", "Category 60", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6402d202-f530-4219-880b-2cc7dd81843a" },
                    { 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description59", "Category 59", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "410c8a29-5e17-4f89-97b5-9f5f338dc470" },
                    { 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description58", "Category 58", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d58a7c84-cc9b-416f-970a-fd406dbab932" },
                    { 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description57", "Category 57", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "239854fb-9984-4dbc-b219-af2dda86133b" },
                    { 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description56", "Category 56", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c0f744e3-f296-4212-bac7-42f11e11ae6c" },
                    { 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description55", "Category 55", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0fb4c329-e272-46bc-a3e0-470906e372bf" },
                    { 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description54", "Category 54", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "db22a2e9-a36d-4345-bd5d-dddd535b0907" },
                    { 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description53", "Category 53", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0fe0da04-5255-49c5-81ef-4f0a572bcf07" },
                    { 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description52", "Category 52", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9dad17ad-a5d1-4446-a452-02d306f0115a" },
                    { 74L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description73", "Category 73", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "abf6aea9-6070-4538-9a50-5dbbecb6b70a" },
                    { 76L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description75", "Category 75", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "40af2fa3-784e-4c81-84f6-8c14f9b2d0ba" },
                    { 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description76", "Category 76", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f160fbde-d96f-4a56-9559-28aa668e43c8" },
                    { 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description77", "Category 77", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8dbf4c61-0657-4b14-98c5-6f626cf7b5e6" },
                    { 100L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description99", "Category 99", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "677e40b6-9227-4103-9e75-5886a31756f0" },
                    { 99L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description98", "Category 98", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e2fdecc-35f2-4222-a3d1-1899701d648e" },
                    { 98L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description97", "Category 97", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8f31585-ff63-4949-96da-710d3fb9a465" },
                    { 97L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description96", "Category 96", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "26f3edc0-2fee-4eca-bb7b-3fdea6cd2e73" },
                    { 96L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description95", "Category 95", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5ad259a3-f173-4d12-a535-0ef0958ddf1b" },
                    { 95L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description94", "Category 94", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01628884-e577-4788-9e33-a9c8baa580fa" },
                    { 94L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description93", "Category 93", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bcca7c08-15d3-49a2-b519-afb2ce9dd533" },
                    { 93L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description92", "Category 92", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aa2adb05-8337-44f7-aec1-ec01a2156c59" },
                    { 92L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description91", "Category 91", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16ff5223-7657-46b9-8e71-aa33ae2056b9" },
                    { 91L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description90", "Category 90", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "af663b19-8b4a-4dfc-9e03-deb9292a48a4" },
                    { 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description51", "Category 51", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "47483705-7c8e-4f7f-98e7-7b487adcc513" },
                    { 90L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description89", "Category 89", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b80b133f-4674-4ebb-b710-0a00af81b92a" },
                    { 88L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description87", "Category 87", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c85ca5a-c14f-496a-afa9-9f97fcd2cdc6" },
                    { 87L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description86", "Category 86", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3e900c06-e62f-4818-ab5a-0cdcd3ad32ad" },
                    { 86L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description85", "Category 85", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9798c927-df62-4912-a9bc-44353231a992" },
                    { 85L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description84", "Category 84", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c4abb0f7-2c85-4aae-b7c5-e74644198345" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "State", "UpdatedAt", "UserCreatorId" },
                values: new object[,]
                {
                    { 84L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description83", "Category 83", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b5c4ae83-d0ee-4666-9d4d-ac415498a98c" },
                    { 83L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description82", "Category 82", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c82bf64f-2107-4d01-85ac-18428e7b9733" },
                    { 82L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description81", "Category 81", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f201f0c2-14c1-4b78-b9f7-9e8ada5c0e6a" },
                    { 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description80", "Category 80", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e43d9a6-92ca-4011-b6ac-6622e4cf7a8d" },
                    { 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description79", "Category 79", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2f7cd07c-f624-4b56-939d-0063c2c3416f" },
                    { 79L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description78", "Category 78", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "df2a65e3-d750-4e09-b749-4b3479f6e02f" },
                    { 89L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description88", "Category 88", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fd336210-41cc-49b4-966b-35c000c5be24" },
                    { 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description50", "Category 50", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "44a75588-6c92-4c62-b93e-335be62c1040" },
                    { 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description74", "Category 74", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa8d5a1c-b4fc-4a8e-899a-43cb99423ad4" },
                    { 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description48", "Category 48", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "46f52aea-2ad0-496c-b9c4-e86a6b147061" },
                    { 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description22", "Category 22", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d53bb77a-21a7-421d-8652-4623afd71d51" },
                    { 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description21", "Category 21", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3c60f4d9-3923-47a4-a81c-dac2c93666bc" },
                    { 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description20", "Category 20", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d1a96525-3cce-49bf-929d-dcd9dbca8693" },
                    { 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description19", "Category 19", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c2f1e11c-7cc1-4329-9192-e5a859a834dc" },
                    { 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description18", "Category 18", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "df9879ed-a099-4c27-b71d-ceed7d5964ff" },
                    { 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description17", "Category 17", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "464483e1-fd42-472b-a8cc-62aceb056aa9" },
                    { 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description16", "Category 16", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6e57ab77-bf26-47e8-81c2-153ef9f82cdb" },
                    { 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description15", "Category 15", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a3bd5794-2286-4491-b67f-492a257d2b42" },
                    { 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description14", "Category 14", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cff55d3f-0407-4c46-8c82-8df76d5b9605" },
                    { 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description12", "Category 12", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d878772f-1953-4b00-a128-cf51afa06996" },
                    { 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description23", "Category 23", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1f9fbfcb-eab9-4f73-b11d-f82f30e3981d" },
                    { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description11", "Category 11", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d4ac740a-4147-46a2-a1c3-30c9ef9b0409" },
                    { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description9", "Category 9", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9cfa55b2-6c6b-4508-9eab-7497977a2a46" },
                    { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description8", "Category 8", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5462ced1-ddb9-4dd0-b62c-c4a663e9ba2a" },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description7", "Category 7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9792dde8-8c1f-416e-bc18-0097b35d6b13" },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description6", "Category 6", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "663e5598-c505-463c-84b0-3c8f455a2143" },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description5", "Category 5", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f2b5735d-9505-44ad-8629-a4144fba2af6" },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description4", "Category 4", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "de24da96-4858-467f-a930-ba83a2fd7c8f" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description3", "Category 3", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ad448508-cdec-44b5-89f8-eece303786ab" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description2", "Category 2", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b6ff64fe-5292-4df8-b296-7c25c52b7ce3" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description1", "Category 1", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d62103d9-ce6e-40ae-9680-85b6e15e4332" },
                    { 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description49", "Category 49", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc8aea87-c1c6-4cb8-8963-9283f1dcddfc" },
                    { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description10", "Category 10", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7cef9cc9-e452-470f-8812-3ea4f6950c8e" },
                    { 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description24", "Category 24", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b5881f7b-67ab-4a4b-b7e9-c9548da2aa3a" },
                    { 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description13", "Category 13", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c76d839-6195-4c94-847f-084c139040ac" },
                    { 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description47", "Category 47", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7237747a-be22-4a7c-89e5-bdebe5f09230" },
                    { 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description25", "Category 25", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5dcf92fe-bfbd-4273-a804-ccda99ed1b4d" },
                    { 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description46", "Category 46", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "345531b8-1661-4973-b273-5100eac97f9f" },
                    { 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description45", "Category 45", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f0cff5d1-7e19-412d-a188-e7dd7742f630" },
                    { 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description44", "Category 44", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2d47ea32-b7a3-4eef-9223-899ed346694b" },
                    { 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description43", "Category 43", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a1b08579-7a26-4297-a9ef-e5d69a56c4f3" },
                    { 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description42", "Category 42", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ec0d9c5b-777b-4c0f-a700-79c1fb30e692" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "State", "UpdatedAt", "UserCreatorId" },
                values: new object[,]
                {
                    { 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description41", "Category 41", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c800649-b4df-4f5a-8861-f8e6726a5958" },
                    { 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description39", "Category 39", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f306da42-c280-4fe4-989e-0736fab889be" },
                    { 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description38", "Category 38", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "914eebc1-6941-41bc-8498-e937d0d4ae2b" },
                    { 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description37", "Category 37", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "efbdc7dd-f9e9-4de9-8577-c8435d59921f" },
                    { 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description36", "Category 36", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1032327c-c945-4881-829d-f19f312d85be" },
                    { 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description40", "Category 40", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c9dbd596-eee3-4eeb-aa34-f5efe25a59f8" },
                    { 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description26", "Category 26", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "106e26fe-9a1b-4279-bdbd-d67c24a43088" },
                    { 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description34", "Category 34", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d447bbc6-6750-4b92-8d8a-1ab5bcb57eea" },
                    { 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description33", "Category 33", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "db781e3b-3a38-472c-ae9c-73d6c8d1c72b" },
                    { 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description32", "Category 32", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fd62afc7-9275-4768-ba3a-a3e578bac3be" },
                    { 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description31", "Category 31", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "30698d60-bedd-4920-a826-4c922dbe9d24" },
                    { 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description30", "Category 30", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "26cca7e3-1c16-4e07-a50a-8a8ec830f275" },
                    { 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description29", "Category 29", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6dd50f48-9b8e-4fab-8948-764c4edccdda" },
                    { 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description28", "Category 28", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "54a7c75d-6d2b-4cdc-88e0-f69c2ed48b9f" },
                    { 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description27", "Category 27", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c06768c9-8e84-422f-b457-81dad4c8948d" },
                    { 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description35", "Category 35", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5f47dd4c-fe4c-46ca-9028-f7ef7c732d10" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "Id", "CreatedAt", "Name", "State", "UpdatedAt", "UserCreatorId" },
                values: new object[,]
                {
                    { 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 65", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "69bbbd80-3da9-4354-b4c8-2b78121c0bfe" },
                    { 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 66", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f78f2335-ba3a-47c2-a30c-f286d55f458a" },
                    { 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 67", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adc9a975-976b-4c68-a8d0-7f13f91d2ceb" },
                    { 69L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 68", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ce40f67-222c-4d14-822b-0e9ab71bb49a" },
                    { 74L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 73", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f0e28c8-e1a2-4caa-a091-8368b6e23639" },
                    { 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 70", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d1452c3c-ea17-4e90-a6fc-170e1e11b5da" },
                    { 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 71", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7aac0898-e950-48c2-b6bd-7d7177db9990" },
                    { 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 72", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e4f7f22-f99a-466c-a605-123427b151d4" },
                    { 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 64", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1df0af79-aff4-4a6d-a8fc-bf31c59852c1" },
                    { 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 69", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "98b6d5b2-3e12-46db-8849-6a325b1e5e15" },
                    { 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 63", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3fd164f8-e580-4a2d-a664-9aa285d94e5f" },
                    { 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 52", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd1887ae-c87d-47bc-ac23-f0c44d5fe930" },
                    { 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 61", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ac92bfe4-30ae-44e3-a2bb-0eb81b4d5205" },
                    { 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 60", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bfebeef2-9a7b-4fdd-b639-056bcfa77521" },
                    { 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 59", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "827d4400-0e47-4fb5-ae70-86b0539caf7c" },
                    { 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 58", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42148e0b-6a94-4c09-a762-c6690ba08bdc" },
                    { 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 57", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b48e3fa6-13d0-4e79-8c5c-b46d49cfe019" },
                    { 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 56", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "27c348e1-512b-4548-a93c-2c5cb000bf5a" },
                    { 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 55", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3816860d-eb84-4ca7-ae91-430f92e5210c" },
                    { 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 54", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "40b6860e-72b5-4a3d-abcc-ceee302d5e62" },
                    { 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 53", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d6692d0c-b93d-4136-bece-a6d0ff0684e6" },
                    { 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 74", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "79c15394-cebc-444a-b882-ba969a0aedaa" },
                    { 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 62", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a1251cf3-ea40-458a-8719-9384942d7801" },
                    { 76L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 75", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dededae5-45fe-4ba9-ad1d-fed30bcfa57d" },
                    { 100L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 99", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a478837-145d-4ecd-9295-83feefa1e05b" },
                    { 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 77", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "af67f33b-8a74-411e-8acf-be0718df3215" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "Id", "CreatedAt", "Name", "State", "UpdatedAt", "UserCreatorId" },
                values: new object[,]
                {
                    { 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 51", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "31938ce3-1baf-4c7a-b701-79065d67eb04" },
                    { 99L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 98", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f8645bbc-4ac2-40dd-87fe-2d4bad4b1794" },
                    { 98L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 97", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "215603c6-ae43-45ce-943b-6d0c1ab39dd3" },
                    { 97L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 96", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a0e30c7d-253a-49f8-85bf-573d6d6fab55" },
                    { 96L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 95", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "82d28c51-9d12-4013-8e69-3e6f92c59386" },
                    { 95L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 94", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "098d05ee-852f-446b-9481-fe7e5b7528ef" },
                    { 94L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 93", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ef68e906-9dba-4edb-9059-4c8613365f85" },
                    { 93L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 92", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f0fde21-9d0f-4f99-9b03-061927960c76" },
                    { 92L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 91", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "772dd4e3-04d7-4135-991a-8b51ed44d25e" },
                    { 91L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 90", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "09622de9-6229-4ad7-a7c8-a04fbb7b702c" },
                    { 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 76", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a70c48ef-9961-4672-b1e3-5de2de2d8ef1" },
                    { 90L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 89", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15a44332-774b-4c11-aea1-efea39415a41" },
                    { 88L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 87", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9b3f00e0-692e-4f65-b7d3-79b4beced17f" },
                    { 87L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 86", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa408f7e-b5e4-474b-adf5-4d3cedd7d7b6" },
                    { 86L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 85", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "77be6b06-551f-4063-bdfc-6694eb40265f" },
                    { 85L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 84", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a19107f7-2f0e-4b0d-baaa-23d309a374ee" },
                    { 84L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 83", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3949308d-fa95-4589-af94-cf52efd0e07a" },
                    { 83L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 82", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "960f4698-908a-43b0-be40-e7ae5dfb57f1" },
                    { 82L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 81", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b8eb17d0-338e-4bbe-a0ed-10cd8d370a3e" },
                    { 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 80", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "82882b45-84a4-414e-baab-412c0e07f477" },
                    { 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 79", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "23ed26aa-0bb1-4fa8-b3ad-48f2e8ad2cb4" },
                    { 79L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 78", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6ff1a49e-8d7e-46c8-8058-0eb26bd0032d" },
                    { 89L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 88", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d7de0f3-6a4a-47c4-927d-5d832e360f01" },
                    { 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 50", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facd38c4-46da-40a4-9cad-443c1d469724" },
                    { 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 49", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ec0a3d7f-9c64-4020-8471-92071dc15a37" },
                    { 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 48", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4e2429b1-98c7-44b2-ba55-05f782ad98ba" },
                    { 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 21", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aa975576-e58e-4709-a983-8e289b9addba" },
                    { 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 20", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0794ea5e-b440-4463-9e08-132a4ffe03cd" },
                    { 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 19", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2572f201-9207-47e1-834e-8af6ede6583d" },
                    { 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 18", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "824107cc-f73e-47c4-ace4-ee2e2e892bff" },
                    { 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 17", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d66dd12e-57a9-41a2-9d0e-bc7195afdd5b" },
                    { 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 16", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "094cd3a2-c93d-442a-8140-68e4279d7bac" },
                    { 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 15", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b6f13cb-6243-469b-8ae3-5889a8baec2c" },
                    { 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 14", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a3857894-6547-4a96-8af3-60f0ed9f2f35" },
                    { 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 13", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "97fd653d-7af1-4fc9-a3c0-8e720d06b905" },
                    { 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 12", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5fbefdaa-0d3d-46e4-86e9-f0808a9c4beb" },
                    { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 11", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2b8bc341-de29-41b5-9c8f-8cac36b2aef5" },
                    { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 10", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f1b863e2-b365-4968-bfe7-27b51f5ee9a0" },
                    { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 9", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2f97ef69-5abd-43c3-b650-c42fa4906619" },
                    { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 8", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "593d7dcd-5874-4539-8f27-8ff35954aee9" },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "23549530-6bdf-446b-bc37-3e237130308f" },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 6", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dcf4aa0d-7ec7-438e-8c3e-2684a7f175d8" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "Id", "CreatedAt", "Name", "State", "UpdatedAt", "UserCreatorId" },
                values: new object[,]
                {
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 5", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ff2d7cd-52e1-4304-a7a8-fc9ba926f02a" },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 4", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17b9e13f-400b-425c-9308-f41c29ac5a8a" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 3", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c97a399c-2752-42ab-90b6-8dd7e8c672e4" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 2", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e7de518-3b0f-4fba-8092-e048aa0d8bea" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 1", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "55486f5d-26de-44c5-be27-115824a1e4ee" },
                    { 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 22", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d35df2c5-5cd0-4973-9eee-b2573fc7d857" },
                    { 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 23", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6532500a-8357-41eb-8b6e-551c74844623" },
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 0", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d94ea007-531c-4339-af9f-077cf842f9a1" },
                    { 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 25", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a23f65eb-2663-4f2b-94b3-c01f9d8a1895" },
                    { 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 24", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8b332659-5fd5-49d8-9f30-430fd391ce5a" },
                    { 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 47", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "887dea9a-d8b7-485f-8f58-fded26a74d0f" },
                    { 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 46", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1db5a38b-ba49-4285-b845-7525a597cb41" },
                    { 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 45", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "91101301-0d41-4495-a9e3-00e1473aef9f" },
                    { 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 44", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5af48cda-9119-48e4-bbaa-238b37cbfda2" },
                    { 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 43", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b87e1c48-b42c-4083-a89e-9c2556cd83ec" },
                    { 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 42", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "acd5f4cb-04fe-4379-8094-18d8fbb3c44c" },
                    { 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 40", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b18fa6ad-818e-41ff-81ba-dfabfae62855" },
                    { 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 39", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "67fbd51a-b54b-4416-a853-03d1d5a4323d" },
                    { 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 38", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18bb1e4e-6782-47e4-9957-b9cd6395f437" },
                    { 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 37", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "efc38f21-9a54-4dcd-9e6f-7a93e532d314" },
                    { 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 41", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c77a43d5-ae3f-4182-801f-a2c612736c47" },
                    { 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 35", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3ec4ab38-4605-4ae3-9318-da79ea70d775" },
                    { 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 34", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a1fd8763-b7f1-4a44-ae2f-39af8a4eec65" },
                    { 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 33", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "34adfeb7-837b-496b-8055-57958ea0cd9b" },
                    { 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 26", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc58f5b3-0cb5-44e8-bbcc-49159315039c" },
                    { 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 32", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7faa6d06-127e-4ace-bd35-60998f0ca220" },
                    { 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 31", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1c88995e-aa7b-4ccc-a235-75d05cee5272" },
                    { 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 30", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f91cea40-9049-472b-b104-4e6d3eb5d0b1" },
                    { 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 29", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca69e3-25bb-45a6-b3a0-6231762b8daa" },
                    { 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 28", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9256ded7-e699-4a3c-9e6a-04c6c6607e5a" },
                    { 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 27", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5ff92a6a-7da3-45f6-9ab6-62defeb3503e" },
                    { 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family 36", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "548e5959-c34f-42a0-bfef-7c1bc696609a" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "Address1", "Address2", "City", "Contact", "Country", "CreatedAt", "Email", "MinimalOrder", "Name", "Note", "Phone", "Province", "State", "UpdatedAt", "UserCreatorId", "Zip" },
                values: new object[,]
                {
                    { 65L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 64", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8d09ee2f-8ee0-49f2-8e0a-0eac0aa879a9", null },
                    { 66L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 65", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c4e2e260-3c98-445b-9c99-6824c09a346d", null },
                    { 67L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 66", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01c95c5f-9612-4bf9-9711-e6c0bd6d361c", null },
                    { 72L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 71", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0f75fae8-ff8d-4f22-adc7-bdf00e4d4cb9", null },
                    { 69L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 68", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b3c24ca-2526-4ee0-a0ea-04612d5a9b2b", null },
                    { 70L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 69", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "abcde5a7-d2fa-43f6-a194-0a352a8f841a", null },
                    { 71L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 70", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e3815e51-d345-41eb-a0fa-57b12bbcfa9d", null },
                    { 64L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 63", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4da6a7de-f4b2-418f-8917-cb9a008e1256", null },
                    { 68L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 67", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "89846b4c-92e2-4028-8386-795676b6e790", null },
                    { 63L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 62", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "df030877-744c-4b4c-85d9-7303334a33f4", null }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "Address1", "Address2", "City", "Contact", "Country", "CreatedAt", "Email", "MinimalOrder", "Name", "Note", "Phone", "Province", "State", "UpdatedAt", "UserCreatorId", "Zip" },
                values: new object[,]
                {
                    { 52L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 51", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bf8c6e13-d244-4a9e-8ac3-f0af8d3f188e", null },
                    { 61L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 60", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e49a2a09-cc24-4aca-a302-81a3c0c4a6ba", null },
                    { 60L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 59", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2da2e7fc-2385-4a7d-8218-d8db060b9ce3", null },
                    { 59L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 58", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "87f1708b-bdcf-4817-b807-a94daed18642", null },
                    { 58L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 57", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "53eb5574-cc30-43ad-9fd0-876795668469", null },
                    { 57L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 56", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7fac5bc1-020c-465b-ad4f-017ad9d2efbd", null },
                    { 56L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 55", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5ac0de3e-d476-4905-8d59-441a04e7e7a8", null },
                    { 55L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 54", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1366b8ad-bcba-4284-8ebe-faad8d0e0768", null },
                    { 54L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 53", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c9a79ca3-cbfa-4df5-94a8-87baf8a44146", null },
                    { 53L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 52", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17163f5f-7c1b-4e1b-9ff7-78502c6396e8", null },
                    { 73L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 72", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4efadb62-c0c1-45d7-82d7-391387a7c762", null },
                    { 62L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 61", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0522c4e9-cb84-40d9-86a6-0f11c6f9e54f", null },
                    { 74L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 73", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "de161de1-93f6-45aa-a8e4-238287abd422", null },
                    { 86L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 85", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2d9edc69-909c-4d01-96fb-bbd0a66db77f", null },
                    { 76L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 75", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ac333b61-2565-4aba-b154-2f00d027e6c6", null },
                    { 51L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 50", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6b8608eb-69db-4e88-8e25-2f872618c5fa", null },
                    { 98L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 97", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3ed77a54-eff8-4086-bfb4-47f50c63a09b", null },
                    { 97L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 96", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2e8a2d66-e4e4-4b49-a4d5-5a851ce8fe46", null },
                    { 96L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 95", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1a51a474-2887-4118-b31c-038e75267bfa", null },
                    { 95L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 94", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "28346522-bb4b-40f3-8a3d-ba94cb2d3591", null },
                    { 94L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 93", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "677ff3b2-50a9-46dc-abbd-d789128e62df", null },
                    { 93L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 92", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "286bc9b5-b596-4e62-a7b4-4cf38fc08fd7", null },
                    { 92L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 91", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38390e6a-fa50-4fcc-952e-ee1949ce604b", null },
                    { 91L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 90", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b5a093ea-a704-48cb-a721-119ce97fc5c0", null },
                    { 90L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 89", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e5b95d7a-8783-4d3b-8133-3f86802e85bc", null },
                    { 75L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 74", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f268be6c-8876-4611-ac06-405b234385f7", null },
                    { 89L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 88", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "750d2b0c-609d-496a-8035-78b0cacc379a", null },
                    { 87L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 86", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7ef7e8ef-d83e-4785-8ea5-3e0699b4dfe0", null },
                    { 85L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 84", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e71ce895-407b-4c1b-80db-900f4e55e779", null },
                    { 84L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 83", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2ce159be-2851-450f-9d94-9b5a2daafd81", null },
                    { 83L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 82", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "44237bbc-8ebc-44e5-8056-bf920289759b", null },
                    { 82L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 81", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "05457d3c-b2e0-4efa-a7ac-a73880b2abe0", null },
                    { 81L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 80", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dce82fd0-301c-4861-9c11-b43937748ae2", null },
                    { 80L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 79", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "341e44a3-36b9-4678-ba9f-6b455f737b95", null },
                    { 79L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 78", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5d979c4f-d404-4f89-a568-2d6e2f86b484", null },
                    { 78L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 77", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2c4bd813-3ac2-442a-ba07-969482600bb9", null },
                    { 77L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 76", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f28ba8b5-e2b0-4b23-ba6b-9fcb61172e4d", null },
                    { 88L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 87", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "104a458f-37c8-4a68-b059-70189b4c852e", null },
                    { 50L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 49", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7a8f69f5-d604-4df5-bc61-986d2702fb2a", null },
                    { 26L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 25", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c1351743-4d18-4ff1-8060-d81ac738e523", null },
                    { 48L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 47", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3ad8d1a2-0a3e-49f0-b369-f4b8e1e92f2d", null },
                    { 21L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 20", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "25eb2cde-15c9-4e41-aadd-c1d1b6320ca8", null }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "Address1", "Address2", "City", "Contact", "Country", "CreatedAt", "Email", "MinimalOrder", "Name", "Note", "Phone", "Province", "State", "UpdatedAt", "UserCreatorId", "Zip" },
                values: new object[,]
                {
                    { 20L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 19", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3004434f-e7b0-43cf-8af8-a5712c11101a", null },
                    { 19L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 18", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c2d06143-119d-4458-bc81-194b83eb6403", null },
                    { 18L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 17", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aa871b0d-3597-4c09-95c1-dbf8d24e2906", null },
                    { 17L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 16", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b48022a1-d6fd-4c82-b3b0-a6a46848a70a", null },
                    { 16L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 15", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b201f711-db63-4491-8eea-7d73c15d51d4", null },
                    { 15L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 14", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22956dd2-4a92-41e3-91c3-3910f825382f", null },
                    { 14L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 13", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9938624f-5ed3-4ba3-8dad-6ec30e2572b2", null },
                    { 13L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 12", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dfee6d1f-dc73-4cc7-b74b-bcd4c6cbea52", null },
                    { 12L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 11", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c724e3d2-f181-49f1-b137-9359ab54167a", null },
                    { 11L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 10", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b0c18fd6-d0a2-4273-afe2-766d26910d07", null },
                    { 10L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 9", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3740ee95-f01b-4870-a0eb-cbeefa8ec4f4", null },
                    { 9L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 8", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "73b0a3e0-e6df-47d6-9a30-8473d2f35134", null },
                    { 8L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 7", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "04ad800f-dfd9-4e64-ba4b-417fafadfacb", null },
                    { 7L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 6", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4939811f-52e8-4ed8-9ed1-c674e16a9cf7", null },
                    { 6L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 5", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4fe318e2-3224-433b-9c2a-2e26ad0ee1c1", null },
                    { 5L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 4", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a2cae9e1-c8f8-49c6-b9a4-463b6b9efb18", null },
                    { 4L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 3", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b4e37c08-e9ab-4a91-914d-8bc5315de851", null },
                    { 3L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 2", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b55d1b35-5aed-4f27-a452-4916f095ce11", null },
                    { 2L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 1", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6020751d-42e4-4ccd-a3e7-0344ee7fe724", null },
                    { 1L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 0", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ce87c5b1-4470-442c-b55d-e60778c962e0", null },
                    { 22L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 21", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ab852d1c-f6ff-4be3-ad6b-3c4bf44f8558", null },
                    { 23L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 22", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "83525067-4c28-4311-9f92-e316a1ccadea", null },
                    { 24L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 23", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4afc0dc6-303e-4a44-9faa-c5289229beab", null },
                    { 25L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 24", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7379c13-8296-4313-ab04-85b0cce3100a", null },
                    { 47L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 46", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d0cfb715-fa29-4c84-84ab-5a7a8a1478ce", null },
                    { 46L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 45", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "709daf5b-c818-432e-8df9-d91dc213d3c1", null },
                    { 45L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 44", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b281eb0e-2ce2-4493-956b-ccb28f3790eb", null },
                    { 44L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 43", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cf67f667-5b68-4777-9344-0d8a204a4858", null },
                    { 43L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 42", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "176f3a3b-4b7f-4fa6-a644-26b8ebeaff65", null },
                    { 42L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 41", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7de0d617-023b-4676-931b-f308d047cc8a", null },
                    { 41L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 40", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7f35d23b-9c99-4271-8d35-ed6c86a1fb8d", null },
                    { 40L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 39", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "df89e5d3-79db-426d-8f4c-a055943a6692", null },
                    { 39L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 38", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1c3a35a2-58c1-4ee3-a9ab-052103f77e88", null },
                    { 38L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 37", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5ab80478-b2bf-4cd2-9da9-29ad79f1ed8c", null },
                    { 49L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 48", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b17b6644-d55a-4e93-bcab-700447ba1613", null },
                    { 37L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 36", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "333e573d-d2a5-43a2-8a05-6f4e2058ab29", null },
                    { 35L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 34", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18cccd7a-ae11-4af5-8b19-db3ddbe7a5aa", null },
                    { 34L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 33", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6ace5fd3-852d-4d75-81bd-e87d03b50f21", null },
                    { 33L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 32", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2d46af5c-588b-419e-b5bd-bdd4e94f85a2", null },
                    { 32L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 31", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3a4d664f-1777-4b8a-9de4-cc51d9d6ab76", null },
                    { 31L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 30", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2745d0ed-f582-4764-ab0a-97174781053e", null },
                    { 30L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 29", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6c1a4fb1-2837-48de-90b4-1bf2615135f0", null }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "Address1", "Address2", "City", "Contact", "Country", "CreatedAt", "Email", "MinimalOrder", "Name", "Note", "Phone", "Province", "State", "UpdatedAt", "UserCreatorId", "Zip" },
                values: new object[,]
                {
                    { 29L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 28", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "40e7ae05-fb3d-4f30-abc0-0654626a41e6", null },
                    { 28L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 27", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "49b8a280-2e13-45ff-bba9-1c4824a6b4c4", null },
                    { 27L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 26", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19f9fa33-cf4a-425c-89eb-8438e9670207", null },
                    { 99L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 98", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "99031c1e-ac57-402a-b885-725507bf498b", null },
                    { 36L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 35", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b47efe2a-f33e-435a-8f05-735482788f8a", null },
                    { 100L, null, null, null, "Create - Contact Vendor", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", 200m, "Vendor 99", "Note", "1234567890", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "23175694-bb64-4e62-9aac-7606992785fc", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                table: "Category",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Discount_Name",
                table: "Discount",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiscountFamily_FamiliesId",
                table: "DiscountFamily",
                column: "FamiliesId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountStoreProduct_StoreProductsId",
                table: "DiscountStoreProduct",
                column: "StoreProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalScale_ScaleBrandId",
                table: "ExternalScale",
                column: "ScaleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalScale_StoreId",
                table: "ExternalScale",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_KitProductProduct_KitProductId",
                table: "KitProductProduct",
                column: "KitProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_FamilyId",
                table: "Product",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Name",
                table: "Product",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_PLUNumber",
                table: "Product",
                column: "PLUNumber",
                unique: true,
                filter: "[PLUNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ScaleCategoryId",
                table: "Product",
                column: "ScaleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ScaleLabelType1Id",
                table: "Product",
                column: "ScaleLabelType1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ScaleLabelType2Id",
                table: "Product",
                column: "ScaleLabelType2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ScaleLabelType3Id",
                table: "Product",
                column: "ScaleLabelType3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ScaleLabelType4Id",
                table: "Product",
                column: "ScaleLabelType4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UPC",
                table: "Product",
                column: "UPC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ScaleBrand_Name",
                table: "ScaleBrand",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScaleCategory_Name",
                table: "ScaleCategory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScaleLabelType_Name",
                table: "ScaleLabelType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Store_Name",
                table: "Store",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoreProduct_ProductId",
                table: "StoreProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProduct_StoreId",
                table: "StoreProduct",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductTax_TaxsId",
                table: "StoreProductTax",
                column: "TaxsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_Name",
                table: "Tax",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VendorProduct_ProductId",
                table: "VendorProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorProduct_VendorId",
                table: "VendorProduct",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountFamily");

            migrationBuilder.DropTable(
                name: "DiscountStoreProduct");

            migrationBuilder.DropTable(
                name: "ExternalScale");

            migrationBuilder.DropTable(
                name: "KitProductProduct");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "StoreProductTax");

            migrationBuilder.DropTable(
                name: "TenderType");

            migrationBuilder.DropTable(
                name: "VendorProduct");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "ScaleBrand");

            migrationBuilder.DropTable(
                name: "StoreProduct");

            migrationBuilder.DropTable(
                name: "Tax");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "ScaleCategory");

            migrationBuilder.DropTable(
                name: "ScaleLabelType");
        }
    }
}
