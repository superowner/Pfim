﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Pfim.Bench")>]
[<assembly: AssemblyProductAttribute("Pfim")>]
[<assembly: AssemblyDescriptionAttribute("Image file format parser")>]
[<assembly: AssemblyVersionAttribute("0.3")>]
[<assembly: AssemblyFileVersionAttribute("0.3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3"
