using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using sunamo.Constants;

namespace GettingStartedCS

    class Program
    {
        
        static void Main(String[] args)
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(
@"using System;
using System.Collections;
using System.Linq;
using System.Text; 

namespace HelloWorld
{
    class Program
    {
           protected global::System.Web.UI.HtmlControls.HtmlInputHidden hfMode;

        static void Main(String[] args)
        {
            Console.WriteLine(""Hello, World!"");
        }
    }
}");
            List<string> usings;
            GetVariablesInCsharp(tree, out usings);



            //var childNodes = programDeclaration.ChildNodes();
            //var members = programDeclaration.Members;

            //foreach (var item in members)
            //{
            //    item.
            //}

            //foreach (var item in childNodes)
            //{

            //    if (item is VariableDeclarationSyntax)
            //    {

            //        //decla - ident node text
            //        Debug.WriteLine(((VariableDeclarationSyntax)item).ToString());
            //    }
            //}

            Console.ReadLine();
        }

        public static Dictionary<string, string> GetVariablesInCsharp(SyntaxTree tree, out List<string> usings)
        {
            usings = new List<string>();
            Dictionary<string, string> result = new Dictionary<string, string>();
            var root = (CompilationUnitSyntax)tree.GetRoot();

            var firstMember = root.Members[0];

            var helloWorldDeclaration = (NamespaceDeclarationSyntax)firstMember;

            var programDeclaration = (ClassDeclarationSyntax)helloWorldDeclaration.Members[0];

            var variableDeclarations = programDeclaration.DescendantNodes().OfType<FieldDeclarationSyntax>();

            foreach (var variableDeclaration in variableDeclarations)
            {
                //Console.WriteLine(variableDeclaration.Variables.First().Identifier.);
                //Console.WriteLine(variableDeclaration.Variables.First().Identifier.Value);
                string variableName = variableDeclaration.Declaration.Type.ToString();
                variableName = SH.ReplaceOnce(variableName, "global::", "");
                int lastIndex = variableName.LastIndexOf(AllChars.dot);
                string ns, cn;
                SH.GetPartsByLocation(out ns, out cn, variableName, lastIndex);
                usings.Add(ns);
                result.Add(cn, variableDeclaration.Declaration.Variables.First().Identifier.Text);
                
            }

            return result;
        }
    }
}