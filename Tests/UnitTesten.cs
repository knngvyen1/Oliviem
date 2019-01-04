using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLIVIEM.DAL;
using OLIVIEM.Models;

namespace Tests
{
    [TestClass]
    public class UnitTesten
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductDatabase database = new ProductDatabase();
            Product product = new Product(8, "zwarte jurk","s", "zwart",8, 8, "glitters van sq", 8, "https://lp2.hm.com/hmgoepprod?set=source[/96/5c/965cff28a251075956041b639675343482861851.jpg],origin[dam],category[],type[DESCRIPTIVESTILLLIFE],res[y],hmver[1]&call=url[file:/product/main]");
            database.AddProduct(product);
        }
    }
}
