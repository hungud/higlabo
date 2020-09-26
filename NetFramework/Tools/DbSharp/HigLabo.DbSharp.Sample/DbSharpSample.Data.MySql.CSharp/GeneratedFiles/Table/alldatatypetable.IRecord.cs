﻿using System;
using System.Data;
using System.Text;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.MySql
{
    public partial class alldatatypetable
    {
        public interface IRecord
        {
            Int64 PrimaryKeyColumn { get; set; }
            DateTime TimestampColumn { get; set; }
            String CharColumn { get; set; }
            String VarCharColumn { get; set; }
            Boolean? BitColumn { get; set; }
            SByte? TinyIntColumn { get; set; }
            Int16? SmallIntColumn { get; set; }
            Int32? MediumIntColumn { get; set; }
            Int32? IntColumn { get; set; }
            Int64? BigIntColumn { get; set; }
            Byte? TinyIntUnsignedColumn { get; set; }
            UInt16? SmallIntUnsignedColumn { get; set; }
            UInt32? MediumIntUnsignedColumn { get; set; }
            UInt32? IntUnsignedColumn { get; set; }
            UInt64? BigIntUnsignedColumn { get; set; }
            Single? FloatColumn { get; set; }
            Double? DoubleColumn { get; set; }
            Decimal? DecimalColumn { get; set; }
            Decimal? NumericColumn { get; set; }
            DateTime? DateColumn { get; set; }
            DateTime? DateTimeColumn { get; set; }
            TimeSpan? TimeColumn { get; set; }
            Int32? YearColumn { get; set; }
            Byte[] BinaryColumn { get; set; }
            Byte[] VarBinaryColumn { get; set; }
            Byte[] TinyBlobColumn { get; set; }
            Byte[] MediumBlobColumn { get; set; }
            Byte[] BlobColumn { get; set; }
            Byte[] LongBlobColumn { get; set; }
            String TinyTextColumn { get; set; }
            String MediumTextColumn { get; set; }
            String TextColumn { get; set; }
            String LongTextColumn { get; set; }
            global::MySql.Data.Types.MySqlGeometry? GeometryColumn { get; set; }
            MyEnum? EnumColumn { get; set; }
            MySet? SetColumn { get; set; }
            String NotNullCharColumn { get; set; }
            String NotNullVarCharColumn { get; set; }
            Boolean NotNullBitColumn { get; set; }
            SByte NotNullTinyIntColumn { get; set; }
            Int16 NotNullSmallIntColumn { get; set; }
            Int32 NotNullMediumIntColumn { get; set; }
            Int32 NotNullIntColumn { get; set; }
            Int64 NotNullBigIntColumn { get; set; }
            Byte NotNullTinyIntUnsignedColumn { get; set; }
            UInt16 NotNullSmallIntUnsignedColumn { get; set; }
            UInt32 NotNullMediumIntUnsignedColumn { get; set; }
            UInt32 NotNullIntUnsignedColumn { get; set; }
            UInt64 NotNullBigIntUnsignedColumn { get; set; }
            Single NotNullFloatColumn { get; set; }
            Double NotNullDoubleColumn { get; set; }
            Decimal NotNullDecimalColumn { get; set; }
            Decimal NotNullNumericColumn { get; set; }
            DateTime NotNullDateColumn { get; set; }
            DateTime NotNullDateTimeColumn { get; set; }
            TimeSpan NotNullTimeColumn { get; set; }
            Int32 NotNullYearColumn { get; set; }
            Byte[] NotNullBinaryColumn { get; set; }
            Byte[] NotNullVarBinaryColumn { get; set; }
            Byte[] NotNullTinyBlobColumn { get; set; }
            String NotNullTinyTextColumn { get; set; }
            Byte[] NotNullBlobColumn { get; set; }
            String NotNullTextColumn { get; set; }
            Byte[] NotNullMediumBlobColumn { get; set; }
            String NotNullMediumTextColumn { get; set; }
            Byte[] NotNullLongBlobColumn { get; set; }
            String NotNullLongTextColumn { get; set; }
            global::MySql.Data.Types.MySqlGeometry NotNullGeometryColumn { get; set; }
            MyEnum NotNullEnumColumn { get; set; }
            MySet NotNullSetColumn { get; set; }
        }
    }
}
