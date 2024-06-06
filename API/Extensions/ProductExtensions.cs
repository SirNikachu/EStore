using API.Entities;

namespace API.Extensions;

public static class ProductExtensions
{
    public static IQueryable<Product> Sort(this IQueryable<Product> query, string orderBy)
    {
        if (string.IsNullOrWhiteSpace(orderBy)) return query.OrderBy(p => p.Name);

        query = orderBy switch
        {
            "price" => query.OrderBy(p => p.Price),
            "priceDesc" => query.OrderByDescending(p => p.Price),
            _ => query.OrderBy(n => n.Name)
        };

        return query;
    }

    public static IQueryable<Product> Search(this IQueryable<Product> query, string searchTerm)
    {
        if (string.IsNullOrEmpty(searchTerm)) return query;

        var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

        return query.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
    }

    public static IQueryable<Product> Filter(this IQueryable<Product> query, string categories)
    {
        var categoryList = new List<string>();
        List<string> typeList = new();

        if (!string.IsNullOrEmpty(categories))
        {
            categoryList.AddRange(categories.ToLower().Split(",").ToList());
        }


        query = query.Where(p => categoryList.Count == 0 || categoryList.Contains(p.Category.ToLower()));
               
        return query;
    }
}