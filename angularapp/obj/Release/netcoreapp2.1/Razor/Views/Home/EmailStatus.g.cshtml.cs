#pragma checksum "C:\Users\jean\Documents\Visual Studio 2017\Projects\angularapp\Views\Home\EmailStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa7492c6238669cb97ecd90e49d39a32ed3c3905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmailStatus), @"mvc.1.0.view", @"/Views/Home/EmailStatus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EmailStatus.cshtml", typeof(AspNetCore.Views_Home_EmailStatus))]
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
#line 1 "C:\Users\jean\Documents\Visual Studio 2017\Projects\angularapp\Views\_ViewImports.cshtml"
using angularapp;

#line default
#line hidden
#line 2 "C:\Users\jean\Documents\Visual Studio 2017\Projects\angularapp\Views\_ViewImports.cshtml"
using angularapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7492c6238669cb97ecd90e49d39a32ed3c3905", @"/Views/Home/EmailStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cbf3a93a6f23bc7e28d929875d022a4e7eb8e61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmailStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-app", new global::Microsoft.AspNetCore.Html.HtmlString("myApp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("emailSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\jean\Documents\Visual Studio 2017\Projects\angularapp\Views\Home\EmailStatus.cshtml"
  
    ViewData["Title"] = "Email Status";

#line default
#line hidden
            BeginContext(48, 17, true);
            WriteLiteral("<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(65, 5385, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8fb2d68611e44c9b6ed5617db5b0eb1", async() => {
                BeginContext(114, 5329, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label for=""form_startDate"">Start Date</label>
                <input id=""form_startDate"" type=""datetime-local"" name=""startDate"" ng-model=""startDate"" class=""form-control""
                       required=""required"" data-error=""Start Date is required."">
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label for=""form_endDate"">End Date</label>
                <input id=""form_endDate"" type=""datetime-local"" name=""endDate"" ng-model=""endDate"" class=""form-control""
                       required=""required"" data-error=""End date is required is required."">
                <div class=""help-block with-errors""></div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""form-group"">
                <l");
                WriteLiteral(@"abel for=""form_email"">Address</label>
                <input id=""form_email"" type=""email"" name=""ToEmail"" ng-model=""ToEmail"" class=""form-control""
                       required=""required"" data-error=""ToEmail is required."">
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label for=""form_subject"">Subject</label>
                <input id=""form_subject"" type=""text"" name=""subject"" ng-model=""subject"" class=""form-control""
                       required=""required"" data-error=""subject is required."">
                <div class=""help-block with-errors""></div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <button class=""btn btn-warning btn-send"" value=""Search"" ng-click=""search()"">Search</button>
        </div>
    </div>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
       ");
                WriteLiteral(@"         <th scope=""col"">Address</th>
                <th scope=""col"">Subject</th>
                <th scope=""col"">Message</th>
                <th scope=""col"">Status</th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat=""email in emailArray"">
                <td><label>{{email.toEmail}}</label></td>
                <td><label>{{email.subject}}</label></td>
                <td><label>{{email.message}}</label></td>
                <td><label>{{email.status}}</label></td>
            </tr>
        </tbody>
    </table>


    <script>
        var app = angular.module('myApp', []);


        app.controller('emailSearch', ['$scope', 'emailService', '$rootScope',
            function ($scope, emailService, $rootScope) {

                $scope.$on('eventFired', function (event, data) {
                    console.log(data.data.data);
                    $scope.emailArray = (data.data.data);
                    if ($scope.emailArray === undefined || $scope.email");
                WriteLiteral(@"Array.length == 0) {
                        alert('no data found');
                    }
                })

                $scope.search = function () {
                    $scope.emailArray = [];
                    
                    if ($scope.ToEmail === undefined) { $scope.ToEmail = ''; }
                    
                    if ($scope.subject === undefined) { $scope.subject = ''; }
                    console.log($scope.subject);
                    console.log($scope.startDate);
                    console.log($scope.endDate);
                        $scope.emailInfo = {
                            ToEmail: $scope.ToEmail,
                            StartDate: $scope.startDate,
                            EndDate: $scope.endDate,
                            Subject: $scope.subject
                    };
                    if ($scope.endDate === undefined) { $scope.emailInfo.EndDate = null; } else { $scope.emailInfo.EndDate = ($scope.endDate).toJSON(); };
               ");
                WriteLiteral(@"     if ($scope.startDate === undefined) { $scope.emailInfo.StartDate = null; } else { $scope.emailInfo.StartDate = ($scope.startDate).toJSON(); };
                        emailService.saveResultService($scope.emailInfo);
                }
            }]);

        app.service('emailService', ['$http', '$rootScope', function ($http, $rootScope) {
            this.saveResultService = function (emailInfo) {
                console.log(emailInfo);
                $http({
                    method: 'GET',
                    url: 'https://emailsenderappjean.azurewebsites.net/Email/EmailSearch?' + 'StartDate=' + emailInfo.StartDate + '&EndDate=' + emailInfo.EndDate + '&ToEmail=' + emailInfo.ToEmail + '&Subject=' + emailInfo.Subject
                })
                    .then(function successCallback(response) {
                        $rootScope.$broadcast('eventFired', {
                            data: response
                        });
                    }, function errorCallback(response)");
                WriteLiteral(" {\r\n                        $rootScope.$broadcast(\'eventFired\', {\r\n                            data: response\r\n                        });\r\n                    });\r\n            }\r\n        }]);\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5450, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
