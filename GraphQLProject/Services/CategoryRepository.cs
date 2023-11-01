﻿using GraphQL;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private GraphQLDbContext dbContext { get; set; }

        public CategoryRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Category AddCategory(Category category)
        {
            dbContext.Categories.Add(category); 
            dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var categoryResult = dbContext.Categories.Find(id);
            dbContext.Categories.Remove(categoryResult);
            dbContext.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }

        public Category UpdateCategory(Category category, int id)
        {
            var categoryResult = dbContext.Categories.Find(id);
            categoryResult.Name = category.Name;
            categoryResult.ImageUrl = category.ImageUrl;
            dbContext.SaveChanges();
            return categoryResult;

        }
    }
}
