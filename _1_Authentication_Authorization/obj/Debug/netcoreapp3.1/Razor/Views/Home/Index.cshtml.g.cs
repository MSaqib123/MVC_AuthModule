#pragma checksum "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7456d24d6f5c14ab93f782c101c5c2b0078ad13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using _3_Authentication_Authorization_Other_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using DML._1_clsAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using DAL.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using _1_Authentication_Authorization.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7456d24d6f5c14ab93f782c101c5c2b0078ad13", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de8e1eb5ccb3e2a9bf8cb68b80bb2bf4a3bdfeb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div class=\"row\">\r\n");
            WriteLiteral(@"        <div class=""col-sm-6"">
            <h1 class=""display-5"">1. Authentitcation</h1>
            <h3 class=""text-primary"">____ 1. SignUp ____</h3>
                <ol>
                    <li>Install => Identity Entity FramWork Core</li>
                    <li>Add => Midlwear => App.Authentication =|= App.Authorization</li>
                    <li>
                        Add => Searvices  (1. Services.AddIdentity IdentityUser,IdentityRole>().AddEntityFrameworkStores ProductContext>();<br />
                        IdentityUser -->Add User <br />
                        IdentityRole -->Add role to User<br />
                        AddEntityFrameWorkStores ==> user ContextFile
                    </li>
                    <li>
                        create Context  ==> Inharite ==> IdentityDbContext class (not DbContext)
                    </li>
                    <li>
                        create SignupModel ==> same name (its BuiltIn_Model of Identity)<br />
                      ");
            WriteLiteral(@"  Override properties of SignupModel ==>  these Propertis are Virtual in Model
                    </li>
                    <li>Add-migration / update-database</li>
                    <li>Add => AccountController (kuch bhe name)</li>
                    <li>Add => Signup ==> IActionMethod</li>
                    <li>Add => Signup Post Async(await) ==> IActionMethod (1 time me 2 user Singup kr rhaan han to 1 by 1 account create ho ga)</li>
                    <li>Add some Method in Constroctor</li>
                    <li>Add Code => for  Createing User</li>
                    <li>Add => Layout Code ===> (Toggle b/w  login / Logout)</li>
                    <li>Add => Logout Method ===> To Logout</li>
                </ol>
            <br />
            <h3 class=""text-primary"">____ 2. SignIn ____</h3>
            
                <ol>
                    <li>Add (Model) / (View) for SignIn Check</li>
                    <li>add Login Code On Post of SingIn Model</li>
                </ol>");
            WriteLiteral(@"
            

            <br /><br />
            <h1>2. Authorization</h1>

            <table class=""table justify-content-center"">
                <thead>
                    <tr>
                        <th>Authentication</th>
                        <th>Authorization</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Identitying Who the user is</td>
                        <td>What User Can do after authentic</td>
                    </tr>
                </tbody>
            </table>

            <h3>Types of Authorization</h3>
            <h3 class=""text-danger"">1. Action Level</h3>
            
                <ol>
                    <li>add [Authorize] attribute => on Action</li>
                </ol>
            

            <br /><br />
            <h3 class=""text-danger"">2. Controller Level</h3>
            
                <ol>
                    <li>add [Authorize] attribute =>");
            WriteLiteral(@" on Controller</li>
                    <li>add [AllowAnonymousli] attr ==> on Action => which want to show></li>
                </ol>
            


            <br /><br />
            <h3 class=""text-danger"">3. Globle Level</h3>
            
                <ol>
                    <li>add </li>
                    <li>add [AllowAnonymousli] attr ==> on Action => which want to show></li>
                </ol>
            

        </div>

");
            WriteLiteral(@"        <div class=""col-sm-6"">
           <h1>3. Customizing IdenittyUsers</h1>
           <ol>
               <li>Add Custom Column in ---> IdentityUser Table </li>
               <li>Create New Model ==> Inharite With  (IdentityUser)</li>
               <li>Find All References  of (IdentityUser) --> Replace with ==> ApplicationUser</li>
               <li>Add Properties / Desired Columns</li>
               <li>Add ApplicationUser Model ===> in  IdentityUser Generic </li>
               <li>Add migration --> Update-database </li>
               <li>Add Same Properteis --> Signup --> [Model] [View] </li>
           </ol>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
