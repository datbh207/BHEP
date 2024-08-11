﻿using System.Reflection;
using MassTransit;

namespace BHEP.Infrastructure.RabbitMQ.DependencyInjection.Extensions;

public static class NameFormatterExtensions
{
    public static string ToKebabCaseString(this MemberInfo member)
        => KebabCaseEndpointNameFormatter.Instance.SanitizeName(member.Name);
}

public class KebabCaseEntityNameFormatter : IEntityNameFormatter
{
    public string FormatEntityName<T>()
        => typeof(T).ToKebabCaseString();
}
