using Microsoft.VisualStudio.TestTools.UnitTesting;
using _DemoViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseData.DataProviders.EntityFramework.Contexts;
using static ConnectionConfig.Strings;
using Microsoft.EntityFrameworkCore;

namespace _DemoViewModel.Tests;

[TestClass()]
public class SelectForModulesVmTests
{
    public TestContext TestContext { get; set; }

    [TestMethod()]
    public void SelectForModulesVmTest_ReadPath()
    {
        var builder = new DbContextOptionsBuilder<DataContext>();
        builder.UseSqlServer(GetConnectionStrings(SqlExpress));
        var context = new DbContextFactory(builder.Options).Create();
        foreach (var item in context.PollutionFields)
        {
            TestContext.WriteLine("Link: " + item.LinkFile ?? "no data");
        }
        

        var s = new SelectForModulesVm(context);

        var exp = s.PollutionData?.FirstOrDefault()?.LinkFile;
        TestContext.WriteLine("result: " + exp ?? "no data");
        Assert.IsTrue(exp == @"C:\DiplomYA\_\Materials\BalevaAS\Data.txt");
    }

    [TestMethod()]
    public void SelectWeatherDataTest()
    {
        var builder = new DbContextOptionsBuilder<DataContext>();
        builder.UseSqlServer(GetConnectionStrings(SqlExpress));
        var context = new DbContextFactory(builder.Options).Create();
        var s = new SelectForModulesVm(context);

        var data = new DateTime(2012, 1, 3, 9, 0, 0);

        var result = s.SelectWeatherData(data);
        Assert.IsNotNull(result);
    }
}