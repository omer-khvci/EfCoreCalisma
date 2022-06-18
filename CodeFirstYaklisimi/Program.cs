
using CodeFirstYaklisimi;
using CodeFirstYaklisimi.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var _context= new AppDpContext())
{
    var products = await _context.Products.ToListAsync();
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}: {p.Name}- {p.Stock}");
    });
}