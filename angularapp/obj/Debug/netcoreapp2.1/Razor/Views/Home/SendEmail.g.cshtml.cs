#pragma checksum "C:\Users\jean\Documents\Visual Studio 2017\Projects\angularapp\Views\Home\SendEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5364beea75756f650c961c8929d4075d7542e1f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SendEmail), @"mvc.1.0.view", @"/Views/Home/SendEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SendEmail.cshtml", typeof(AspNetCore.Views_Home_SendEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5364beea75756f650c961c8929d4075d7542e1f7", @"/Views/Home/SendEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cbf3a93a6f23bc7e28d929875d022a4e7eb8e61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SendEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(0, 21, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n\r\n");
            EndContext();
            BeginContext(21, 3992, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4067df269e84513b51aeacfbab9df07", async() => {
                BeginContext(27, 3979, true);
                WriteLiteral(@"
    <h2> Send an email</h2>
    <div ng-app=""myApp"" ng-controller=""emailSendCtrl""
          name=""myForm"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <label for=""form_email"">ToEmail</label>
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
            </div>");
                WriteLiteral(@"
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""form-group"">
                    <label for=""form_message"">Message</label>
                    <textarea id=""form_message"" name=""message"" class=""form-control"" rows=""4""
                              ng-model=""message"" required=""required"" data-error=""Please, enter a message to be sent""></textarea>
                    <div class=""help-block with-errors""></div>
                </div>
            </div>
            <div class=""col-md-12"">
                <button class=""btn btn-success btn-send"" value=""Send message"" ng-click=""saveResult()"">Send</button>
            </div>
        </div>
    </div>

    <script>
        var app = angular.module('myApp', []);


        app.controller('emailSendCtrl', ['$scope', 'emailService','$rootScope',
            function ($scope, emailService, $rootScope) {  

                $scope.$on('eventFired', function (event, data) {
                    cons");
                WriteLiteral(@"ole.log(data.data);
                    if (data.data === 'ok') { alert('email sent succesfully') } else { alert('email not sent') }
                })

                $scope.saveResult = function () {
                    if (($scope.ToEmail !== '' && $scope.ToEmail !== undefined) && ($scope.subject !== '' && $scope.subject !== undefined) && ($scope.message !== '' && $scope.message !== undefined)) {
                       
                            $scope.emailInfo = {
                                ToEmail: $scope.ToEmail,
                                Subject: $scope.subject,
                                Message: $scope.message
                            };
                            emailService.saveResultService($scope.emailInfo);
                        
                    }
                    else { alert('missing or wrong informartion') }
                }
                }]);

        app.service('emailService', ['$http', '$rootScope', function ($http, $rootScope) {
  ");
                WriteLiteral(@"          this.saveResultService = function (emailInfo) {
                console.log(emailInfo);    
                $http({
                    method: 'POST',
                    url: 'https://emailsenderappjean.azurewebsites.net/Email/SendMail',
                    data: JSON.stringify(emailInfo),
                    headers: {
                        'Content-Type': 'application/json'
                    }
                })
                    .then(function successCallback(response) {
                        $rootScope.$broadcast('eventFired', {
                            data: 'ok'
                        });   
                    }, function errorCallback(response) {
                        $rootScope.$broadcast('eventFired', {
                            data: 'bad'
                        });   
                    });
            }
        }]);
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(4013, 4, true);
            WriteLiteral("\r\n\r\n");
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
