using System;

[AttributeUsage(AttributeTargets.Method)]
public class PublicAPIAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Method)]
public class RequiresAuthAttribute : Attribute { }