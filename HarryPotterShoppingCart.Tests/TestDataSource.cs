﻿using System.Collections.Generic;
using HarryPotterShoppingCart.Models;

namespace HarryPotterShoppingCart.Tests
{
    public class TestDataSource
    {
        public static IEnumerable<object[]> TestData => _data;

        private static readonly List<object[]> _data = new List<object[]>
        {
            //// 第一個測試案例：購買哈利波特第一集一本，沒有折扣，購物車金額應為 100 元
            new object[]
            {
                new ShoppingCartEntity
                {
                    Products = new List<ProductEntity>
                    {
                        new ProductEntity {Qty = 1, Name = "HerryPotter1", Price = 100}
                    }
                }, 100M
            },
            //// 第二個測試案例：購買哈利波特第一、二集各一本，享有折扣 5%，購物車金額應為 190 元
            new object[]
            {
                new ShoppingCartEntity
                {
                    Products = new List<ProductEntity>
                    {
                        new ProductEntity {Qty = 1, Name = "HerryPotter1", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter2", Price = 100}
                    }
                }, 190M
            },
            //// 第三個測試案例：購買哈利波特第一、二、三集各一本，享有折扣 10%，購物車金額應為 270 元
            new object[]
            {
                new ShoppingCartEntity
                {
                    Products = new List<ProductEntity>
                    {
                        new ProductEntity {Qty = 1, Name = "HerryPotter1", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter2", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter3", Price = 100}
                    }
                }, 270M
            },
            //// 第四個測試案例：購買哈利波特第一、二、三、四集各一本，享有折扣 20%，購物車金額應為 320 元
            new object[]
            {
                new ShoppingCartEntity
                {
                    Products = new List<ProductEntity>
                    {
                        new ProductEntity {Qty = 1, Name = "HerryPotter1", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter2", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter3", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter4", Price = 100}
                    }
                }, 320M
            },
            //// 第五個測試案例：購買哈利波特第一、二、三、四、五集各一本，享有折扣 25%，購物車金額應為 375 元
            new object[]
            {
                new ShoppingCartEntity
                {
                    Products = new List<ProductEntity>
                    {
                        new ProductEntity {Qty = 1, Name = "HerryPotter1", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter2", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter3", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter4", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter5", Price = 100}
                    }
                }, 375M
            },
            //// 第六個測試案例：購買哈利波特第二、三集各一本，第一集買兩本，第一、二、三集各一本時享有折扣 10%，第二本第一集則沒有折扣，購物車金額應為 370 元
            new object[]
            {
                new ShoppingCartEntity
                {
                    Products = new List<ProductEntity>
                    {
                        new ProductEntity {Qty = 1, Name = "HerryPotter1", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter2", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter3", Price = 100},
                        new ProductEntity {Qty = 1, Name = "HerryPotter1", Price = 100}
                    }
                }, 370M
            }

        };
    }
}
