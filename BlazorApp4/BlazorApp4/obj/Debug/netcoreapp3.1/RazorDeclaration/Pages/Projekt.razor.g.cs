#pragma checksum "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\Pages\Projekt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abac916e1a21cbf9e2758586f01d597333ee4f40"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorApp4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorApp4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorStrap.Extensions.BSDataTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorStrap.Extensions.TreeView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorStrap.Extensions.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorStrap.Util.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorStrap.Components.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\_Imports.razor"
using BlazorApp4.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projekt")]
    public partial class Projekt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\Pages\Projekt.razor"
 
    public List<SampleData> Project { get; set; }
    private BSDataTable<SampleData> SortableRef { get; set; }

    public class SampleData

    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        public string Dat { get; set; }

    }



    public void NovaTab() //Test
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SDC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        using var con = new SqlConnection(cs);
        con.Open();

        using var cmd = new SqlCommand();
        cmd.Connection = con;

        cmd.CommandText = "DROP TABLE IF EXISTS cars";
        cmd.ExecuteNonQuery();

        cmd.CommandText = @"CREATE TABLE cars(
id int identity(1,1) NOT NULL PRIMARY KEY,
name VARCHAR(255) NOT NULL,
price VARCHAR(255) NOT NULL,
)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volvo',29000)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Bentley',350000)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Citroen',21000)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Hummer',41400)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volkswagen',21600)";
        cmd.ExecuteNonQuery();

    }

    public void DoplnTab()  //Test
    {

        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SDC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        using var con = new SqlConnection(cs);
        con.Open();

        var query = "INSERT INTO cars(name, price, dart) VALUES(@name, @price, @dart)";
        using var cmd = new SqlCommand(query, con);

        cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255)).Value = "Trabant";
        cmd.Parameters.Add("@price", SqlDbType.VarChar, 255).Value = "4500";
        cmd.Parameters.Add("@dart", SqlDbType.VarChar, 255).Value = DateTime.Now.ToString();
        cmd.Prepare();

        cmd.ExecuteNonQuery();


    }

    protected override void OnInitialized() //Test
    {

        Project = new List<SampleData>();

        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SDC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        using var con = new SqlConnection(cs);
        con.Open();

        string sql = "SELECT * FROM cars";
        using var cmd = new SqlCommand(sql, con);

        using SqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            //Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2));

            Project.Add(new SampleData()

            {
                Id = rdr.GetInt32(0),

                UserName = rdr.GetString(1),

                Email = rdr.GetString(2),

                Dat = rdr.GetString(3),

            }); ;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
