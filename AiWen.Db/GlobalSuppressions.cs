﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

#if !NETSTANDARD1_4
#region

using System.Diagnostics.CodeAnalysis;

#endregion

[assembly: SuppressMessage("Style", "IDE0005:Using directive is unnecessary.", Justification = "<Pending>")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "AiWen",
        Scope = "member", Target = "AiWen.Db.Decoder.#CtrlData(System.Int64,System.Int32&,System.Int64&)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type",
        Target = "AiWen.Db.InvalidDatabaseException")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type",
        Target = "AiWen.Db.Metadata")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "AiWen.Db.Reader.#Find`1(System.Net.IPAddress,AiWen.Db.InjectableValues)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "AiWen.Db.ParameterAttribute.#.ctor(System.String,System.Boolean)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#", Scope = "member", Target = "AiWen.Db.Reader.#Find`1(System.Net.IPAddress,System.Int32&,AiWen.Db.InjectableValues)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "AiWen.Db.Reader.#Find`1(System.Net.IPAddress,System.Int32&,AiWen.Db.InjectableValues)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly")]
#endif
