#pragma checksum "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\Pages\Projekty.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48a4d9e28cdf782c94e307f63cb197c7f4203e16"
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
#line 2 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\Pages\Projekty.razor"
using BlazorApp4.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Project")]
    public partial class Projekty : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 150 "C:\Users\MSI_GT72\Desktop\BlazorApp4\BlazorApp4\Pages\Projekty.razor"
 

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Administrators";

    System.Security.Claims.ClaimsPrincipal CurrentUser;
    public List<Project> Projekt { get; set; }
    private BSDataTable<Project> SortableRef { get; set; }

    Project objProjekt = new Project();
    List<Project> ColProjekt = new List<Project>();
    string Hala1 { get; set; } = "-";
    string Hala2 { get; set; } = "-";
    string Hala3 { get; set; } = "-";
    // Options to display in the roles dropdown when editing a user
    List<string> Options = new List<string>() { "SDC1 - Stará Hala", "SDC2 - Nová Hala", "ECS" };
    // To hold any possible errors
    string strError = "";
    // To enable showing the Popup
    bool ShowPopup = false;


    async Task EditUser(Project sample)
    {
        // Set the selected user
        // as the current user
        objProjekt = sample;

        ShowPopup = true;

    }

    protected override void OnInitialized() //Test
    {

        Projekt = new List<Project>();

        Projekt = context.Project.ToList();

        var test = 1;

        /*  string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SDC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

          using var con = new SqlConnection(cs);
          con.Open();

          string sql = "SELECT * FROM Project";
          using var cmd = new SqlCommand(sql, con);

          using SqlDataReader rdr = cmd.ExecuteReader();

          while (rdr.Read())
          {
              Projekt.Add(new SampleData()

              {
                  Id = rdr.GetInt32(0).ToString(),

                  ProjektNazov = rdr.GetString(1),

                  ProjektID = rdr.GetString(2),
                  Hala1 = rdr.GetString(3),
                  Hala2 = rdr.GetString(4),
                  Hala3 = rdr.GetString(5),
                  Dat = rdr.GetString(6),

              }); ;
          } */
    }

    void AddProjekt()
    {
        // Make new user
        objProjekt = new Project();
        //  objUser.PasswordHash = "*****";
        // Set Id to blank so we know it is a new record
        objProjekt.Id = 0;
        // Open the Popup
        ShowPopup = true;
    }

    async Task SaveUser()
    {

        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SDC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        using var con = new SqlConnection(cs);
        con.Open();

        var query = "INSERT INTO cars(name, price) VALUES(@name, @price)";
        using var cmd = new SqlCommand(query, con);

        cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255)).Value = "BMW";
        cmd.Parameters.Add("@price", SqlDbType.VarChar, 255).Value = "36600";
        cmd.Prepare();

        cmd.ExecuteNonQuery();
        try
        {
            // Is this an existing user?
            if (objProjekt.ProjektNazov != "")
            {
                // Get the user
                //var user = await _UserManager.FindByIdAsync(objProjekt.ProjektNazov);
                // Update Email
                //user.Email = objUser.Email;
                //user.UserName = objUser.UserName;
                // Update the user
                //await _UserManager.UpdateAsync(user);
                // Only update password if the current value
                // is not the default value
                //if (objUser.PasswordHash != "*****")
                //{
                //var resetToken =
                //await _UserManager.GeneratePasswordResetTokenAsync(user);
                //var passworduser =
                //await _UserManager.ResetPasswordAsync(
                //user,
                //resetToken,
                //objUser.PasswordHash);
                //if (!passworduser.Succeeded)
                //{
                //if (passworduser.Errors.FirstOrDefault() != null)
                //{
                //strError =
                //passworduser
                //.Errors
                //.FirstOrDefault()
                //.Description;
                //}
                //else
                //{
                //strError = "Pasword error";
                //}
                // Keep the popup opened
                //return;
                //}
                //}
                // Handle Roles
                // Is user in administrator role?
                //var UserResult =
                //await _UserManager
                //.IsInRoleAsync(user, ADMINISTRATION_ROLE);
                // Is Administrator role selected
                // but user is not an Administrator?
                //if (
                //(CurrentUserRole == ADMINISTRATION_ROLE)
                //&
                //(!UserResult))
                //{
                // Put admin in Administrator role
                //await _UserManager
                //.AddToRoleAsync(user, ADMINISTRATION_ROLE);
                //}
                //else
                //{
                // Is Administrator role not selected
                // but user is an Administrator?
                //if ((CurrentUserRole != ADMINISTRATION_ROLE)
                //&
                //(UserResult))
                //{
                // Remove user from Administrator role
                //await _UserManager
                //.RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
                //}
                //}
            }
            //else
            //{
            // Insert new user
            //var NewUser =
            //new IdentityUser
            //{
            //UserName = objUser.UserName,
            //Email = objUser.Email
            //};
            //var CreateResult =
            //await _UserManager
            //.CreateAsync(NewUser, objProjekt.ProjektID);
            //if (!CreateResult.Succeeded)
            //{
            //if (CreateResult
            //.Errors
            //.FirstOrDefault() != null)
            //{
            //strError =
            //CreateResult
            //.Errors
            //.FirstOrDefault()
            //.Description;
            //}
            //else
            //{
            //strError = "Create error";
            //}
            // Keep the popup opened
            //return;
            //}
            //else
            //{
            // Handle Roles
            //if (CurrentUserRole == ADMINISTRATION_ROLE)
            //{
            // Put admin in Administrator role
            //await _UserManager
            //.AddToRoleAsync(NewUser, ADMINISTRATION_ROLE);
            //}
            //}
            //}
            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            //GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }

    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }



    async Task UlozProjekt()  //Test
    {
        try
        {
            string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SDC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using var con = new SqlConnection(cs);
            con.Open();
            var query = "INSERT INTO Projekty(ID_Projekt, ID_ProjektID, ID_Hala1, ID_Hala2, ID_Hala3, DatPrid) VALUES(@ID_Projekt, @ID_ProjektID, @ID_Hala1, @ID_Hala2, @ID_Hala3, @DatPrid)";
            using var cmd = new SqlCommand(query, con);

            if (objProjekt.Id == 0) // Novy prjekt / uprava stareho projektu
            {
                context.Add(new Project
                {
                    Id = objProjekt.Id,
                    ProjektNazov= objProjekt.ProjektNazov,
                    ProjektID= objProjekt.ProjektID,
                    Hala1= objProjekt.Hala1,
                    Hala2= objProjekt.Hala2,
                    Hala3= objProjekt.Hala3,
                    Dat = DateTime.Now.ToString()

                }) ;

                context.SaveChanges();

            }
            else // uprava stareho projektu
            {


            }
            con.Close();
            ShowPopup = false;
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }

        Projekt = context.Project.ToList();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext context { get; set; }
    }
}
#pragma warning restore 1591
