#pragma checksum "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e5c4f722ace87092d20ea7d11aaec886ddc94ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operations__763ContainerLoadingPartial), @"mvc.1.0.view", @"/Views/Operations/_763ContainerLoadingPartial.cshtml")]
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
#line 1 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
using BMS.Models.LoadingInstructionInputModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e5c4f722ace87092d20ea7d11aaec886ddc94ff", @"/Views/Operations/_763ContainerLoadingPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Operations__763ContainerLoadingPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_763LoadingInstructionInputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Operations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "File763ContainerLoadingInstruction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5c4f722ace87092d20ea7d11aaec886ddc94ff4414", async() => {
                WriteLiteral("\r\n        <div class=\"form-row\">\r\n            <div class=\"input-group\">\r\n                <div class=\"input-group-prepend\">\r\n                    <span>Hold 1 Positions</span>\r\n                    <select class=\"selectpicker\">\r\n");
#nullable restore
#line 10 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                     for (int i = 1; i <= 4; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5c4f722ace87092d20ea7d11aaec886ddc94ff5234", async() => {
                    WriteLiteral("1");
#nullable restore
#line 12 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                              Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("L");
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
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>
       <div class=""form-row"">
           <div class=""input-group"">
               <div class=""input-group-prepend"">
                   <span>Hold 2 Positions</span>
                   <select class=""selectpicker"">
");
#nullable restore
#line 23 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                        for (int i = 1; i <= 4; i++)
                       {

#line default
#line hidden
#nullable disable
                WriteLiteral("                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5c4f722ace87092d20ea7d11aaec886ddc94ff7404", async() => {
                    WriteLiteral("2");
#nullable restore
#line 25 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                                 Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("L");
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
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                       }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                   </select>
               </div>
           </div>
       </div>
        <div class=""form-row"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span>Hold 3 Positions</span>
                    <select class=""selectpicker"">
");
#nullable restore
#line 36 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                      for (int i = 1; i <= 4; i++)
                     {

#line default
#line hidden
#nullable disable
                WriteLiteral("                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5c4f722ace87092d20ea7d11aaec886ddc94ff9575", async() => {
                    WriteLiteral("3");
#nullable restore
#line 38 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("L");
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
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>
        <div class=""form-row"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span>Hold 4 Positions</span>
                    <select class=""selectpicker"">
");
#nullable restore
#line 49 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                     for (int i = 1; i <= 3; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5c4f722ace87092d20ea7d11aaec886ddc94ff11743", async() => {
                    WriteLiteral("4");
#nullable restore
#line 51 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                              Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("L");
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
                WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Operations\_763ContainerLoadingPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <button class=\"btn btn-primary btn-block\">Create loading instruction</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_763LoadingInstructionInputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591