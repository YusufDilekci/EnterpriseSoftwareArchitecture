using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//Generic Repository Design Pattern kullanılmıştır.

//CategoryTest();

//ProductTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());


    //var productsByCategory = productManager.GetAllByCategoryId(2);
    var result = productManager.GetProductDetails();

    if (result.Successed)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " / " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }



}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    var category = categoryManager.GetById(2);

    Console.WriteLine(category.CategoryName);
}