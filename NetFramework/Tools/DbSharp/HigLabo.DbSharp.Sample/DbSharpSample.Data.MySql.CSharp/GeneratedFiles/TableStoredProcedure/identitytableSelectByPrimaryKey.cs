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
    public partial class identitytableSelectByPrimaryKey : StoredProcedureWithResultSet<identitytableSelectByPrimaryKey.ResultSet>
    {
        public const String Name = "identitytableSelectByPrimaryKey";
        private Int32 _PK_IntColumn;

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
        public Int32 PK_IntColumn
        {
            get
            {
                return _PK_IntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _PK_IntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }

        public identitytableSelectByPrimaryKey()
        {
            ConstructorExecuted();
        }

        public override String GetDatabaseKey()
        {
            return "DbSharpSample_MySql";
        }
        public override String GetStoredProcedureName()
        {
            return identitytableSelectByPrimaryKey.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand()
        {
            var db = new MySqlDatabase("");
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("PK_IntColumn", MySqlDbType.Int32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PK_IntColumn;
            cm.Parameters.Add(p);
            
            for (int i = 0; i < cm.Parameters.Count; i++)
            {
                if (cm.Parameters[i].Value == null) cm.Parameters[i].Value = DBNull.Value;
            }
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
        }
        public override identitytableSelectByPrimaryKey.ResultSet CreateResultSet()
        {
            return new ResultSet(this);
        }
        public new identitytableSelectByPrimaryKey.ResultSet GetFirstResultSet()
        {
            return base.GetFirstResultSet() as identitytableSelectByPrimaryKey.ResultSet;
        }
        public new identitytableSelectByPrimaryKey.ResultSet GetFirstResultSet(Database database)
        {
            return base.GetFirstResultSet(database) as identitytableSelectByPrimaryKey.ResultSet;
        }
        protected override void SetResultSet(identitytableSelectByPrimaryKey.ResultSet resultSet, IDataReader reader)
        {
            var r = resultSet;
            Int32 index = -1;
            try
            {
                index += 1; r.IntColumn = reader.GetInt32(index);
                index += 1; r.TimestampColumn = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.NVarCharColumn = reader[index] as String;
            }
            catch (InvalidCastException ex)
            {
                throw new StoredProcedureSchemaMismatchedException(this, index, ex);
            }
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<identitytableSelectByPrimaryKey>");
            sb.AppendFormat("PK_IntColumn={0}", this.PK_IntColumn); sb.AppendLine();
            return sb.ToString();
        }

        public partial class ResultSet : StoredProcedureResultSet, identitytable.IRecord
        {
            private Int32 _IntColumn;
            private DateTime _TimestampColumn;
            private String _NVarCharColumn = "";

            public Int32 IntColumn
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
            public DateTime TimestampColumn
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

            public ResultSet()
            {
            }
            public ResultSet(identitytable.IRecord resultSet)
            {
                var r = resultSet;
                IntColumn = r.IntColumn;
                TimestampColumn = r.TimestampColumn;
                NVarCharColumn = r.NVarCharColumn;
            }
            internal ResultSet(identitytableSelectByPrimaryKey storedProcedure)
            {
                this._StoredProcedureResultSet_StoredProcedure = storedProcedure;
            }

            public override String ToString()
            {
                var sb = new StringBuilder(64);
                sb.AppendLine("<identitytableSelectByPrimaryKey.ResultSet>");
                sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
                sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
                sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
                return sb.ToString();
            }
        }
    }
}
