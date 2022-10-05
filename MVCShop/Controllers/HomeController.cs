using Microsoft.AspNetCore.Mvc;
using MVCShop.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using MVCShop.Data;

namespace MVCShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ShopDbContext _dbContext;
        //private readonly string ProductData = "{{ 'id':001,'Name':'Peach','Category':'Fruit','Brand':'Kiwi'},{ 'id':002,'Name':'Pear','Category':'Fruit','Brand':'Kiwi'}}";
        /// <summary>
        /// instructure function 构造函数
        /// 当类被实例化的时候，就先执行构造函数，就相当于初始化这个类
        /// 每一个controller都是服务于每一个page，也就是说每一个page的功能都有它对应的controller
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(ILogger<HomeController> logger)
        {
            //初始化
            _logger = logger;
            //_dbContext = dbContext;
        }
        /// <summary>
        /// 以下普通函数的格式为public（访问修饰符）+ 返回值的数据类型 + 函数名
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            

            
            IndexViewModel productViewModel001 = new IndexViewModel();

            productViewModel001.Id = 001;
            productViewModel001.Name = "Peach";
            productViewModel001.Category = "Fruit";
            productViewModel001.Brand = "Kiwi";

            IndexViewModel productViewModel002 = new IndexViewModel();

            productViewModel002.Id = 002;
            productViewModel002.Name = "Pear";
            productViewModel002.Category = "Fruit";
            productViewModel002.Brand = "Kiwi";

            IndexViewModel productViewModel003 = new IndexViewModel();

            productViewModel003.Id = 003;
            productViewModel003.Name = "Pineapple";
            productViewModel003.Category = "Fruit";
            productViewModel003.Brand = "China";

            IndexViewModel productViewModel004 = new IndexViewModel();

            productViewModel004.Id = 004;
            productViewModel004.Name = "apple";
            productViewModel004.Category = "Fruit";
            productViewModel004.Brand = "China";



            List<IndexViewModel> products = new List<IndexViewModel>();
            products.Add(productViewModel001);
            products.Add(productViewModel002);
            products.Add(productViewModel003);
            products.Add(productViewModel004);

            
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}