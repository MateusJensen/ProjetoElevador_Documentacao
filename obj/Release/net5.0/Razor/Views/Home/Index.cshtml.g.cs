#pragma checksum "C:\Users\mateu\Documents\GitHub\ProjetoElevador_Documentacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0536ee8b678ec98c5289bb20978da05ec4ea5af6"
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
#line 1 "C:\Users\mateu\Documents\GitHub\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mateu\Documents\GitHub\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0536ee8b678ec98c5289bb20978da05ec4ea5af6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4923143fe3bec400c1f93c72fde12f2bac68e920", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mateu\Documents\GitHub\ProjetoElevador_Documentacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Elevador";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""icon"" href=""./wwwroot/favicon.ico""/>

<div class=""presentation"">
    <h2>Segue abaixo o funcionamento do elevador desenvolvido!</h2>
</div>
<br></br>
<div>
  <h4>Desenvolvido totalmente com a linguagem de programação C#.</h4>
  <h4>O elevador tem as seguintes funções em sua composição: </h4>
  <br></br>
   <ol class=""list"">
     <li>Subir 1 andar</li>
     <li>Descer 1 andar</li>
     <li>Adicionar 1 pessoa ao elevador</li>
     <li>Remover 1 pessoa do elevador</li>
     <li>Parar elevador e sair</li>
   </ol>
   <br></br>
   <h4>Todas as funções são executadas um de cada vez, ou seja, a cada função executada é solicitado que o usúario informe ao programa qual será sua próxima ação/função execuando-as uma de cada vez.</h4>
</div>
");
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
