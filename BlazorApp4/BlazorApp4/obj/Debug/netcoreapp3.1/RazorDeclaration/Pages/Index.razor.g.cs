#pragma checksum "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a724d1d5262f79b5e2e747a9e72c417bf8b8962"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\Pages\Index.razor"
       

    public List<SampleData> Samples1 { get; set; }
    private BSDataTable<SampleData> SortableRef { get; set; }

    protected override void OnInitialized()

    {

        Samples1 = new List<SampleData>();
        string path = @"C:\Users\MSI_GT72\Desktop\WriteFile.txt";

        // zapisuje na posledny riadok
        // string appendText = "This is extra text" + Environment.NewLine;
        //File.AppendAllText(path, appendText);

        // Open the file to read from.
        string[] readText = File.ReadAllLines(path);
        //
        //  string sprava = readText.Length(ib);

        int ia = readText.Length;
        for (int ib = 0; ib < ia; ib++)
        {
            string sprava = readText[ib];
            string[] spl = sprava.Split(';');

            Samples1.Add(new SampleData()

            {

                Datum = spl[0],

                TypZaznamu = spl[1],

                Projekt = spl[2],

                Stanica = spl[3],

                Porucha = spl[4],

                Opatrenie = spl[5],

                Typ = spl[6],

                Prestoj = spl[7],

                Vykonal = spl[8],

                //VyrND1 = spl[9],

                TypND1 = spl[9] + " - " + "\n" + spl[10] + "\n" + spl[11] + "ks",

                // ND1ks = spl[11],

                //VyrND2 = spl[12],

                TypND2 = spl[12] + " - " + "\n" + spl[13] + "\n" + spl[14] + "ks",

                //ND2ks = spl[14],

                //VyrND3 = spl[15],

                TypND3 = spl[15] + " - " + "\n" + spl[16] + "\n" + spl[17] + "ks",

                //ND3ks = spl[17]


            }); ;

        }
    }


    public class SampleData

    {

        public string Datum { get; set; }

        public string TypZaznamu { get; set; }

        public string Projekt { get; set; }

        public string Stanica { get; set; }

        public string Porucha { get; set; }

        public string Opatrenie { get; set; }

        public string Typ { get; set; }

        public string Prestoj { get; set; }

        public string Vykonal { get; set; }

        //public string VyrND1 { get; set; }

        public string TypND1 { get; set; }

        //public string ND1ks { get; set; }

        //public string VyrND2 { get; set; }

        public string TypND2 { get; set; }

        //public string ND2ks { get; set; }

        //public string VyrND3 { get; set; }

        public string TypND3 { get; set; }

        //public string ND3ks { get; set; }

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
