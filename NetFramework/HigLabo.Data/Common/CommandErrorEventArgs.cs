﻿using System;
using System.Data;
using System.Data.Common;
using System.Text;

namespace HigLabo.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class CommandErrorEventArgs : EventArgs
    {
        /// <summary>
        /// エラーが発生したメソッドを示す値を取得します。
        /// </summary>
        public MethodName MethodName { get; private set; }

        /// <summary>
        /// コマンドが実行されるデータベースへの接続文字列を取得します。
        /// </summary>
        public string ConnectionString { get; private set; }

        /// <summary>
        /// 実行されたコマンドを取得します。
        /// </summary>
        public DbCommand Command { get; private set; }

        /// <summary>
        /// 実行されたデータアダプタを取得します。
        /// </summary>
        public DbDataAdapter DataAdapter { get; private set; }

        /// <summary>
        /// 実行されたバルクコピーのコンテキストを取得します。
        /// </summary>
        public SqlBulkCopyContext SqlBulkCopyContext { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Object ExecutionContext { get; set; }

        /// <summary>
        /// 発生した例外を取得します。
        /// </summary>
        public Exception Exception { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ThrowException { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="connectionString"></param>
        /// <param name="exception"></param>
        protected CommandErrorEventArgs(MethodName methodName, String connectionString, Exception exception, Object executionContext)
        {
            this.MethodName = methodName;
            this.ConnectionString = connectionString;
            this.Exception = exception;
            this.ThrowException = true;
            this.ExecutionContext = executionContext;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="connectionString"></param>
        /// <param name="command"></param>
        /// <param name="exception"></param>
        public CommandErrorEventArgs(MethodName methodName, String connectionString, Exception exception, Object executionContext, DbCommand command)
            : this(methodName, connectionString, exception, executionContext)
        {
            this.Command = command;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="connectionString"></param>
        /// <param name="dataAdapter"></param>
        /// <param name="exception"></param>
        public CommandErrorEventArgs(MethodName methodName, String connectionString, Exception exception, Object executionContext, DbDataAdapter dataAdapter)
            : this(methodName, connectionString, exception, executionContext)
        {
            this.DataAdapter = dataAdapter;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="connectionString"></param>
        /// <param name="context"></param>
        /// <param name="exception"></param>
        public CommandErrorEventArgs(MethodName methodName, String connectionString, Exception exception, Object executionContext, SqlBulkCopyContext sqlBulkCopyContext)
            : this(methodName, connectionString, exception, executionContext)
        {
            this.SqlBulkCopyContext = sqlBulkCopyContext;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(128);
            try
            {
                if (String.IsNullOrEmpty(this.ConnectionString) == false)
                {
                    sb.Append(this.ConnectionString);
                    sb.Append(" ");
                }
                if (this.Command != null)
                {
                    sb.Append(this.Command.CommandText);
                    sb.Append(" ");
                }
                if (this.Exception != null)
                {
                    sb.Append(this.Exception.ToString());
                }
                return sb.ToString();
            }
            catch { return base.ToString(); }
        }
    }
}
