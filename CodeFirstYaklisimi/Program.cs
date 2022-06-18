
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
    /*
     * Stateler konusu
    var product = await _context.Products.FirstAsync();
    Console.WriteLine($"ilk state {_context.Entry(product).State}");
    _context.Remove(product);
 
   // Console.WriteLine($"ilk state {_context.Entry(newProduct).State}");
    //await _context.AddAsync(newProduct);
    //Console.WriteLine($"ilk state {_context.Entry(newProduct).State}");
    await _context.SaveChangesAsync();
    Console.WriteLine($"unchanced -- {_context.Entry(product).State}");
    
     */
   // var products =  _context.Products.AsNoTracking().ToListAsync();
    _context.Products.Add(new()
    {
        Name = "Kalem1",
        Price = 200,
        Stock = 100,
        Barcode = 123
    });
    _context.Products.Add(new()
    {
        Name = "Kalem1",
        Price = 200,
        Stock = 100,
        Barcode = 123
    });
    _context.Products.Add(new()
    {
        Name = "Kalem1",
        Price = 200,
        Stock = 100,
        Barcode = 123
    });
   
     _context.SaveChanges();

}