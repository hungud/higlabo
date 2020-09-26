﻿using System;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using HigLabo.Data;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class RowGuidColTable : Table<RowGuidColTable.Record>
    {
        public const String Name = "RowGuidColTable";

        public override String TableName
        {
            get
            {
                return RowGuidColTable.Name;
            }
        }

        public override String GetDatabaseKey()
        {
            return "DbSharpSample_SqlServer";
        }
        public override Record CreateRecord()
        {
            return new Record();
        }
        protected override void SetRecordProperty(StoredProcedureResultSet resultSet, Record record)
        {
            record.SetProperty(resultSet as IRecord);
        }
        protected override void SetOutputParameterValue(Record record, StoredProcedure storedProcedure)
        {
            var spInsert = storedProcedure as RowGuidColTableInsert;
            if (spInsert != null)
            {
                record.RowGuidColumn = spInsert.RowGuidColumn;
            }
            var spUpdate = storedProcedure as RowGuidColTableUpdate;
            if (spUpdate != null)
            {
                record.RowGuidColumn = spUpdate.RowGuidColumn;
            }
        }
        public Record SelectByPrimaryKey(Guid rowGuidColumn)
        {
            return this.SelectByPrimaryKey(this.GetDatabase(), rowGuidColumn);
        }
        public Record SelectByPrimaryKeyOrNull(Guid rowGuidColumn)
        {
            return this.SelectByPrimaryKeyOrNull(this.GetDatabase(), rowGuidColumn);
        }
        public Record SelectByPrimaryKey(Database database, Guid rowGuidColumn)
        {
            var r = this.SelectByPrimaryKeyOrNull(database, rowGuidColumn);
            if (r == null) throw new TableRecordNotFoundException();
            return r;
        }
        public Record SelectByPrimaryKeyOrNull(Database database, Guid rowGuidColumn)
        {
            var sp = new RowGuidColTableSelectByPrimaryKey();
            sp.PK_RowGuidColumn = rowGuidColumn;
            var rs = sp.GetFirstResultSet(database);
            if (rs == null) return null;
            var r = new Record(rs);
            r.SetOldRecordProperty();
            return r;
        }
        public Int32 Delete(Guid rowGuidColumn)
        {
            return this.Delete(this.GetDatabase(), rowGuidColumn);
        }
        public Int32 Delete(Database database, Guid rowGuidColumn)
        {
            var sp = new RowGuidColTableDelete();
            ((IDatabaseContext)sp).TransactionKey = this.TransactionKey;
            sp.PK_RowGuidColumn = rowGuidColumn;
            return sp.ExecuteNonQuery(database);
        }
        public override StoredProcedureWithResultSet CreateStoredProcedureWithResultSet(TableStoredProcedureTypeWithResultSet type, Record record)
        {
            switch (type)
            {
                case TableStoredProcedureTypeWithResultSet.SelectAll: return CreateSelectAllStoredProcedure();
                case TableStoredProcedureTypeWithResultSet.SelectByPrimaryKey: return this.CreateSelectByPrimaryKeyStoredProcedure(record);
                default: throw new InvalidOperationException();
            }
        }
        public override StoredProcedure CreateStoredProcedure(TableStoredProcedureType type, Record record)
        {
            switch (type)
            {
                case TableStoredProcedureType.Insert: return this.CreateInsertStoredProcedure(record);
                case TableStoredProcedureType.Update: return this.CreateUpdateStoredProcedure(record);
                case TableStoredProcedureType.Delete: return this.CreateDeleteStoredProcedure(record);
                default: throw new InvalidOperationException();
            }
        }
        public RowGuidColTableSelectAll CreateSelectAllStoredProcedure()
        {
            return new RowGuidColTableSelectAll();
        }
        public RowGuidColTableSelectByPrimaryKey CreateSelectByPrimaryKeyStoredProcedure(Record record)
        {
            var sp = new RowGuidColTableSelectByPrimaryKey();
            ((IDatabaseContext)sp).TransactionKey = this.TransactionKey;
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_RowGuidColumn = record.OldRecord.RowGuidColumn;
            return sp;
        }
        public RowGuidColTableInsert CreateInsertStoredProcedure(Record record)
        {
            var sp = new RowGuidColTableInsert();
            ((IDatabaseContext)sp).TransactionKey = this.TransactionKey;
            if (record == null) return sp;
            sp.RowGuidColumn = record.RowGuidColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            return sp;
        }
        public RowGuidColTableUpdate CreateUpdateStoredProcedure(Record record)
        {
            var sp = new RowGuidColTableUpdate();
            ((IDatabaseContext)sp).TransactionKey = this.TransactionKey;
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.RowGuidColumn = record.RowGuidColumn;
            sp.NVarCharColumn = record.NVarCharColumn;
            sp.PK_RowGuidColumn = record.OldRecord.RowGuidColumn;
            return sp;
        }
        public RowGuidColTableDelete CreateDeleteStoredProcedure(Record record)
        {
            var sp = new RowGuidColTableDelete();
            ((IDatabaseContext)sp).TransactionKey = this.TransactionKey;
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_RowGuidColumn = record.OldRecord.RowGuidColumn;
            return sp;
        }
        protected override DataTable CreateDataTable()
        {
            var dt = new DataTable(Name);
            dt.Columns.Add("@PK_RowGuidColumn", typeof(Guid));
            dt.Columns.Add("@RowGuidColumn", typeof(Guid));
            dt.Columns.Add("@NVarCharColumn", typeof(String));
            return dt;
        }
        protected override DataRow SetDataRow(DataRow dataRow, Record record, SaveMode saveMode)
        {
            if (saveMode != SaveMode.Insert)
            {
                if (record.OldRecord == null) throw new OldRecordIsNullException();
                dataRow["@PK_RowGuidColumn"] = GetValueOrDBNull(record.OldRecord.RowGuidColumn);
            }
            dataRow["@RowGuidColumn"] = GetValueOrDBNull(record.RowGuidColumn);
            dataRow["@NVarCharColumn"] = GetValueOrDBNull(record.NVarCharColumn);
            return dataRow;
        }
    }
}
