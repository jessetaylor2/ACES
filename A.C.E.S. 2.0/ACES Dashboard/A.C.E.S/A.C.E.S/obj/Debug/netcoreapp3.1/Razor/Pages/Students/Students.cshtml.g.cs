#pragma checksum "D:\Documents\_School\2020_1_Spring\CS 4450 Software\A.C.E.S\A.C.E.S. 2.0\ACES Dashboard\A.C.E.S\A.C.E.S\Pages\Students\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f87acc48b5526938dd3575f30d338af534366e82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(A.C.E.S.Pages.Students.Pages_Students_Students), @"mvc.1.0.razor-page", @"/Pages/Students/Students.cshtml")]
namespace A.C.E.S.Pages.Students
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
#line 1 "D:\Documents\_School\2020_1_Spring\CS 4450 Software\A.C.E.S\A.C.E.S. 2.0\ACES Dashboard\A.C.E.S\A.C.E.S\Pages\_ViewImports.cshtml"
using A.C.E.S;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Students")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f87acc48b5526938dd3575f30d338af534366e82", @"/Pages/Students/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe3f33a1bbfb825705ae137818486ffb09d4dab", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_Students : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Students/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Documents\_School\2020_1_Spring\CS 4450 Software\A.C.E.S\A.C.E.S. 2.0\ACES Dashboard\A.C.E.S\A.C.E.S\Pages\Students\Students.cshtml"
  
    ViewData["Title"] = "Students";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"top-bar\">\r\n    <div>\r\n        <input id=\"filter-student-name\" type=\"text\" placeholder=\"Search Student\" onkeyup=\"LoadList()\" />\r\n        <select id=\"filter-student-standing\" onchange=\"LoadList()\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87acc48b5526938dd3575f30d338af534366e824279", async() => {
                WriteLiteral("All Standing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87acc48b5526938dd3575f30d338af534366e825255", async() => {
                WriteLiteral("Good Standing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87acc48b5526938dd3575f30d338af534366e826232", async() => {
                WriteLiteral("Moderate Standing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87acc48b5526938dd3575f30d338af534366e827213", async() => {
                WriteLiteral("Bad Standing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </select>\r\n        <select id=\"filter-student-status\" onchange=\"LoadList()\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87acc48b5526938dd3575f30d338af534366e828283", async() => {
                WriteLiteral("Active");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87acc48b5526938dd3575f30d338af534366e829253", async() => {
                WriteLiteral("Archived");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
    </div>
    <div>
        <a class=""button"" onclick=""$('.pop-up').animate({ width: 'toggle' });"">+ Add Student</a>
    </div>
</section>
<section>
    <table id=""student-table"">
        <thead>
            <tr>
                <td>Name</td>
                <td>Email</td>
                <td>Standing</td>
            </tr>
        </thead>
        <tbody id=""student-list"">
        </tbody>
    </table>
</section>
<aside class=""pop-up"">
    <h2>Add Student</h2>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87acc48b5526938dd3575f30d338af534366e8210732", async() => {
                WriteLiteral(@"
        <div><label for=""name"">Name:</label></div>
        <div><input id=""name"" name=""name"" type=""text"" /></div>
        <div><label for=""email"">Email:</label></div>
        <div><input id=""email"" name=""email"" type=""email"" /></div>
        <p>
            <input type=""submit"" value=""Add"" />
            <input type=""button"" value=""Cancel"" onclick=""$('.pop-up').animate({ width: 'toggle' });"" />
        </p>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</aside>
<script>
    function LoadList() {
        var name = document.getElementById('filter-student-name').value;
        var standing = document.getElementById('filter-student-standing').selectedIndex;
        var status = document.getElementById('filter-student-status').value;

        var elem = document.getElementById('student-list');
        elem.innerHTML = """";

        var students = JSON.parse('");
#nullable restore
#line 60 "D:\Documents\_School\2020_1_Spring\CS 4450 Software\A.C.E.S\A.C.E.S. 2.0\ACES Dashboard\A.C.E.S\A.C.E.S\Pages\Students\Students.cshtml"
                              Write(Json.Serialize(Model.students));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        if (students.length == 0) {
            elem.innerHTML += '<tr><td colspan=""4""><center>No Result.</center></td></tr>';
        }

        for (var student of students) {
            if (student.archived && status == ""Active"") continue;
            if (!student.archived && status == ""Archived"") continue;
            if (!student.name.toLowerCase().includes(name.toLowerCase())) continue;
            if (standing != 0 && student.standing != standing - 1) continue;

            var tr = document.createElement(""tr"");
            tr.innerHTML += '<td><a href=""/Students/' + student.id + '"">' + student.name + '</a></td>';
            tr.innerHTML += '<td>' + student.email + '</td>';
            switch (student.standing) {
                case 0:
                    tr.innerHTML += '<td><i class=""green-text fas fa-star""></i><i class=""green-text fas fa-star""></i><i class=""green-text fas fa-star""></i> Good</td>';
                    break;
                case 1:
                    tr.inn");
            WriteLiteral(@"erHTML += '<td><i class=""orange-text fas fa-star""></i><i class=""orange-text fas fa-star""></i><i class=""far fa-star""></i> Moderate</td>';
                    break;
                case 2:
                    tr.innerHTML += '<td><i class=""red-text fas fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i> Bad</td>';
                    break;
                default:
                    tr.innerHTML += '<td><i class=""far fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i> N/A</td>';
                    break;
            }
            elem.appendChild(tr);
        }
    }

    LoadList();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<A.C.E.S.Pages.Students.StudentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<A.C.E.S.Pages.Students.StudentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<A.C.E.S.Pages.Students.StudentsModel>)PageContext?.ViewData;
        public A.C.E.S.Pages.Students.StudentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
