﻿using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using HigLabo.Core;
using HigLabo.Data;
using HigLabo.DbSharp;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace HigLabo.DbSharpSample.MySql
{
    public partial class Usp_OutputParameter : StoredProcedure
    {
        public const String Name = "Usp_OutputParameter";
        private String _CharColumn = "";
        private String _NCharColumn = "";
        private String _VarCharColumn = "";
        private String _NVarCharColumn = "";
        private Boolean? _BitColumn;
        private SByte? _TinyIntColumn;
        private Int16? _SmallIntColumn;
        private Int32? _MediumIntColumn;
        private Int32? _IntColumn;
        private Int64? _BigIntColumn;
        private Byte? _TinyIntUnsignedColumn;
        private UInt16? _SmallIntUnsignedColumn;
        private UInt32? _MediumIntUnsignedColumn;
        private UInt32? _IntUnsignedColumn;
        private UInt64? _BigIntUnsignedColumn;
        private Single? _FloatColumn;
        private Double? _DoubleColumn;
        private Decimal? _DecimalColumn;
        private Decimal? _NumericColumn;
        private DateTime? _DateColumn;
        private DateTime? _DateTimeColumn;
        private TimeSpan? _TimeColumn;
        private Int32? _YearColumn;
        private Byte[] _BinaryColumn;
        private Byte[] _VarBinaryColumn;
        private Byte[] _TinyBlobColumn;
        private Byte[] _MediumBlobColumn;
        private Byte[] _BlobColumn;
        private Byte[] _LongBlobColumn;
        private String _TinyTextColumn = "";
        private String _TextColumn = "";
        private String _MediumTextColumn = "";
        private String _LongTextColumn = "";
        private DateTime? _TimestampColumn;
        private MyEnum? _EnumColumn;
        private MySet? _SetColumn;

        public String TransactionKey
        {
            get
            {
                return ((IDatabaseContext)this).TransactionKey;
            }
            set
            {
                ((IDatabaseContext)this).TransactionKey = value;
            }
        }
        public String CharColumn
        {
            get
            {
                return _CharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _CharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NCharColumn
        {
            get
            {
                return _NCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NCharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String VarCharColumn
        {
            get
            {
                return _VarCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _VarCharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NVarCharColumn
        {
            get
            {
                return _NVarCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NVarCharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Boolean? BitColumn
        {
            get
            {
                return _BitColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BitColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public SByte? TinyIntColumn
        {
            get
            {
                return _TinyIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int16? SmallIntColumn
        {
            get
            {
                return _SmallIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SmallIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int32? MediumIntColumn
        {
            get
            {
                return _MediumIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int32? IntColumn
        {
            get
            {
                return _IntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _IntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int64? BigIntColumn
        {
            get
            {
                return _BigIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BigIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte? TinyIntUnsignedColumn
        {
            get
            {
                return _TinyIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt16? SmallIntUnsignedColumn
        {
            get
            {
                return _SmallIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SmallIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt32? MediumIntUnsignedColumn
        {
            get
            {
                return _MediumIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt32? IntUnsignedColumn
        {
            get
            {
                return _IntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _IntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt64? BigIntUnsignedColumn
        {
            get
            {
                return _BigIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BigIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Single? FloatColumn
        {
            get
            {
                return _FloatColumn;
            }
            set
            {
                this.SetPropertyValue(ref _FloatColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Double? DoubleColumn
        {
            get
            {
                return _DoubleColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DoubleColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal? DecimalColumn
        {
            get
            {
                return _DecimalColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DecimalColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal? NumericColumn
        {
            get
            {
                return _NumericColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NumericColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime? DateColumn
        {
            get
            {
                return _DateColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DateColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime? DateTimeColumn
        {
            get
            {
                return _DateTimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DateTimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public TimeSpan? TimeColumn
        {
            get
            {
                return _TimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int32? YearColumn
        {
            get
            {
                return _YearColumn;
            }
            set
            {
                this.SetPropertyValue(ref _YearColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] BinaryColumn
        {
            get
            {
                return _BinaryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BinaryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] VarBinaryColumn
        {
            get
            {
                return _VarBinaryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _VarBinaryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] TinyBlobColumn
        {
            get
            {
                return _TinyBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] MediumBlobColumn
        {
            get
            {
                return _MediumBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] BlobColumn
        {
            get
            {
                return _BlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] LongBlobColumn
        {
            get
            {
                return _LongBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _LongBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String TinyTextColumn
        {
            get
            {
                return _TinyTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyTextColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String TextColumn
        {
            get
            {
                return _TextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TextColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String MediumTextColumn
        {
            get
            {
                return _MediumTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumTextColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String LongTextColumn
        {
            get
            {
                return _LongTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _LongTextColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime? TimestampColumn
        {
            get
            {
                return _TimestampColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TimestampColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public MyEnum? EnumColumn
        {
            get
            {
                return _EnumColumn;
            }
            set
            {
                this.SetPropertyValue(ref _EnumColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public MySet? SetColumn
        {
            get
            {
                return _SetColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SetColumn, value, this.GetPropertyChangedEventHandler());
            }
        }

        public Usp_OutputParameter()
        {
            ConstructorExecuted();
        }

        public override String GetDatabaseKey()
        {
            return "DbSharpSample_MySql";
        }
        public override String GetStoredProcedureName()
        {
            return Usp_OutputParameter.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand()
        {
            var db = new MySqlDatabase("");
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("CharColumn", MySqlDbType.String, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.CharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NCharColumn", MySqlDbType.String, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.NCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("VarCharColumn", MySqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.VarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NVarCharColumn", MySqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.NVarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BitColumn", MySqlDbType.Bit, 1, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.BitColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyIntColumn", MySqlDbType.Byte, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TinyIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("SmallIntColumn", MySqlDbType.Int16, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.SmallIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumIntColumn", MySqlDbType.Int24, 7, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.MediumIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("IntColumn", MySqlDbType.Int32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.IntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BigIntColumn", MySqlDbType.Int64, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.BigIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyIntUnsignedColumn", MySqlDbType.UByte, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TinyIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("SmallIntUnsignedColumn", MySqlDbType.UInt16, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.SmallIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumIntUnsignedColumn", MySqlDbType.UInt24, 7, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.MediumIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("IntUnsignedColumn", MySqlDbType.UInt32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.IntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BigIntUnsignedColumn", MySqlDbType.UInt64, 20, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.BigIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("FloatColumn", MySqlDbType.Float, 8, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.FloatColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DoubleColumn", MySqlDbType.Double, 9, 5);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DoubleColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DecimalColumn", MySqlDbType.Decimal, 10, 5);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DecimalColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NumericColumn", MySqlDbType.Decimal, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.NumericColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DateColumn", MySqlDbType.Date, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DateColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DateTimeColumn", MySqlDbType.DateTime, null, 5);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.DateTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TimeColumn", MySqlDbType.Time, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("YearColumn", MySqlDbType.Year, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.YearColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BinaryColumn", MySqlDbType.Binary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.BinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("VarBinaryColumn", MySqlDbType.VarBinary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 100;
            p.Value = this.VarBinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyBlobColumn", MySqlDbType.TinyBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 255;
            p.Value = this.TinyBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumBlobColumn", MySqlDbType.MediumBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 16777215;
            p.Value = this.MediumBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BlobColumn", MySqlDbType.Blob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 65535;
            p.Value = this.BlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("LongBlobColumn", MySqlDbType.LongBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 2147483647;
            p.Value = this.LongBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyTextColumn", MySqlDbType.TinyText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 255;
            p.Value = this.TinyTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TextColumn", MySqlDbType.Text, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 65535;
            p.Value = this.TextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumTextColumn", MySqlDbType.MediumText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 16777215;
            p.Value = this.MediumTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("LongTextColumn", MySqlDbType.LongText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 2147483647;
            p.Value = this.LongTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TimestampColumn", MySqlDbType.Timestamp, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TimestampColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("EnumColumn", MySqlDbType.Enum, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 7;
            p.Value = this.EnumColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("SetColumn", MySqlDbType.Set, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Size = 20;
            p.Value = this.SetColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            for (int i = 0; i < cm.Parameters.Count; i++)
            {
                if (cm.Parameters[i].Value == null) cm.Parameters[i].Value = DBNull.Value;
            }
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
            var cm = command;
            DbParameter p = null;
            p = cm.Parameters[0] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.CharColumn = (String)p.Value;
            p = cm.Parameters[1] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.NCharColumn = (String)p.Value;
            p = cm.Parameters[2] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.VarCharColumn = (String)p.Value;
            p = cm.Parameters[3] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.NVarCharColumn = (String)p.Value;
            p = cm.Parameters[4] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BitColumn = ((UInt64)p.Value != 0);
            p = cm.Parameters[5] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TinyIntColumn = (SByte)p.Value;
            p = cm.Parameters[6] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.SmallIntColumn = (Int16)p.Value;
            p = cm.Parameters[7] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.MediumIntColumn = (Int32)p.Value;
            p = cm.Parameters[8] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.IntColumn = (Int32)p.Value;
            p = cm.Parameters[9] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BigIntColumn = (Int64)p.Value;
            p = cm.Parameters[10] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TinyIntUnsignedColumn = (Byte)p.Value;
            p = cm.Parameters[11] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.SmallIntUnsignedColumn = (UInt16)p.Value;
            p = cm.Parameters[12] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.MediumIntUnsignedColumn = (UInt32)p.Value;
            p = cm.Parameters[13] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.IntUnsignedColumn = (UInt32)p.Value;
            p = cm.Parameters[14] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BigIntUnsignedColumn = (UInt64)p.Value;
            p = cm.Parameters[15] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.FloatColumn = (Single)p.Value;
            p = cm.Parameters[16] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DoubleColumn = (Double)p.Value;
            p = cm.Parameters[17] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DecimalColumn = (Decimal)p.Value;
            p = cm.Parameters[18] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.NumericColumn = (Decimal)p.Value;
            p = cm.Parameters[19] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DateColumn = (DateTime)p.Value;
            p = cm.Parameters[20] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.DateTimeColumn = (DateTime)p.Value;
            p = cm.Parameters[21] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TimeColumn = (TimeSpan)p.Value;
            p = cm.Parameters[22] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.YearColumn = (Int32)p.Value;
            p = cm.Parameters[23] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BinaryColumn = (Byte[])p.Value;
            p = cm.Parameters[24] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.VarBinaryColumn = (Byte[])p.Value;
            p = cm.Parameters[25] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TinyBlobColumn = (Byte[])p.Value;
            p = cm.Parameters[26] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.MediumBlobColumn = (Byte[])p.Value;
            p = cm.Parameters[27] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.BlobColumn = (Byte[])p.Value;
            p = cm.Parameters[28] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.LongBlobColumn = (Byte[])p.Value;
            p = cm.Parameters[29] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TinyTextColumn = (String)p.Value;
            p = cm.Parameters[30] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TextColumn = (String)p.Value;
            p = cm.Parameters[31] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.MediumTextColumn = (String)p.Value;
            p = cm.Parameters[32] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.LongTextColumn = (String)p.Value;
            p = cm.Parameters[33] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TimestampColumn = (DateTime)p.Value;
            p = cm.Parameters[34] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.EnumColumn = StoredProcedure.ToEnum<MyEnum>(p.Value as String) ?? this.EnumColumn;
            p = cm.Parameters[35] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.SetColumn = StoredProcedure.ToEnum<MySet>(p.Value as String) ?? this.SetColumn;
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<Usp_OutputParameter>");
            sb.AppendFormat("CharColumn={0}", this.CharColumn); sb.AppendLine();
            sb.AppendFormat("NCharColumn={0}", this.NCharColumn); sb.AppendLine();
            sb.AppendFormat("VarCharColumn={0}", this.VarCharColumn); sb.AppendLine();
            sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
            sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
            sb.AppendFormat("TinyIntColumn={0}", this.TinyIntColumn); sb.AppendLine();
            sb.AppendFormat("SmallIntColumn={0}", this.SmallIntColumn); sb.AppendLine();
            sb.AppendFormat("MediumIntColumn={0}", this.MediumIntColumn); sb.AppendLine();
            sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
            sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
            sb.AppendFormat("TinyIntUnsignedColumn={0}", this.TinyIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("SmallIntUnsignedColumn={0}", this.SmallIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("MediumIntUnsignedColumn={0}", this.MediumIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("IntUnsignedColumn={0}", this.IntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("BigIntUnsignedColumn={0}", this.BigIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
            sb.AppendFormat("DoubleColumn={0}", this.DoubleColumn); sb.AppendLine();
            sb.AppendFormat("DecimalColumn={0}", this.DecimalColumn); sb.AppendLine();
            sb.AppendFormat("NumericColumn={0}", this.NumericColumn); sb.AppendLine();
            sb.AppendFormat("DateColumn={0}", this.DateColumn); sb.AppendLine();
            sb.AppendFormat("DateTimeColumn={0}", this.DateTimeColumn); sb.AppendLine();
            sb.AppendFormat("TimeColumn={0}", this.TimeColumn); sb.AppendLine();
            sb.AppendFormat("YearColumn={0}", this.YearColumn); sb.AppendLine();
            sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
            sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
            sb.AppendFormat("TinyBlobColumn={0}", this.TinyBlobColumn); sb.AppendLine();
            sb.AppendFormat("MediumBlobColumn={0}", this.MediumBlobColumn); sb.AppendLine();
            sb.AppendFormat("BlobColumn={0}", this.BlobColumn); sb.AppendLine();
            sb.AppendFormat("LongBlobColumn={0}", this.LongBlobColumn); sb.AppendLine();
            sb.AppendFormat("TinyTextColumn={0}", this.TinyTextColumn); sb.AppendLine();
            sb.AppendFormat("TextColumn={0}", this.TextColumn); sb.AppendLine();
            sb.AppendFormat("MediumTextColumn={0}", this.MediumTextColumn); sb.AppendLine();
            sb.AppendFormat("LongTextColumn={0}", this.LongTextColumn); sb.AppendLine();
            sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
            sb.AppendFormat("EnumColumn={0}", this.EnumColumn); sb.AppendLine();
            sb.AppendFormat("SetColumn={0}", this.SetColumn); sb.AppendLine();
            return sb.ToString();
        }
    }
}
