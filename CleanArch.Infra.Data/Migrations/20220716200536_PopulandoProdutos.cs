using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.Infra.Data.Migrations
{
    public partial class PopulandoProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO [dbo].[Produtos] ([Nome],[Descricao],[Preco],[Stock],[Imagem],[CategoriaId])  VALUES "
                + "('Cola Bastao','cola bastao 100g',5.00,1,'colabastao.pnj',1)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM PRODUTOS");
        }
    }
}
