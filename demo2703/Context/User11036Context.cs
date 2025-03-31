using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using demo2703.Models;

namespace demo2703.Context;

public partial class User11036Context : DbContext
{
    public User11036Context()
    {
    }

    public User11036Context(DbContextOptions<User11036Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Bid> Bids { get; set; }

    public virtual DbSet<DeliveryHistory> DeliveryHistories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Health> Healths { get; set; }

    public virtual DbSet<HistorySale> HistorySales { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<NeedfulMaterial> NeedfulMaterials { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Placesale> Placesales { get; set; }

    public virtual DbSet<Prepayment> Prepayments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<RatingHistory> RatingHistories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TypeMaterial> TypeMaterials { get; set; }

    public virtual DbSet<TypePartner> TypePartners { get; set; }

    public virtual DbSet<Workshop> Workshops { get; set; }

    public virtual DbSet<WorkshopHistory> WorkshopHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=192.168.7.159:5432;Database=user11036;Username=user11036;password=92306");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bid>(entity =>
        {
            entity.HasKey(e => e.BidId).HasName("bid_pk");

            entity.ToTable("bid", "demo2703");

            entity.Property(e => e.BidId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("bid_id");
            entity.Property(e => e.Checkcomplite).HasColumnName("checkcomplite");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EmployeesId).HasColumnName("employees_id");
            entity.Property(e => e.NameBid)
                .HasColumnType("character varying")
                .HasColumnName("name_bid");
            entity.Property(e => e.ParntersId).HasColumnName("parnters_id");
            entity.Property(e => e.PrepaymentId).HasColumnName("prepayment_id");
        });

        modelBuilder.Entity<DeliveryHistory>(entity =>
        {
            entity.HasKey(e => e.DeliveryHistoryId).HasName("deliveryhistory_pk");

            entity.ToTable("delivery_history", "demo2703");

            entity.Property(e => e.DeliveryHistoryId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("delivery_history_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Delivered).HasColumnName("delivered");
            entity.Property(e => e.Quantity)
                .HasColumnType("character varying")
                .HasColumnName("quantity");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeesId).HasName("employees_pk");

            entity.ToTable("employees", "demo2703");

            entity.Property(e => e.EmployeesId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("employees_id");
            entity.Property(e => e.BankDetails).HasColumnName("bank_details");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Family).HasColumnName("family");
            entity.Property(e => e.Fio)
                .HasColumnType("character varying")
                .HasColumnName("fio");
            entity.Property(e => e.HealthId).HasColumnName("health_id");
            entity.Property(e => e.Passport)
                .HasColumnType("character varying")
                .HasColumnName("passport");
            entity.Property(e => e.RatingHistoryId).HasColumnName("rating_history_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
        });

        modelBuilder.Entity<Health>(entity =>
        {
            entity.HasKey(e => e.HealthId).HasName("health_pk");

            entity.ToTable("health", "demo2703");

            entity.Property(e => e.HealthId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("health_id");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
        });

        modelBuilder.Entity<HistorySale>(entity =>
        {
            entity.HasKey(e => e.HistorySalesId).HasName("sales_pk");

            entity.ToTable("history_sales", "demo2703");

            entity.Property(e => e.HistorySalesId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("history_sales_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("supplier_pk");

            entity.ToTable("material", "demo2703");

            entity.Property(e => e.MaterialId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("material_id");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasColumnType("character varying")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.StorageId).HasColumnName("storage_id");
            entity.Property(e => e.StoragyQuantity).HasColumnName("storagy_quantity");
            entity.Property(e => e.TypeMaterialId).HasColumnName("type_material_id");
            entity.Property(e => e.Unitm)
                .HasColumnType("character varying")
                .HasColumnName("unitm");
        });

        modelBuilder.Entity<NeedfulMaterial>(entity =>
        {
            entity.HasKey(e => e.NeedfulMaterialsId).HasName("necessary_materials_pk");

            entity.ToTable("needful_materials", "demo2703");

            entity.Property(e => e.NeedfulMaterialsId)
                .ValueGeneratedNever()
                .HasColumnName("needful_materials_id");
            entity.Property(e => e.ListMaterials)
                .HasColumnType("character varying")
                .HasColumnName("list_materials");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Partnersid).HasName("partners_pk");

            entity.ToTable("partners", "demo2703");

            entity.Property(e => e.Partnersid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("partnersid");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Fio)
                .HasColumnType("character varying")
                .HasColumnName("fio");
            entity.Property(e => e.HistorySalesId).HasColumnName("history_sales_id");
            entity.Property(e => e.Inn)
                .HasColumnType("character varying")
                .HasColumnName("inn");
            entity.Property(e => e.Logo)
                .HasColumnType("character varying")
                .HasColumnName("logo");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.PlacesalesId).HasColumnName("placesales_id");
            entity.Property(e => e.RatingHistoryId).HasColumnName("rating_history_id");
            entity.Property(e => e.TypePartnersId).HasColumnName("type_partners_id");
            entity.Property(e => e.Uradress)
                .HasColumnType("character varying")
                .HasColumnName("uradress");
        });

        modelBuilder.Entity<Placesale>(entity =>
        {
            entity.HasKey(e => e.PlacesalesId).HasName("placesales_pk");

            entity.ToTable("placesales", "demo2703");

            entity.Property(e => e.PlacesalesId)
                .ValueGeneratedNever()
                .HasColumnName("placesales_id");
            entity.Property(e => e.Place).HasColumnName("place");
        });

        modelBuilder.Entity<Prepayment>(entity =>
        {
            entity.HasKey(e => e.PrepaymentId).HasName("prepayment_pk");

            entity.ToTable("prepayment", "demo2703");

            entity.Property(e => e.PrepaymentId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("prepayment_id");
            entity.Property(e => e.Check).HasColumnName("check");
            entity.Property(e => e.CostProducts).HasColumnName("cost_products");
            entity.Property(e => e.Prepayment1).HasColumnName("prepayment");
            entity.Property(e => e.ProductsId).HasColumnName("products_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductsId).HasName("products_pk");

            entity.ToTable("products", "demo2703");

            entity.Property(e => e.ProductsId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("products_id");
            entity.Property(e => e.Articul)
                .HasColumnType("character varying")
                .HasColumnName("articul");
            entity.Property(e => e.Certificate)
                .HasColumnType("character varying")
                .HasColumnName("certificate");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Image)
                .HasColumnType("character varying")
                .HasColumnName("image");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.NumberOfPeople).HasColumnName("number_of_people");
            entity.Property(e => e.ProductionTime)
                .HasColumnType("character varying")
                .HasColumnName("production_time");
            entity.Property(e => e.SalesId).HasColumnName("sales_id");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WeightWithPackaging).HasColumnName("weight_with_packaging");
            entity.Property(e => e.WeightWithoutPackaging).HasColumnName("weight_without_packaging");
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            entity.Property(e => e.WorkshopNumber).HasColumnName("workshop_number");
        });

        modelBuilder.Entity<RatingHistory>(entity =>
        {
            entity.HasKey(e => e.RatingHistoryId).HasName("rating_history_pk");

            entity.ToTable("rating_history", "demo2703");

            entity.Property(e => e.RatingHistoryId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("rating_history_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.RaitingNow).HasColumnName("raiting_now");
            entity.Property(e => e.RaitingPast).HasColumnName("raiting_past");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("role_pk");

            entity.ToTable("role", "demo2703");

            entity.Property(e => e.RoleId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("role_id");
            entity.Property(e => e.Role1)
                .HasColumnType("character varying")
                .HasColumnName("role");
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.HasKey(e => e.StorageId).HasName("warehouse_pk");

            entity.ToTable("storage", "demo2703");

            entity.Property(e => e.StorageId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("storage_id");
            entity.Property(e => e.Admission)
                .HasColumnType("character varying")
                .HasColumnName("admission");
            entity.Property(e => e.Disposal)
                .HasColumnType("character varying")
                .HasColumnName("disposal");
            entity.Property(e => e.Instock).HasColumnName("instock");
            entity.Property(e => e.Nowproduct)
                .HasColumnType("character varying")
                .HasColumnName("nowproduct");
            entity.Property(e => e.ProductsId).HasColumnName("products_id");
            entity.Property(e => e.Reserve)
                .HasColumnType("character varying")
                .HasColumnName("reserve");
            entity.Property(e => e.WorkshophistoryId).HasColumnName("workshophistory_id");
            entity.Property(e => e.WriteOff)
                .HasColumnType("character varying")
                .HasColumnName("write-off");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("provider_pk");

            entity.ToTable("supplier", "demo2703");

            entity.Property(e => e.SupplierId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("supplier_id");
            entity.Property(e => e.DeliveryHistoryId).HasColumnName("delivery_history_id");
            entity.Property(e => e.Inn)
                .HasColumnType("character varying")
                .HasColumnName("inn");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
        });

        modelBuilder.Entity<TypeMaterial>(entity =>
        {
            entity.HasKey(e => e.TypeMaterialId).HasName("type_material_pk");

            entity.ToTable("type_material", "demo2703");

            entity.Property(e => e.TypeMaterialId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("type_material_id");
            entity.Property(e => e.TypeMaterial1)
                .HasColumnType("character varying")
                .HasColumnName("type_material");
        });

        modelBuilder.Entity<TypePartner>(entity =>
        {
            entity.HasKey(e => e.TypePartnersId).HasName("type_partners_pk");

            entity.ToTable("type_partners", "demo2703");

            entity.Property(e => e.TypePartnersId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("type_partners_id");
            entity.Property(e => e.TypePartners)
                .HasColumnType("character varying")
                .HasColumnName("type_partners");
        });

        modelBuilder.Entity<Workshop>(entity =>
        {
            entity.HasKey(e => e.WorkshopId).HasName("workshop_pk");

            entity.ToTable("workshop", "demo2703");

            entity.Property(e => e.WorkshopId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("workshop_id");
            entity.Property(e => e.Numberworkshop).HasColumnName("numberworkshop");
        });

        modelBuilder.Entity<WorkshopHistory>(entity =>
        {
            entity.HasKey(e => e.WorkshopHistoryId).HasName("workshophistory_pk");

            entity.ToTable("workshop_history", "demo2703");

            entity.Property(e => e.WorkshopHistoryId)
                .ValueGeneratedNever()
                .HasColumnName("workshop_history_id");
            entity.Property(e => e.Costprice).HasColumnName("costprice");
            entity.Property(e => e.NecessaryMaterialsId).HasColumnName("necessary_materials_id");
            entity.Property(e => e.PriceNow).HasColumnName("price_now");
            entity.Property(e => e.PriceOld).HasColumnName("price_old");
            entity.Property(e => e.Pricerange).HasColumnName("pricerange");
            entity.Property(e => e.TimeManufacturing).HasColumnName("time_manufacturing");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
