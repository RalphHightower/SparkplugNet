// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#nullable enable
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("SparkplugNet.Tests")]
namespace SparkplugNet.VersionB.ProtoBuf
{
    [global::ProtoBuf.ProtoContract()]
    internal partial class ProtoBufPayload : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension? extensionValue;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"timestamp")]
        public ulong? Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"metrics")]
        public global::System.Collections.Generic.List<Metric> Metrics { get; set; } = new global::System.Collections.Generic.List<Metric>();

        [global::ProtoBuf.ProtoMember(3, Name = @"seq")]
        public ulong? Seq { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"uuid")]
        public string? Uuid { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"body")]
        public byte[] Body { get; set; } = Array.Empty<byte>();

        [global::ProtoBuf.ProtoContract()]
        internal partial class Template : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension? extensionValue;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"version")]
            public string? Version { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"metrics")]
            public global::System.Collections.Generic.List<Metric> Metrics { get; set; } = new global::System.Collections.Generic.List<Metric>();

            [global::ProtoBuf.ProtoMember(3, Name = @"parameters")]
            public global::System.Collections.Generic.List<Parameter> Parameters { get; set; } = new global::System.Collections.Generic.List<Parameter>();

            [global::ProtoBuf.ProtoMember(4, Name = @"template_ref")]
            public string? TemplateRef { get; set; }

            [global::ProtoBuf.ProtoMember(5, Name = @"is_definition")]
            public bool? IsDefinition { get; set; }

            [global::ProtoBuf.ProtoContract()]
            internal partial class Parameter : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension? extensionValue;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"name")]
                public string? Name { get; set; }

                [global::ProtoBuf.ProtoMember(2, Name = @"type")]
                public uint? DataType { get; set; }

                [global::ProtoBuf.ProtoMember(3, Name = @"int_value")]
                public uint IntValue
                {
                    get => type.Is(3) ? type.UInt32 : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(3, value);
                }
                public bool ShouldSerializeIntValue() => type.Is(3);
                public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 3);

                private global::ProtoBuf.DiscriminatedUnion64Object type;

                [global::ProtoBuf.ProtoMember(4, Name = @"long_value")]
                public ulong LongValue
                {
                    get => type.Is(4) ? type.UInt64 : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(4, value);
                }
                public bool ShouldSerializeLongValue() => type.Is(4);
                public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 4);

                [global::ProtoBuf.ProtoMember(5, Name = @"float_value")]
                public float FloatValue
                {
                    get => type.Is(5) ? type.Single : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(5, value);
                }
                public bool ShouldSerializeFloatValue() => type.Is(5);
                public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 5);

                [global::ProtoBuf.ProtoMember(6, Name = @"double_value")]
                public double DoubleValue
                {
                    get => type.Is(6) ? type.Double : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(6, value);
                }
                public bool ShouldSerializeDoubleValue() => type.Is(6);
                public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 6);

                [global::ProtoBuf.ProtoMember(7, Name = @"boolean_value")]
                public bool BooleanValue
                {
                    get => type.Is(7) ? type.Boolean : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(7, value);
                }
                public bool ShouldSerializeBooleanValue() => type.Is(7);
                public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 7);

                [global::ProtoBuf.ProtoMember(8, Name = @"string_value")]
                [global::System.ComponentModel.DefaultValue("")]
                public string StringValue
                {
                    get => type.Is(8) ? ((string)type.Object) : string.Empty;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(8, value);
                }
                public bool ShouldSerializeStringValue() => type.Is(8);
                public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 8);

                [global::ProtoBuf.ProtoMember(9, Name = @"extension_value")]
                public ParameterValueExtension? ExtensionValue
                {
                    get => type.Is(9) ? ((ParameterValueExtension)type.Object) : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(9, value);
                }
                public bool ShouldSerializeExtensionValue() => type.Is(9);
                public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 9);

                [global::ProtoBuf.ProtoContract()]
                internal partial class ParameterValueExtension : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension? extensionValue;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);
                }
            }
        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class DataSet : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension? extensionValue;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"num_of_columns")]
            public ulong? NumberOfColumns { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"columns")]
            public global::System.Collections.Generic.List<string> Columns { get; set; } = new global::System.Collections.Generic.List<string>();

            [global::ProtoBuf.ProtoMember(3, Name = @"types")]
            public uint[] Types { get; set; } = Array.Empty<uint>();

            [global::ProtoBuf.ProtoMember(4, Name = @"rows")]
            public global::System.Collections.Generic.List<Row> Rows { get; set; } = new global::System.Collections.Generic.List<Row>();

            [global::ProtoBuf.ProtoContract()]
            internal partial class DataSetValue : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension? extensionValue;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"int_value")]
                public uint IntValue
                {
                    get => type.Is(1) ? type.UInt32 : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(1, value);
                }
                public bool ShouldSerializeIntValue() => type.Is(1);
                public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 1);

                private global::ProtoBuf.DiscriminatedUnion64Object type;

                [global::ProtoBuf.ProtoMember(2, Name = @"long_value")]
                public ulong LongValue
                {
                    get => type.Is(2) ? type.UInt64 : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(2, value);
                }
                public bool ShouldSerializeLongValue() => type.Is(2);
                public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 2);

                [global::ProtoBuf.ProtoMember(3, Name = @"float_value")]
                public float FloatValue
                {
                    get => type.Is(3) ? type.Single : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(3, value);
                }
                public bool ShouldSerializeFloatValue() => type.Is(3);
                public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 3);

                [global::ProtoBuf.ProtoMember(4, Name = @"double_value")]
                public double DoubleValue
                {
                    get => type.Is(4) ? type.Double : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(4, value);
                }
                public bool ShouldSerializeDoubleValue() => type.Is(4);
                public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 4);

                [global::ProtoBuf.ProtoMember(5, Name = @"boolean_value")]
                public bool BooleanValue
                {
                    get => type.Is(5) ? type.Boolean : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(5, value);
                }
                public bool ShouldSerializeBooleanValue() => type.Is(5);
                public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 5);

                [global::ProtoBuf.ProtoMember(6, Name = @"string_value")]
                [global::System.ComponentModel.DefaultValue("")]
                public string StringValue
                {
                    get => type.Is(6) ? ((string)type.Object) : string.Empty;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(6, value);
                }
                public bool ShouldSerializeStringValue() => type.Is(6);
                public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 6);

                [global::ProtoBuf.ProtoMember(7, Name = @"extension_value")]
                public DataSetValueExtension? ExtensionValue
                {
                    get => type.Is(7) ? ((DataSetValueExtension)type.Object) : default;
                    set => type = new global::ProtoBuf.DiscriminatedUnion64Object(7, value);
                }
                public bool ShouldSerializeExtensionValue() => type.Is(7);
                public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 7);

                [global::ProtoBuf.ProtoContract()]
                internal partial class DataSetValueExtension : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension? extensionValue;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);
                }
            }

            [global::ProtoBuf.ProtoContract()]
            internal partial class Row : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension? extensionValue;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"elements")]
                public global::System.Collections.Generic.List<DataSet.DataSetValue> Elements { get; set; } = new global::System.Collections.Generic.List<DataSet.DataSetValue>();
            }
        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class PropertyValue : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension? extensionValue;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"type")]
            public uint? DataType { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"is_null")]
            public bool? IsNull { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"int_value")]
            public uint IntValue
            {
                get => type.Is(3) ? type.UInt32 : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(3, value);
            }
            public bool ShouldSerializeIntValue() => type.Is(3);
            public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 3);

            private global::ProtoBuf.DiscriminatedUnion64Object type;

            [global::ProtoBuf.ProtoMember(4, Name = @"long_value")]
            public ulong LongValue
            {
                get => type.Is(4) ? type.UInt64 : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(4, value);
            }
            public bool ShouldSerializeLongValue() => type.Is(4);
            public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 4);

            [global::ProtoBuf.ProtoMember(5, Name = @"float_value")]
            public float FloatValue
            {
                get => type.Is(5) ? type.Single : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(5, value);
            }
            public bool ShouldSerializeFloatValue() => type.Is(5);
            public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 5);

            [global::ProtoBuf.ProtoMember(6, Name = @"double_value")]
            public double DoubleValue
            {
                get => type.Is(6) ? type.Double : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(6, value);
            }
            public bool ShouldSerializeDoubleValue() => type.Is(6);
            public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 6);

            [global::ProtoBuf.ProtoMember(7, Name = @"boolean_value")]
            public bool BooleanValue
            {
                get => type.Is(7) ? type.Boolean : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(7, value);
            }
            public bool ShouldSerializeBooleanValue() => type.Is(7);
            public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 7);

            [global::ProtoBuf.ProtoMember(8, Name = @"string_value")]
            [global::System.ComponentModel.DefaultValue("")]
            public string StringValue
            {
                get => type.Is(8) ? ((string)type.Object) : string.Empty;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(8, value);
            }
            public bool ShouldSerializeStringValue() => type.Is(8);
            public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 8);

            [global::ProtoBuf.ProtoMember(9, Name = @"propertyset_value")]
            public PropertySet? PropertySetValue
            {
                get => type.Is(9) ? ((PropertySet)type.Object) : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(9, value);
            }
            public bool ShouldSerializePropertysetValue() => type.Is(9);
            public void ResetPropertysetValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 9);

            [global::ProtoBuf.ProtoMember(10, Name = @"propertysets_value")]
            public PropertySetList? PropertySetListValue
            {
                get => type.Is(10) ? ((PropertySetList)type.Object) : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(10, value);
            }
            public bool ShouldSerializePropertysetsValue() => type.Is(10);
            public void ResetPropertysetsValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 10);

            [global::ProtoBuf.ProtoMember(11, Name = @"extension_value")]
            public PropertyValueExtension? ExtensionValue
            {
                get => type.Is(11) ? ((PropertyValueExtension)type.Object) : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(11, value);
            }
            public bool ShouldSerializeExtensionValue() => type.Is(11);
            public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 11);

            [global::ProtoBuf.ProtoContract()]
            internal partial class PropertyValueExtension : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension? extensionValue;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);
            }
        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class PropertySet : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension? extensionValue;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"keys")]
            public global::System.Collections.Generic.List<string> Keys { get; set; } = new global::System.Collections.Generic.List<string>();

            [global::ProtoBuf.ProtoMember(2, Name = @"values")]
            public global::System.Collections.Generic.List<PropertyValue> Values { get; set; } = new global::System.Collections.Generic.List<PropertyValue>();
        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class PropertySetList : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension? extensionValue;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"propertyset")]
            public global::System.Collections.Generic.List<PropertySet> PropertySets { get; set; } = new global::System.Collections.Generic.List<PropertySet>();
        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class MetaData : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension? extensionValue;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"is_multi_part")]
            public bool? IsMultiPart { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"content_type")]
            public string? ContentType { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"size")]
            public ulong? Size { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"seq")]
            public ulong? Seq { get; set; }

            [global::ProtoBuf.ProtoMember(5, Name = @"file_name")]
            public string? FileName { get; set; }

            [global::ProtoBuf.ProtoMember(6, Name = @"file_type")]
            public string? FileType { get; set; }

            [global::ProtoBuf.ProtoMember(7, Name = @"md5")]
            public string? Md5 { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"description")]
            public string? Description { get; set; }
        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class Metric : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension? extensionValue;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"name")]
            public string? Name { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"alias")]
            public ulong? Alias { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"timestamp")]
            public ulong? Timestamp { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"datatype")]
            public uint? DataType { get; set; }

            [global::ProtoBuf.ProtoMember(5, Name = @"is_historical")]
            public bool? IsHistorical { get; set; }

            [global::ProtoBuf.ProtoMember(6, Name = @"is_transient")]
            public bool? IsTransient { get; set; }

            [global::ProtoBuf.ProtoMember(7, Name = @"is_null")]
            public bool? IsNull { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"metadata")]
            public MetaData? MetaData { get; set; }

            [global::ProtoBuf.ProtoMember(9, Name = @"properties")]
            public PropertySet? PropertySetValue { get; set; }

            [global::ProtoBuf.ProtoMember(10, Name = @"int_value")]
            public uint IntValue
            {
                get => type.Is(10) ? type.UInt32 : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(10, value);
            }
            public bool ShouldSerializeIntValue() => type.Is(10);
            public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 10);

            private global::ProtoBuf.DiscriminatedUnion64Object type;

            [global::ProtoBuf.ProtoMember(11, Name = @"long_value")]
            public ulong LongValue
            {
                get => type.Is(11) ? type.UInt64 : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(11, value);
            }
            public bool ShouldSerializeLongValue() => type.Is(11);
            public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 11);

            [global::ProtoBuf.ProtoMember(12, Name = @"float_value")]
            public float FloatValue
            {
                get => type.Is(12) ? type.Single : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(12, value);
            }
            public bool ShouldSerializeFloatValue() => type.Is(12);
            public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 12);

            [global::ProtoBuf.ProtoMember(13, Name = @"double_value")]
            public double DoubleValue
            {
                get => type.Is(13) ? type.Double : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(13, value);
            }
            public bool ShouldSerializeDoubleValue() => type.Is(13);
            public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 13);

            [global::ProtoBuf.ProtoMember(14, Name = @"boolean_value")]
            public bool BooleanValue
            {
                get => type.Is(14) ? type.Boolean : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(14, value);
            }
            public bool ShouldSerializeBooleanValue() => type.Is(14);
            public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 14);

            [global::ProtoBuf.ProtoMember(15, Name = @"string_value")]
            [global::System.ComponentModel.DefaultValue("")]
            public string StringValue
            {
                get => type.Is(15) ? ((string)type.Object) : string.Empty;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(15, value);
            }
            public bool ShouldSerializeStringValue() => type.Is(15);
            public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 15);

            [global::ProtoBuf.ProtoMember(16, Name = @"bytes_value")]
            public byte[] BytesValue
            {
                get => type.Is(16) ? ((byte[])type.Object) : Array.Empty<byte>();
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(16, value);
            }
            public bool ShouldSerializeBytesValue() => type.Is(16);
            public void ResetBytesValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 16);

            [global::ProtoBuf.ProtoMember(17, Name = @"dataset_value")]
            public DataSet? DataSetValue
            {
                get => type.Is(17) ? ((DataSet)type.Object) : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(17, value);
            }
            public bool ShouldSerializeDatasetValue() => type.Is(17);
            public void ResetDatasetValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 17);

            [global::ProtoBuf.ProtoMember(18, Name = @"template_value")]
            public Template? TemplateValue
            {
                get => type.Is(18) ? ((Template)type.Object) : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(18, value);
            }
            public bool ShouldSerializeTemplateValue() => type.Is(18);
            public void ResetTemplateValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 18);

            [global::ProtoBuf.ProtoMember(19, Name = @"extension_value")]
            public MetricValueExtension? ExtensionValue
            {
                get => type.Is(19) ? ((MetricValueExtension)type.Object) : default;
                set => type = new global::ProtoBuf.DiscriminatedUnion64Object(19, value);
            }
            public bool ShouldSerializeExtensionValue() => type.Is(19);
            public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref type, 19);

            [global::ProtoBuf.ProtoContract()]
            internal partial class MetricValueExtension : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension? extensionValue;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref extensionValue, createIfMissing);
            }
        }
    }

    [global::ProtoBuf.ProtoContract()]
    public enum DataType
    {
        Unknown = 0,
        Int8 = 1,
        Int16 = 2,
        Int32 = 3,
        Int64 = 4,
        UInt8 = 5,
        UInt16 = 6,
        UInt32 = 7,
        UInt64 = 8,
        Float = 9,
        Double = 10,
        Boolean = 11,
        String = 12,
        DateTime = 13,
        Text = 14,
        [global::ProtoBuf.ProtoEnum(Name = @"UUID")]
        Uuid = 15,
        DataSet = 16,
        Bytes = 17,
        File = 18,
        Template = 19,
        PropertySet = 20,
        PropertySetList = 21,
        Int8Array = 22,
        Int16Array = 23,
        Int32Array = 24,
        Int64Array = 25,
        UInt8Array = 26,
        UInt16Array = 27,
        UInt32Array = 28,
        UInt64Array = 29,
        FloatArray = 30,
        DoubleArray = 31,
        BooleanArray = 32,
        StringArray = 33,
        DateTimeArray = 34,
    }
}
#nullable disable
#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion