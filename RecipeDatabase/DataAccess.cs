﻿using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using Wisej.Web;

namespace RecipeDatabase
{
    public class DataAccess
    {
        public List<MenuItem> GetMenuItems()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using SQL query sent in by text
                //var output = connection.Query<MenuItem>("select * from Menu_Items").ToList();
                //using stored procedure
                var output = connection.Query<MenuItem>("dbo.GetAllMenuItem").ToList();
                return output;
            }
        }

        public List<FoodGroup> GetFoodGroups()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using SQL query sent in by text
                //var output = connection.Query<FoodGroup>("select * from Food_Group").ToList();
                //using stored procedure
                var output = connection.Query<FoodGroup>("dbo.GetAllFoodGroup").ToList();
                return output;
            }
        }

        public List<MenuItem> GetMenuItemsWithSameFoodGroup(string foodGroup)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using stored procedure
                var output = connection.Query<MenuItem>("dbo.GetMenuItemsWithSameFoodGroup @FoodGroup", new { FoodGroup = foodGroup }).ToList();
                return output;
            }
        }
        //write more functions here with more queries
        //I think they have to return a List<MenuItem> or a List<FoodGroup>??


        //updates the entire row
        public void UpdateFoodGroup(string foodGroup, string ingredient, string wheneaten, string piclink)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using stored procedure
                connection.Execute("dbo.UpdateFoodGroup @Food_Group, @Main_Ingredients, @When_Eaten, @Picture_Link", new FoodGroup { Food_Group = foodGroup, Main_Ingredients = ingredient, When_Eaten = wheneaten, Picture_Link = piclink  });

            }
        }

        public void UpdateFoodGroupSingleValue(string foodGroup, string colName, string newValue)
        {
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using stored procedure
                //we send in an anonymous object with the parameter values.
				connection.Execute("dbo.UpdateFoodGroupOneColumnOnlySingleValuegood @PK_Food_Group, @ColumnName, @NewValue", new { PK_Food_Group = foodGroup, ColumnName = colName, NewValue = newValue });

			}
		}
        //updates a single value
        //add code here
        public string FoodTransaction(string foodGroup, string ingredient, string wheneaten, string picturelink, string foodname)
        {
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
			{
				//we must use Query instead of Execute because we are returning a value
                //Query returns an IEnumberable of type string. use .First() to get the first item (first string)
				string output = connection.Query<string>("dbo.FoodTransaction @FoodGroup, @Ingredient, @WhenEaten,@PictureLink, @FoodName", new { FoodGroup = foodGroup, Ingredient = ingredient, WhenEaten = wheneaten, PictureLink= picturelink, FoodName = foodname }).First();

				return output;
			}
		}

        public string GetPDFFilepathFromDatabase(string foodGroup)
        {
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
			{
				//we must use Query instead of Execute because we are returning a value
				//Query returns an IEnumberable of type string. use .First() to get the first item (first string)
				string output = connection.Query<string>("dbo.GetPDFFilepathFromDatabase @FoodGroup", new { FoodGroup = foodGroup }).First();

				return output;
			}
		}
    }
}
