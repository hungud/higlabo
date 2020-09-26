﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HigLabo.Core;

namespace HigLabo.Net
{
    /// <summary>
    /// 
    /// </summary>
    internal class StreamWriteContext
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<HttpRequestUploadingEventArgs> Uploading;
        private Stream _TargetStream = null;
        private Int32? _BufferSize = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetStream"></param>
        public StreamWriteContext(Stream targetStream)
        {
            if (targetStream == null) { throw new ArgumentNullException("targetStream must not be null"); }
            _TargetStream = targetStream;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetStream"></param>
        /// <param name="bufferSize"></param>
        public StreamWriteContext(Stream targetStream, Int32 bufferSize)
        {
            if (targetStream == null) { throw new ArgumentNullException("targetStream must not be null"); }
            if (bufferSize <= 0) { throw new ArgumentException("bufferSize must be larger than zero"); }
            _TargetStream = targetStream;
            _BufferSize = bufferSize;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void Write(Byte[] data)
        {
            MemoryStream mm = new MemoryStream(data);
            this.Write(mm);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceStream"></param>
        internal void Write(Stream sourceStream)
        {
            if (sourceStream.Length > Int32.MaxValue) { throw new NotSupportedException("sourceStream length must be less than Int32.MaxValue."); }
            Int32 length = (Int32)sourceStream.Length;
            
            if (this._BufferSize.HasValue == true)
            {
                Byte[] bb = null;
                Int32 index = 0;
                Int32 size = this._BufferSize.Value;
                Boolean isBreak = false;
                while (true)
                {
                    if (index + size >= length)
                    {
                        size = length - index;
                        isBreak = true;
                    }
                    bb = new Byte[size];
                    sourceStream.Read(bb, 0, size);
                    _TargetStream.Write(bb, 0, size);
                    this.OnUploading(new HttpRequestUploadingEventArgs(size, index + size));
                    if (isBreak == true) { break; }
                    index = index + size;
                }
            }
            else
            {
                sourceStream.CopyTo(_TargetStream);
                this.OnUploading(new HttpRequestUploadingEventArgs(length, length));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected void OnUploading(HttpRequestUploadingEventArgs e)
        {
            var eh = this.Uploading;
            if (eh != null)
            {
                eh(this, e);
            }
        }
    }
}
