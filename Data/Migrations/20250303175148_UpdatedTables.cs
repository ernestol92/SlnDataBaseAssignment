using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEntity_RoleEntity_RoleId",
                table: "EmployeeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentEntity_PaymentStatusEntity_PaymentStatusId",
                table: "PaymentEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_EmployeeEntity_ProjectManagerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_PaymentEntity_PaymentId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ServiceEntity_ServiceId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceEntity",
                table: "ServiceEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleEntity",
                table: "RoleEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentStatusEntity",
                table: "PaymentStatusEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentEntity",
                table: "PaymentEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeEntity",
                table: "EmployeeEntity");

            migrationBuilder.RenameTable(
                name: "ServiceEntity",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "RoleEntity",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "PaymentStatusEntity",
                newName: "PaymentStatus");

            migrationBuilder.RenameTable(
                name: "PaymentEntity",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "EmployeeEntity",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentEntity_PaymentStatusId",
                table: "Payments",
                newName: "IX_Payments_PaymentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeEntity_RoleId",
                table: "Employees",
                newName: "IX_Employees_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentStatus",
                table: "PaymentStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Role_RoleId",
                table: "Employees",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentStatus_PaymentStatusId",
                table: "Payments",
                column: "PaymentStatusId",
                principalTable: "PaymentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Employees_ProjectManagerId",
                table: "Projects",
                column: "ProjectManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Payments_PaymentId",
                table: "Projects",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Services_ServiceId",
                table: "Projects",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Role_RoleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentStatus_PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Employees_ProjectManagerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Payments_PaymentId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Services_ServiceId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentStatus",
                table: "PaymentStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "ServiceEntity");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "RoleEntity");

            migrationBuilder.RenameTable(
                name: "PaymentStatus",
                newName: "PaymentStatusEntity");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "PaymentEntity");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeeEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentStatusId",
                table: "PaymentEntity",
                newName: "IX_PaymentEntity_PaymentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_RoleId",
                table: "EmployeeEntity",
                newName: "IX_EmployeeEntity_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceEntity",
                table: "ServiceEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleEntity",
                table: "RoleEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentStatusEntity",
                table: "PaymentStatusEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentEntity",
                table: "PaymentEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeEntity",
                table: "EmployeeEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEntity_RoleEntity_RoleId",
                table: "EmployeeEntity",
                column: "RoleId",
                principalTable: "RoleEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentEntity_PaymentStatusEntity_PaymentStatusId",
                table: "PaymentEntity",
                column: "PaymentStatusId",
                principalTable: "PaymentStatusEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_EmployeeEntity_ProjectManagerId",
                table: "Projects",
                column: "ProjectManagerId",
                principalTable: "EmployeeEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PaymentEntity_PaymentId",
                table: "Projects",
                column: "PaymentId",
                principalTable: "PaymentEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ServiceEntity_ServiceId",
                table: "Projects",
                column: "ServiceId",
                principalTable: "ServiceEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
