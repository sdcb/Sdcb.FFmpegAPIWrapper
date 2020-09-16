using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// <see cref="AVDictionary"/>
    /// </summary>
    public unsafe class MediaDictionary : FFmpegHandle, IDictionary<string, string>
    {
        private MediaDictionary(AVDictionary* dict, bool isOwner) : base((IntPtr)dict, isOwner) { }

        public static MediaDictionary CreateEmpty() => new MediaDictionary(null, true);

        public static MediaDictionary Copy(MediaDictionary source)
        {
            AVDictionary* destination = null;
            av_dict_copy(&destination, source, 0).ThrowIfError();
            return new MediaDictionary(destination, isOwner: true);
        }

        internal void Reset(AVDictionary* dict) => _handle = (IntPtr)dict;

        public static MediaDictionary FromDictionary(IDictionary<string, string> dict)
        {
            MediaDictionary md = CreateEmpty();
            foreach (var entry in dict)
            {
                md[entry.Key] = entry.Value;
            }
            return md;
        }

        public static implicit operator AVDictionary*(MediaDictionary dict) => (AVDictionary*)dict._handle;

        #region IDictionary<string, string> entries
        public ICollection<string> Keys => this.Select(x => x.Key).ToArray();

        public ICollection<string> Values => this.Select(x => x.Key).ToArray();

        public int Count => av_dict_count(this);

        public bool IsReadOnly => false;

        public string this[string key]
        {
            get
            {
                AVDictionaryEntry* entry = av_dict_get(this, key, null, (int)MediaDictionaryReadFlags.CaseSensitive);
                if (entry == null)
                {
                    throw new KeyNotFoundException(key);
                }

                return Marshal.PtrToStringUTF8((IntPtr)entry->value);
            }
            set
            {
                AVDictionary* ptr = this;
                av_dict_set(&ptr, key, value, (int)MediaDictionarySetFlags.None).ThrowIfError();
                _handle = (IntPtr)ptr;
            }
        }

        public void Add(string key, string value)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (value == null) throw new ArgumentNullException(nameof(value)); // in AVDictionary, value is also not-null.

            if (ContainsKey(key))
            {
                throw new ArgumentException($"An item with the same key has already been added. Key: {key}");
            }

            AVDictionary* ptr = this;
            av_dict_set(&ptr, key, value, (int)MediaDictionarySetFlags.NoOverwrite).ThrowIfError();
            _handle = (IntPtr)ptr;
        }

        public bool ContainsKey(string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            AVDictionaryEntry* entry = av_dict_get(this, key, null, (int)MediaDictionaryReadFlags.CaseSensitive);
            return entry != null;
        }

        public bool Remove(string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            AVDictionary* ptr = this;
            bool containsKey = ContainsKey(key);

            av_dict_set(&ptr, key, null, 0).ThrowIfError();
            _handle = (IntPtr)ptr;
            return containsKey;
        }

        public bool TryGetValue(string key, out string value)
        {
            AVDictionaryEntry* entry = av_dict_get(this, key, null, (int)MediaDictionaryReadFlags.CaseSensitive);
            if (entry == null)
            {
                value = null;
                return false;
            }
            else
            {
                value = Marshal.PtrToStringUTF8((IntPtr)entry->value);
                return true;
            }
        }

        void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item)
        {
            Add(item.Key, item.Value);
        }

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item)
        {
            return TryGetValue(item.Key, out string value) && value == item.Value;
        }

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item)
        {
            if (TryGetValue(item.Key, out string value) && value == item.Value)
            {
                Remove(item.Key);
                return true;
            }
            return false;
        }

        public void Clear() => Close();

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (arrayIndex > array.Length) throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            if (array.Length - arrayIndex < Count) throw new ArgumentOutOfRangeException(nameof(arrayIndex));

            foreach (KeyValuePair<string, string> entry in this)
            {
                array[arrayIndex++] = entry;
            }
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            IntPtr opaque = IntPtr.Zero;
            while (true)
            {
                opaque = av_dict_get_safe(this, opaque);
                if (opaque == IntPtr.Zero) yield break;

                yield return GenerateResult(opaque);
            }

            static KeyValuePair<string, string> GenerateResult(IntPtr ptr)
            {
                var entry = (AVDictionaryEntry*)ptr;
                return KeyValuePair.Create(
                    Marshal.PtrToStringUTF8((IntPtr)entry->key),
                    Marshal.PtrToStringUTF8((IntPtr)entry->value));
            }

            static IntPtr av_dict_get_safe(MediaDictionary dict, IntPtr prev)
            {
                return (IntPtr)av_dict_get(dict, "", (AVDictionaryEntry*)prev, (int)MediaDictionaryReadFlags.IgnoreSuffix);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        public void Set(string key, string value, MediaDictionarySetFlags flags = MediaDictionarySetFlags.NoOverwrite)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (value == null) throw new ArgumentNullException(nameof(value)); // in AVDictionary, value is also not-null.

            AVDictionary* ptr = this;
            av_dict_set(&ptr, key, value, (int)flags).ThrowIfError();
            _handle = (IntPtr)ptr;
        }

        public override void Close()
        {
            AVDictionary* p = this;
            av_dict_free(&p);
            _handle = (IntPtr)p;
        }
    }
}
