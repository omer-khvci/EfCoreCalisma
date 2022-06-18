
using CodeFirstYaklisimi;
using CodeFirstYaklisimi.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var _context= new AppDpContext())
{
    //var products = await _context.Products.ToListAsync();
    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;
    //    Console.WriteLine($"{p.Id}: {p.Name}- {p.Stock} state: {state}");
    //});
    var product = await _context.Products.FirstAsync();
    Console.WriteLine($"ilk state {_context.Entry(product).State}");
    _context.Remove(product);
 
   // Console.WriteLine($"ilk state {_context.Entry(newProduct).State}");
    //await _context.AddAsync(newProduct);
    //Console.WriteLine($"ilk state {_context.Entry(newProduct).State}");
    await _context.SaveChangesAsync();
    Console.WriteLine($"unchanced -- {_context.Entry(product).State}");
}