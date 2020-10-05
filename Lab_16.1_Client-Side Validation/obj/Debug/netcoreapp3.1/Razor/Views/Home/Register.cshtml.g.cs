#pragma checksum "C:\devbuild4\DOM  JAVA\Lab_16.1_Client-Side Validation\Lab_16.1_Client-Side Validation\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "febdd124fd787ab1a9e42cc325c4389892d6c27a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "C:\devbuild4\DOM  JAVA\Lab_16.1_Client-Side Validation\Lab_16.1_Client-Side Validation\Views\_ViewImports.cshtml"
using Lab_16._1_Client_Side_Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\DOM  JAVA\Lab_16.1_Client-Side Validation\Lab_16.1_Client-Side Validation\Views\_ViewImports.cshtml"
using Lab_16._1_Client_Side_Validation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febdd124fd787ab1a9e42cc325c4389892d6c27a", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbeacf5c50998f9120f259a1020354ef0783d23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/result"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return submitForm()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\devbuild4\DOM  JAVA\Lab_16.1_Client-Side Validation\Lab_16.1_Client-Side Validation\Views\Home\Register.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febdd124fd787ab1a9e42cc325c4389892d6c27a4945", async() => {
                WriteLiteral(@"

    <style>
        .redtextcolor
        {
            color:orangered;
        }

    </style>
    <script>


        function submitForm() {
            let first = document.getElementById('FirstNameElement');
            let last = document.getElementById('LastNameElement');
            let email = document.getElementById('EmailElement');
            let password = document.getElementById('PasswordElement');
            let passwordConfirm = document.getElementById('PasswordConfirmElement');

            var RegPass = (/^(?=.*[0-9])(?=.*[!#$%^&*])[a-zA-Z0-9!#$%^&*]{6,16}$/);
            var RegEmail = /\S+\S+\.\S+/;


            let firstContinue = false;
            let lastContinue = false;
            let emailContinue = false;
            let passContinue = false;
            let passConfirmContinue = false;

            if (first.value.length < 2) {  //FIRSTNAME
                //alert('First Name not long enough');

                document.getElementById(""invalidF");
                WriteLiteral(@"irstName"").style.visibility = ""visible"";
                return false;
            }
            else {
                firstContinue = true;
            }

            if (last.value.length < 2) { //LASTNAME
                document.getElementById(""invalidLastName"").style.visibility = ""visible"";
                return false;
            }
            else {
                lastContinue = true;
            }

            if (!RegEmail.test(email.value)) {
                document.getElementById(""invalidEmail"").style.visibility = ""visible"";
                return false;
            }
            else {
                emailContinue = true;
            }

            if (!RegPass.test(password.value)) {
                document.getElementById(""invalidPassword"").style.visibility = ""visible"";
                return false;
            }
            else {
                passContinue = true;
            }


            if (password.value != passwordConfirm.value) { //Confirm Passwor");
                WriteLiteral(@"d Matches
                document.getElementById(""invalidPassConfirm"").style.visibility = ""visible"";
                return false;
            }
            else {
                passConfirmContinue = true;
            }

            if (firstContinue == true && lastContinue == true && passContinue == true && emai == true && passConfirmContinue == true) {
                return true;
            }
            else {
                return false;
            }

        }

    </script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febdd124fd787ab1a9e42cc325c4389892d6c27a7854", async() => {
                    WriteLiteral("\r\n        <div>\r\n            <h2>Please Register:</h2><br /><br />\r\n        </div>\r\n\r\n        <div>\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febdd124fd787ab1a9e42cc325c4389892d6c27a8241", async() => {
                        WriteLiteral(@"

                <label for=FirstName style=""display:block""> <b>First Name:</b></label>
                <div id=""invalidFirstName"" style=""visibility:hidden"" class=""redtextcolor"">First Name must be 2 characters of longer.</div>
                <input type=""text"" name=""FirstName"" id=""FirstNameElement"" /><br /><br />

                <label for=LastName style=""display:block""> <b>Last Name:</b></label>
                <div id=""invalidLastName"" style=""visibility:hidden"" class=""redtextcolor"">Last Name must be 2 characters of longer.</div>
                <input type=""text"" name=""LastName"" id=""LastNameElement"" /><br /><br />

                <label for=Email style=""display:block""> <b>Email Address:</b></label>
                <div id=""invalidEmail"" style=""visibility:hidden"" class=""redtextcolor"">Not a valid Email Address.</div>
                <input type=""email"" name=""Email"" id=""EmailElement"" /><br /><br />

                <label for=Password style=""display:block""> <b>Password:</b></label>
         ");
                        WriteLiteral(@"       <div id=""invalidPassword"" style=""visibility:hidden"" class=""redtextcolor"">Not a valid Password. <b>**6-16 characters in total. 1 Uppercase 1 Lowercase 1 Number 1 Symbol Required**</b>.</div>
                <input type=""password"" name=""Password"" id=""PasswordElement"" /><br /><br />

                <label for=PasswordConfirm style=""display:block""> <b>Confirm Password:</b></label>
                <div id=""invalidPassConfirm"" style=""visibility:hidden"" class=""redtextcolor"">Passwords must match.</div>
                <input type=""password"" name=""PasswordConfirm"" id=""PasswordConfirmElement"" /><br /><br />

                <input type=""submit"" value=""Submit"" />
            ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        </div>\r\n        \r\n\r\n\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
