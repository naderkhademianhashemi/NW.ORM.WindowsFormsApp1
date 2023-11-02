using Arian.NorthW.WindowsFormsApp1.Models;
using PayamHannan.Arian.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arian.NorthW.WindowsFormsApp1.REPO
{
    public class CatRepo
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public static List<Category> Get() => DBConnections.Context.Select<Category>("*").From("Categories").QueryMany();

        public static Category Get(int id)
        => DBConnections.Context.Sql(
            @"  SELECT * from Categories
	                    WHERE   (CategoryID = @id) ")
            .Parameter("id", id)
            .QuerySingle<Category>();

        public int Insert() => 
            CategoryID = DBConnections.Context.Insert("Categories", this).AutoMap(k => k.CategoryID).ExecuteReturnLastId<int>();

        public int Update()
        => CategoryID = DBConnections.Context.Update("Categories", this)
            .AutoMap(k => k.CategoryID)
            .Where(k => k.CategoryID)
            .Execute();
    }
}
