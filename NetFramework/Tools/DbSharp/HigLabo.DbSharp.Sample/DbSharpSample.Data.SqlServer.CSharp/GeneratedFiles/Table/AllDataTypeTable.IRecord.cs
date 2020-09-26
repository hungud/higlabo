﻿using System;
using System.Data;
using System.Text;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class AllDataTypeTable
    {
        public interface IRecord
        {
            Int64 PrimaryKeyColumn { get; set; }
            Byte[] TimestampColumn { get; set; }
            Int64? BigIntColumn { get; set; }
            Byte[] BinaryColumn { get; set; }
            Byte[] ImageColumn { get; set; }
            Byte[] VarBinaryColumn { get; set; }
            Boolean? BitColumn { get; set; }
            String CharColumn { get; set; }
            String NCharColumn { get; set; }
            String NTextColumn { get; set; }
            String NVarCharColumn { get; set; }
            String TextColumn { get; set; }
            String VarCharColumn { get; set; }
            String XmlColumn { get; set; }
            DateTime? DateTimeColumn { get; set; }
            DateTime? SmallDateTimeColumn { get; set; }
            DateTime? DateColumn { get; set; }
            TimeSpan? TimeColumn { get; set; }
            DateTime? DateTime2Column { get; set; }
            Decimal? DecimalColumn { get; set; }
            Decimal? MoneyColumn { get; set; }
            Decimal? SmallMoneyColumn { get; set; }
            Double? FloatColumn { get; set; }
            Int32? IntColumn { get; set; }
            Single? RealColumn { get; set; }
            Guid? UniqueIdentifierColumn { get; set; }
            Int16? SmallIntColumn { get; set; }
            Byte? TinyIntColumn { get; set; }
            DateTimeOffset? DateTimeOffsetColumn { get; set; }
            Object SqlVariantColumn { get; set; }
            global::Microsoft.SqlServer.Types.SqlGeometry GeometryColumn { get; set; }
            global::Microsoft.SqlServer.Types.SqlGeography GeographyColumn { get; set; }
            global::Microsoft.SqlServer.Types.SqlHierarchyId? HierarchyIDColumn { get; set; }
            MyEnum? EnumColumn { get; set; }
            Int64 NotNullBigIntColumn { get; set; }
            Byte[] NotNullBinaryColumn { get; set; }
            Byte[] NotNullImageColumn { get; set; }
            Byte[] NotNullVarBinaryColumn { get; set; }
            Boolean NotNullBitColumn { get; set; }
            String NotNullCharColumn { get; set; }
            String NotNullNCharColumn { get; set; }
            String NotNullNTextColumn { get; set; }
            String NotNullNVarCharColumn { get; set; }
            String NotNullTextColumn { get; set; }
            String NotNullVarCharColumn { get; set; }
            String NotNullXmlColumn { get; set; }
            DateTime NotNullDateTimeColumn { get; set; }
            DateTime NotNullSmallDateTimeColumn { get; set; }
            DateTime NotNullDateColumn { get; set; }
            TimeSpan NotNullTimeColumn { get; set; }
            DateTime NotNullDateTime2Column { get; set; }
            Decimal NotNullDecimalColumn { get; set; }
            Decimal NotNullMoneyColumn { get; set; }
            Decimal NotNullSmallMoneyColumn { get; set; }
            Double NotNullFloatColumn { get; set; }
            Int32 NotNullIntColumn { get; set; }
            Single NotNullRealColumn { get; set; }
            Guid NotNullUniqueIdentifierColumn { get; set; }
            Int16 NotNullSmallIntColumn { get; set; }
            Byte NotNullTinyIntColumn { get; set; }
            DateTimeOffset NotNullDateTimeOffsetColumn { get; set; }
            Object NotNullSqlVariantColumn { get; set; }
            global::Microsoft.SqlServer.Types.SqlGeometry NotNullGeometryColumn { get; set; }
            global::Microsoft.SqlServer.Types.SqlGeography NotNullGeographyColumn { get; set; }
            global::Microsoft.SqlServer.Types.SqlHierarchyId NotNullHierarchyIDColumn { get; set; }
            MyEnum NotNullEnumColumn { get; set; }
        }
    }
}
