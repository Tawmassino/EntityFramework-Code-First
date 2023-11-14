using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Code_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //duombazes kontekstas
            using var dbContext = new BookContext();//using - bus automatiskai implementuoatas dbContext.Dispose(), kuris atlaisvins sistemos resursus

            //INSERT puslapi i duombaze

            //var page = new Page(1, "Puslapio turinys");
            //dbContext.Pages.Add(page);//dedame puslapi i savo klases lista
            //dbContext.SaveChanges();//sitas ivykdo viska kas ivyko, be sito, duombazej nebus

            //DELETE
            //var page = new Page(new Guid("0915CC69-5CF9-4749-9DE3-C189A0950E7F"));//paduodame ID pagal kuri triname
            //dbContext.Pages.Remove(page);
            //dbContext.SaveChanges();


            //SELECT
            //var page = dbContext.Pages.FirstOrDefault();//pirmas psl duombazej. galima naudoti linq.
            //cia savechanges nereikia, nes nieko nekeiciam, tiesiog view
            //var page = dbContext.Pages.Where(p=>p.Number == 2);


            //UPDATE
            //var page = dbContext.Pages.First(p => p.Id == Guid.Parse("F7A7849A-E174-4C6B-B6CF-0B4C301FFB2C"));
            //page.Content += ". Added new content.";
            //dbContext.SaveChanges();

            //BOOK AND PAGES
            //var book = new Book("Harry Potter");//sukuriame knyga
            //for (int i = 0; i < 565; i++)
            //{
            //    book.Pages.Add(new Page(i, $"content - {i}"));//pridedame lapu i knyga
            //}
            //dbContext.Books.Add(book);//insert
            //dbContext.SaveChanges();

            //DELETE PARENT AND CHILD
            //.Include(), padaro inner join tarp lenteliu, pridedame ir puslapius
            //be Include - child neissitrins is bus error
            var book = dbContext.Books.Include(b => b.Pages).FirstOrDefault(b => b.Id == new Guid("C720F9BC-40E2-4341-9BDF-9C180552DB73"));
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
        }
    }
}