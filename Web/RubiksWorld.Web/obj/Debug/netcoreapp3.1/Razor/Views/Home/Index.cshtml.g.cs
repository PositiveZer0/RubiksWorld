#pragma checksum "C:\Users\azsum\Desktop\ASP.NET\RubiksWorldv2\Web\RubiksWorld.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82bb5d228cb68239a364b4ea65328671ebe4d537"
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
#line 1 "C:\Users\azsum\Desktop\ASP.NET\RubiksWorldv2\Web\RubiksWorld.Web\Views\_ViewImports.cshtml"
using RubiksWorld.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azsum\Desktop\ASP.NET\RubiksWorldv2\Web\RubiksWorld.Web\Views\_ViewImports.cshtml"
using RubiksWorld.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\azsum\Desktop\ASP.NET\RubiksWorldv2\Web\RubiksWorld.Web\Views\Home\Index.cshtml"
using RubiksWorld.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82bb5d228cb68239a364b4ea65328671ebe4d537", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d71e1662b9eb7ee5e64691081ee43e5ea70855a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stopwatch.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\azsum\Desktop\ASP.NET\RubiksWorldv2\Web\RubiksWorld.Web\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Rubik's World";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82bb5d228cb68239a364b4ea65328671ebe4d5374883", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82bb5d228cb68239a364b4ea65328671ebe4d5376107", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Gold Stopwatch</title>
    <link rel=""stylesheet"" href=""style.css"" />
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@200;900&display=swap""
          rel=""stylesheet"" />
    <link href=""https://fonts.googleapis.com/css2?family=Roboto+Mono:ital,wght@0,300;1,300&display=swap""
          rel=""stylesheet"" />
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82bb5d228cb68239a364b4ea65328671ebe4d5377549", async() => {
                WriteLiteral("\r\n    <div class=\"stopwatch\">\r\n        <h1><span class=\"gold\">CUBE</span> TIMER</h1>\r\n        <div><h4 id=\"scramble\" class=\"my-2\"></h4></div>\r\n        <div>\r\n            <span class=\"time\" id=\"display\">00:00:00</span>\r\n        </div>\r\n");
                WriteLiteral("    </div>\r\n    <span class=\"time\" id=\"lastTime\" display=\"block\"></span>\r\n    <script src=\"script.js\"></script>\r\n");
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
            WriteLiteral(@"
</html>

<script>
    window.onload = function () {
        this.makeScramble()
    }
    let isStarted = false;
    document.onkeyup = function (evt) {
        evt = evt || window.event;
        if (evt.keyCode == 32 && isStarted == false) {
            isStarted = true;
            reset();
            start();
        }
        else if (evt.keyCode == 32 && isStarted == true) {
            isStarted = false;
            pause();
            makeScramble();
        }
    };

    function timeToString(time) {
        let diffInHrs = time / 3600000;
        let hh = Math.floor(diffInHrs);

        let diffInMin = (diffInHrs - hh) * 60;
        let mm = Math.floor(diffInMin);

        let diffInSec = (diffInMin - mm) * 60;
        let ss = Math.floor(diffInSec);

        let diffInMs = (diffInSec - ss) * 100;
        let ms = Math.floor(diffInMs);

        let formattedMM = mm.toString().padStart(2, ""0"");
        let formattedSS = ss.toString().padStart(2, ""0"");
        le");
            WriteLiteral(@"t formattedMS = ms.toString().padStart(2, ""0"");

        return `${formattedMM}:${formattedSS}:${formattedMS}`;
    }

    // Declare variables to use in our functions below

    let startTime;
    let elapsedTime = 0;
    let timerInterval;

    // Create function to modify innerHTML

    function print(txt) {
        document.getElementById(""display"").innerHTML = txt;
    }

    function printScramble(txt) {
        document.getElementById(""scramble"").innerHTML = txt;
    }

    // Create ""start"", ""pause"" and ""reset"" functions

    function start() {
        startTime = Date.now() - elapsedTime;
        timerInterval = setInterval(function printTime() {
            elapsedTime = Date.now() - startTime;
            print(timeToString(elapsedTime));
        }, 10);
        //showButton(""PAUSE"");
    }

    function pause() {
        clearInterval(timerInterval);
        displayLastTime();
        //showButton(""PLAY"");
    }

    function reset() {
        clearInterval(t");
            WriteLiteral(@"imerInterval);
        print(""00:00:00"");
        elapsedTime = 0;
       // showButton(""PLAY"");
    }
    
    // Create function to display buttons

    //function showButton(buttonKey) {
    //    const buttonToShow = buttonKey === ""PLAY"" ? playButton : pauseButton;
    //    const buttonToHide = buttonKey === ""PLAY"" ? pauseButton : playButton;
    //    buttonToShow.style.display = ""block"";
    //    buttonToHide.style.display = ""none"";
    //}
    // Create event listeners

    //let playButton = document.getElementById(""playButton"");
    //let pauseButton = document.getElementById(""pauseButton"");
    //let resetButton = document.getElementById(""resetButton"");

    //playButton.addEventListener(""click"", start);
    //pauseButton.addEventListener(""click"", pause);
    //resetButton.addEventListener(""click"", reset);


    //Create scramble

    function displayLastTime() {
        let lastTimeElement = document.getElementById(""display"").innerHTML;
        let displayElement = do");
            WriteLiteral(@"cument.getElementById(""lastTime"");
        let div = document.createElement(""div"");
        div.innerHTML = lastTimeElement;
        //div.classList.add(""lastTime"");
        displayElement = div;
        
    }

    function makeScramble() {
        var options = [""F"", ""F2"", ""F'"", ""R"", ""R2"", ""R'"", ""U"", ""U2"", ""U'"", ""B"", ""B2"", ""B'"", ""L"", ""L2"", ""L'"", ""D"", ""D2"", ""D'""]
        var numOptions = [0, 1, 2, 3, 4, 5] // 0 = F, 1 = R, 2 = U, 3 = B, 4 = L, 5 = D
        var scramble = []
        var scrambleMoves = []
        var bad = true

        while (bad) {
            scramble = []
            for (var i = 0; i < 20; i++) {
                scramble.push(numOptions[getRandomInt(6)])
            }
            // check if moves directly next to each other involve the same letter
            for (var i = 0; i < 20 - 1; i++) {
                if (scramble[i] == scramble[i + 1]) {
                    bad = true
                    break
                } else {
                    bad = false
");
            WriteLiteral(@"                }
            }
        }
        //console.log(scramble)
        // switch numbers to letters
        var move
        for (var i = 0; i < 20; i++) {
            switch (scramble[i]) {
                case 0:
                    move = options[getRandomInt(3)] // 0,1,2
                    scrambleMoves.push(move)
                    break
                case 1:
                    move = options[getRandomIntBetween(3, 6)] // 3,4,5
                    scrambleMoves.push(move)
                    break
                case 2:
                    move = options[getRandomIntBetween(6, 9)] // 6,7,8
                    scrambleMoves.push(move)
                    break
                case 3:
                    move = options[getRandomIntBetween(9, 12)] // 9,10,11
                    scrambleMoves.push(move)
                    break
                case 4:
                    move = options[getRandomIntBetween(12, 15)] // 12,13,14
                    scrambleMoves.push(");
            WriteLiteral(@"move)
                    break
                case 5:
                    move = options[getRandomIntBetween(15, 18)] // 15,16,17
                    scrambleMoves.push(move)
                    break
            }
        }
        printScramble(scrambleMoves.join(' '))
        console.log(scrambleMoves)
    }

    function getRandomInt(max) {
        return Math.floor(Math.random() * Math.floor(max)) // returns up to max - 1
    }

    function getRandomIntBetween(min, max) { // return a number from min to max - 1. Ex. 3, 9 returns 3 - 8
        return Math.floor(Math.random() * (max - min) + min)
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
