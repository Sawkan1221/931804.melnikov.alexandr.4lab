#pragma checksum "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7401bdcd8acfbdb7e3f33e5bf0e1845e41836428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_Radio), @"mvc.1.0.view", @"/Views/Controls/Radio.cshtml")]
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
#line 1 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\_ViewImports.cshtml"
using Lab4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\_ViewImports.cshtml"
using Lab4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7401bdcd8acfbdb7e3f33e5bf0e1845e41836428", @"/Views/Controls/Radio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1dc5fb44c3021da35399707c52c994f788c9f72", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_Radio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-left\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7401bdcd8acfbdb7e3f33e5bf0e1845e418364283932", async() => {
                WriteLiteral("\n        <h1 class=\"display-4\">");
#nullable restore
#line 3 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n        <nobr>Text</nobr>\n        <br>\n        ");
#nullable restore
#line 6 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "January"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>January</span> <br />\n        ");
#nullable restore
#line 8 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "February"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>February</span> <br />\n        ");
#nullable restore
#line 10 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "March"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>March </span> <br />\n        ");
#nullable restore
#line 12 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "April"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>April </span> <br />\n        ");
#nullable restore
#line 14 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "May"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>May </span> <br />\n        ");
#nullable restore
#line 16 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "June"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>June </span> <br />\n        ");
#nullable restore
#line 18 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "July"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>July </span> <br />\n        ");
#nullable restore
#line 20 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "August"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>August </span> <br />\n        ");
#nullable restore
#line 22 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "September"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>September </span> <br />\n        ");
#nullable restore
#line 24 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "October"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>October  </span> <br />\n        ");
#nullable restore
#line 26 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "November"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>November </span> <br />\n        ");
#nullable restore
#line 28 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Controls\Radio.cshtml"
   Write(Html.RadioButton("Radio", "December"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>December  </span> <br />\n        <input type=\"submit\" value=\"Submit\" />\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
