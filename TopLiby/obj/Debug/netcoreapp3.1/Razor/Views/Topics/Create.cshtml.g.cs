#pragma checksum "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d5b62890a75008683f755dfca81609e2858d10d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_Create), @"mvc.1.0.view", @"/Views/Topics/Create.cshtml")]
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
#line 1 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\_ViewImports.cshtml"
using TopLiby;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\_ViewImports.cshtml"
using TopLiby.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d5b62890a75008683f755dfca81609e2858d10d", @"/Views/Topics/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b541975988bfca80807e315f8d49b76695e8f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Topics_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLiby.Models.Topic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        <hr />\r\n        ");
#nullable restore
#line 13 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 17 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
       Write(Html.LabelFor(x => x.Title, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.ValidationMessageFor(x => x.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 24 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
       Write(Html.LabelFor(x => x.Description, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 26 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.ValidationMessageFor(x => x.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
       Write(Html.LabelFor(x => x.EstimatedTimeToMaster, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 33 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.TextBoxFor(x => x.EstimatedTimeToMaster, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.ValidationMessageFor(x => x.EstimatedTimeToMaster, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 38 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
       Write(Html.LabelFor(x => x.TimeSpent, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.TextBoxFor(x => x.TimeSpent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.ValidationMessageFor(x => x.TimeSpent, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 44 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.LabelFor(x => x.SourceOf, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.TextBoxFor(x => x.SourceOf, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 47 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.SourceOf, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 51 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.LabelFor(x => x.StartLearningDate, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.TextBoxFor(x => x.StartLearningDate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.StartLearningDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 58 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.LabelFor(x => x.InProgress, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.TextBoxFor(x => x.InProgress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 61 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.InProgress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 65 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
           Write(Html.LabelFor(x => x.CompletionDate, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.TextBoxFor(x => x.CompletionDate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 68 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.CompletionDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 78 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 80 "C:\Users\35840\source\repos\Viikko11\TopLiby\TopLiby\Views\Topics\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLiby.Models.Topic> Html { get; private set; }
    }
}
#pragma warning restore 1591
