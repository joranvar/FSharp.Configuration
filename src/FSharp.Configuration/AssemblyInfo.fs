﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Configuration")>]
[<assembly: AssemblyProductAttribute("FSharp.Configuration")>]
[<assembly: AssemblyDescriptionAttribute("The FSharp.Configuration project contains type providers for the configuration of .NET projects.")>]
[<assembly: AssemblyVersionAttribute("0.5.9")>]
[<assembly: AssemblyFileVersionAttribute("0.5.9")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.5.9"
