namespace ComercioVirtual.Migrations
{
    using ComercioVirtual.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ComercioVirtual.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ComercioVirtual.Models.Context";
        }

        protected override void Seed(ComercioVirtual.Models.Context context)
        {
            GetCategorias().ForEach(c => context.Categorias.Add(c));
            GetProdutos().ForEach(p => context.Produtos.Add(p));
        }

        private static List<Categoria> GetCategorias()
        {
            var categorias = new List<Categoria> {
                new Categoria
                {
                    CategoriaId = 1,
                    Nome = "Carros"
                },
                new Categoria
                {
                    CategoriaId = 2,
                    Nome = "Aviões"
                },
                new Categoria
                {
                    CategoriaId = 3,
                    Nome = "Caminhões"
                },
                new Categoria
                {
                    CategoriaId = 4,
                    Nome = "Barcos"
                },
                new Categoria
                {
                    CategoriaId = 5,
                    Nome = "Foguetes"
                },
            };

            return categorias;
        }

        private static List<Produto> GetProdutos()
        {
            var Produtos = new List<Produto> {
                new Produto
                {
                    ProdutoId = 1,
                    Nome = "Convertible Car",
                    Descricao = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + 
                                  "Power it up and let it go!", 
                    CaminhoImagem="carconvert.png",
                    Preco = 22.50,
                    CategoriaId = 1
               },
                new Produto 
                {
                    ProdutoId = 2,
                    Nome = "Old-time Car",
                    Descricao = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    CaminhoImagem="carearly.png",
                    Preco = 15.95,
                     CategoriaId = 1
               },
                new Produto
                {
                    ProdutoId = 3,
                    Nome = "Fast Car",
                    Descricao = "Yes this car is fast, but it also floats in water.",
                    CaminhoImagem="carfast.png",
                    Preco = 32.99,
                    CategoriaId = 1
                },
                new Produto
                {
                    ProdutoId = 4,
                    Nome = "Super Fast Car",
                    Descricao = "Use this super fast car to entertain guests. Lights and doors work!",
                    CaminhoImagem="carfaster.png",
                    Preco = 8.95,
                    CategoriaId = 1
                },
                new Produto
                {
                    ProdutoId = 5,
                    Nome = "Old Style Racer",
                    Descricao = "This old style racer can fly (with user assistance). Gravity controls flight duration." + 
                                  "No batteries required.",
                    CaminhoImagem="carracer.png",
                    Preco = 34.95,
                    CategoriaId = 1
                },
                new Produto
                {
                    ProdutoId = 6,
                    Nome = "Ace Plane",
                    Descricao = "Authentic airplane toy. Features realistic color and details.",
                    CaminhoImagem="planeace.png",
                    Preco = 95.00,
                    CategoriaId = 2
                },
                new Produto
                {
                    ProdutoId = 7,
                    Nome = "Glider",
                    Descricao = "This fun glider is made from real balsa wood. Some assembly required.",
                    CaminhoImagem="planeglider.png",
                    Preco = 4.95,
                    CategoriaId = 2
                },
                new Produto
                {
                    ProdutoId = 8,
                    Nome = "Paper Plane",
                    Descricao = "This paper plane is like no other paper plane. Some folding required.",
                    CaminhoImagem="planepaper.png",
                    Preco = 2.95,
                    CategoriaId = 2
                },
                new Produto
                {
                    ProdutoId = 9,
                    Nome = "Propeller Plane",
                    Descricao = "Rubber band powered plane features two wheels.",
                    CaminhoImagem="planeprop.png",
                    Preco = 32.95,
                    CategoriaId = 2
                },
                new Produto
                {
                    ProdutoId = 10,
                    Nome = "Early Truck",
                    Descricao = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    CaminhoImagem="truckearly.png",
                    Preco = 15.00,
                    CategoriaId = 3
                },
                new Produto
                {
                    ProdutoId = 11,
                    Nome = "Fire Truck",
                    Descricao = "You will have endless fun with this one quarter sized fire truck.",
                    CaminhoImagem="truckfire.png",
                    Preco = 26.00,
                    CategoriaId = 3
                },
                new Produto
                {
                    ProdutoId = 12,
                    Nome = "Big Truck",
                    Descricao = "This fun toy truck can be used to tow other trucks that are not as big.",
                    CaminhoImagem="truckbig.png",
                    Preco = 29.00,
                    CategoriaId = 3
                },
                new Produto
                {
                    ProdutoId = 13,
                    Nome = "Big Ship",
                    Descricao = "Is it a boat or a ship. Let this floating vehicle decide by using its " + 
                                  "artifically intelligent computer brain!",
                    CaminhoImagem="boatbig.png",
                    Preco = 95.00,
                    CategoriaId = 4
                },
                new Produto
                {
                    ProdutoId = 14,
                    Nome = "Paper Boat",
                    Descricao = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" + 
                                  "Some folding required.",
                    CaminhoImagem="boatpaper.png",
                    Preco = 4.95,
                    CategoriaId = 4
                },
                new Produto
                {
                    ProdutoId = 15,
                    Nome = "Sail Boat",
                    Descricao = "Put this fun toy sail boat in the water and let it go!",
                    CaminhoImagem="boatsail.png",
                    Preco = 42.95,
                    CategoriaId = 4
                },
                new Produto
                {
                    ProdutoId = 16,
                    Nome = "Rocket",
                    Descricao = "This fun rocket will travel up to a height of 200 feet.",
                    CaminhoImagem="rocket.png",
                    Preco = 122.95,
                    CategoriaId = 5
                }
            };

            return Produtos;
        }
    }
}
