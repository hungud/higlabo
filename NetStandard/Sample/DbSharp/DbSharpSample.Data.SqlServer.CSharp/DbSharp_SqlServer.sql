Create Type MyTableType As Table
(BigIntColumn bigint not null
,BinaryColumn binary(100)
,ImageColumn image
--,TimestampColumn timestamp
,VarBinaryColumn varbinary(100)
,BitColumn bit
,CharColumn char(100)
,NCharColumn nchar(100)
,NTextColumn ntext
,NVarCharColumn nvarchar(100)
,TextColumn text
,VarCharColumn varchar(100)
,XmlColumn xml
,DateTimeColumn datetime
,SmallDateTimeColumn smalldatetime
,DateColumn date
,TimeColumn time
,DateTime2Column datetime2
,DecimalColumn decimal
,MoneyColumn money
,SmallMoneyColumn smallmoney
,FloatColumn float
,IntColumn int
,RealColumn real
,UniqueIdentifierColumn uniqueidentifier
,SmallIntColumn smallint 
,TinyIntColumn tinyint
,DateTimeOffsetColumn datetimeoffset(7)
/*
,SqlVariantColumn sql_variant 
A bug exist at SqlVariant http://connect.microsoft.com/VisualStudio/feedback/details/476281/sql-server-2008-table-valued-parameter-tvp-with-column-type-sql-variant-cannot-be-filled-with-datatable-with-column-type-system-object
,GeometryColumn geometry 
,GeographyColumn geography 
,HierarchyIDColumn Hierarchyid 
*/
,EnumColumn nvarchar(20)
)

 
Go

Create Type MyTableType1 As Table
(BigIntColumn bigint not null
,BinaryColumn binary(100)
,ImageColumn image
,VarBinaryColumn varbinary(100)
) 

Go



--Drop Table AllDataTypeTable 

Create Table AllDataTypeTable  
(PrimaryKeyColumn bigint not null
,TimestampColumn timestamp

,BigIntColumn bigint 
,BinaryColumn binary(100)
,ImageColumn image
,VarBinaryColumn varbinary(100)
,BitColumn bit
,CharColumn char(100)
,NCharColumn nchar(100)
,NTextColumn ntext
,NVarCharColumn nvarchar(100)
,TextColumn text
,VarCharColumn varchar(100)
,XmlColumn xml
,DateTimeColumn datetime
,SmallDateTimeColumn smalldatetime
,DateColumn date
,TimeColumn time
,DateTime2Column datetime2
,DecimalColumn decimal
,MoneyColumn money
,SmallMoneyColumn smallmoney
,FloatColumn float
,IntColumn int
,RealColumn real
,UniqueIdentifierColumn uniqueidentifier
,SmallIntColumn smallint 
,TinyIntColumn tinyint
,DateTimeOffsetColumn datetimeoffset(7)
,SqlVariantColumn sql_variant
,GeometryColumn geometry 
,GeographyColumn geography 
,HierarchyIDColumn Hierarchyid 
,EnumColumn nvarchar(20)

,NotNullBigIntColumn bigint not null
,NotNullBinaryColumn binary(100) not null
,NotNullImageColumn image not null
,NotNullVarBinaryColumn varbinary(100) not null
,NotNullBitColumn bit not null
,NotNullCharColumn char(100) not null
,NotNullNCharColumn nchar(100) not null
,NotNullNTextColumn ntext not null
,NotNullNVarCharColumn nvarchar(100) not null
,NotNullTextColumn text not null
,NotNullVarCharColumn varchar(100) not null
,NotNullXmlColumn xml not null
,NotNullDateTimeColumn datetime not null
,NotNullSmallDateTimeColumn smalldatetime not null
,NotNullDateColumn date not null
,NotNullTimeColumn time not null
,NotNullDateTime2Column datetime2 not null
,NotNullDecimalColumn decimal not null
,NotNullMoneyColumn money not null
,NotNullSmallMoneyColumn smallmoney not null
,NotNullFloatColumn float not null
,NotNullIntColumn int not null
,NotNullRealColumn real not null
,NotNullUniqueIdentifierColumn uniqueidentifier not null
,NotNullSmallIntColumn smallint not null
,NotNullTinyIntColumn tinyint not null
,NotNullDateTimeOffsetColumn datetimeoffset(7) not null
,NotNullSqlVariantColumn sql_variant not null
,NotNullGeometryColumn geometry not null
,NotNullGeographyColumn geography not null
,NotNullHierarchyIDColumn Hierarchyid not null
,NotNullEnumColumn nvarchar(20) not null
)

Go

Alter Table [dbo].[AllDataTypeTable] Add Constraint [PK_AllDataTypeTable] 
Primary Key NonClustered (PrimaryKeyColumn)

Go


Create Procedure AllDataTypeTableInsert
(@PrimaryKeyColumn BigInt
,@TimestampColumn Timestamp output
,@BigIntColumn BigInt
,@BinaryColumn Binary (100)
,@ImageColumn Image
,@VarBinaryColumn VarBinary (100)
,@BitColumn Bit
,@CharColumn Char (100)
,@NCharColumn NChar (100)
,@NTextColumn NText
,@NVarCharColumn NVarChar (100)
,@TextColumn Text
,@VarCharColumn VarChar (100)
,@XmlColumn Xml
,@DateTimeColumn DateTime
,@SmallDateTimeColumn SmallDateTime
,@DateColumn Date
,@TimeColumn Time (7)
,@DateTime2Column DateTime2 (7)
,@DecimalColumn Decimal (18, 0)
,@MoneyColumn Money
,@SmallMoneyColumn SmallMoney
,@FloatColumn Float (53)
,@IntColumn Int
,@RealColumn Real
,@UniqueIdentifierColumn UniqueIdentifier
,@SmallIntColumn SmallInt
,@TinyIntColumn TinyInt
,@DateTimeOffsetColumn DateTimeOffset (7)
,@SqlVariantColumn sql_variant
,@GeometryColumn geometry
,@GeographyColumn geography
,@HierarchyIDColumn hierarchyid
,@EnumColumn NVarChar (20)
,@NotNullBigIntColumn BigInt
,@NotNullBinaryColumn Binary (100)
,@NotNullImageColumn Image
,@NotNullVarBinaryColumn VarBinary (100)
,@NotNullBitColumn Bit
,@NotNullCharColumn Char (100)
,@NotNullNCharColumn NChar (100)
,@NotNullNTextColumn NText
,@NotNullNVarCharColumn NVarChar (100)
,@NotNullTextColumn Text
,@NotNullVarCharColumn VarChar (100)
,@NotNullXmlColumn Xml
,@NotNullDateTimeColumn DateTime
,@NotNullSmallDateTimeColumn SmallDateTime
,@NotNullDateColumn Date
,@NotNullTimeColumn Time (7)
,@NotNullDateTime2Column DateTime2 (7)
,@NotNullDecimalColumn Decimal (18, 0)
,@NotNullMoneyColumn Money
,@NotNullSmallMoneyColumn SmallMoney
,@NotNullFloatColumn Float (53)
,@NotNullIntColumn Int
,@NotNullRealColumn Real
,@NotNullUniqueIdentifierColumn UniqueIdentifier
,@NotNullSmallIntColumn SmallInt
,@NotNullTinyIntColumn TinyInt
,@NotNullDateTimeOffsetColumn DateTimeOffset (7)
,@NotNullSqlVariantColumn sql_variant
,@NotNullGeometryColumn geometry
,@NotNullGeographyColumn geography
,@NotNullHierarchyIDColumn hierarchyid
,@NotNullEnumColumn NVarChar (20)
) As

insert into [AllDataTypeTable]
([PrimaryKeyColumn]
,[BigIntColumn]
,[BinaryColumn]
,[ImageColumn]
,[VarBinaryColumn]
,[BitColumn]
,[CharColumn]
,[NCharColumn]
,[NTextColumn]
,[NVarCharColumn]
,[TextColumn]
,[VarCharColumn]
,[XmlColumn]
,[DateTimeColumn]
,[SmallDateTimeColumn]
,[DateColumn]
,[TimeColumn]
,[DateTime2Column]
,[DecimalColumn]
,[MoneyColumn]
,[SmallMoneyColumn]
,[FloatColumn]
,[IntColumn]
,[RealColumn]
,[UniqueIdentifierColumn]
,[SmallIntColumn]
,[TinyIntColumn]
,[DateTimeOffsetColumn]
,[SqlVariantColumn]
,[GeometryColumn]
,[GeographyColumn]
,[HierarchyIDColumn]
,[EnumColumn]
,[NotNullBigIntColumn]
,[NotNullBinaryColumn]
,[NotNullImageColumn]
,[NotNullVarBinaryColumn]
,[NotNullBitColumn]
,[NotNullCharColumn]
,[NotNullNCharColumn]
,[NotNullNTextColumn]
,[NotNullNVarCharColumn]
,[NotNullTextColumn]
,[NotNullVarCharColumn]
,[NotNullXmlColumn]
,[NotNullDateTimeColumn]
,[NotNullSmallDateTimeColumn]
,[NotNullDateColumn]
,[NotNullTimeColumn]
,[NotNullDateTime2Column]
,[NotNullDecimalColumn]
,[NotNullMoneyColumn]
,[NotNullSmallMoneyColumn]
,[NotNullFloatColumn]
,[NotNullIntColumn]
,[NotNullRealColumn]
,[NotNullUniqueIdentifierColumn]
,[NotNullSmallIntColumn]
,[NotNullTinyIntColumn]
,[NotNullDateTimeOffsetColumn]
,[NotNullSqlVariantColumn]
,[NotNullGeometryColumn]
,[NotNullGeographyColumn]
,[NotNullHierarchyIDColumn]
,[NotNullEnumColumn]
)
values
(@PrimaryKeyColumn
,@BigIntColumn
,@BinaryColumn
,@ImageColumn
,@VarBinaryColumn
,@BitColumn
,@CharColumn
,@NCharColumn
,@NTextColumn
,@NVarCharColumn
,@TextColumn
,@VarCharColumn
,@XmlColumn
,@DateTimeColumn
,@SmallDateTimeColumn
,@DateColumn
,@TimeColumn
,@DateTime2Column
,@DecimalColumn
,@MoneyColumn
,@SmallMoneyColumn
,@FloatColumn
,@IntColumn
,@RealColumn
,@UniqueIdentifierColumn
,@SmallIntColumn
,@TinyIntColumn
,@DateTimeOffsetColumn
,@SqlVariantColumn
,@GeometryColumn
,@GeographyColumn
,@HierarchyIDColumn
,@EnumColumn
,@NotNullBigIntColumn
,@NotNullBinaryColumn
,@NotNullImageColumn
,@NotNullVarBinaryColumn
,@NotNullBitColumn
,@NotNullCharColumn
,@NotNullNCharColumn
,@NotNullNTextColumn
,@NotNullNVarCharColumn
,@NotNullTextColumn
,@NotNullVarCharColumn
,@NotNullXmlColumn
,@NotNullDateTimeColumn
,@NotNullSmallDateTimeColumn
,@NotNullDateColumn
,@NotNullTimeColumn
,@NotNullDateTime2Column
,@NotNullDecimalColumn
,@NotNullMoneyColumn
,@NotNullSmallMoneyColumn
,@NotNullFloatColumn
,@NotNullIntColumn
,@NotNullRealColumn
,@NotNullUniqueIdentifierColumn
,@NotNullSmallIntColumn
,@NotNullTinyIntColumn
,@NotNullDateTimeOffsetColumn
,@NotNullSqlVariantColumn
,@NotNullGeometryColumn
,@NotNullGeographyColumn
,@NotNullHierarchyIDColumn
,@NotNullEnumColumn
)

select @TimestampColumn = TimestampColumn from AllDataTypeTable with(nolock)
where [PrimaryKeyColumn] = @PrimaryKeyColumn

Go



/*
SQL TableValue parameter
C# SqlDbType.Structure, DataTable --> p.TypeName
Structured only used on parameter type
*/
Create Procedure Usp_Structure
(@BigIntColumn bigint out
,@StructuredColumn as MyTableType readonly
) As 

Set @BigIntColumn = @BigIntColumn + 
(
	select Sum(BigIntColumn) from @StructuredColumn where EnumColumn = 'Default'
) 


Go


Create Procedure Usp_OutputParameter
(@BigIntColumn bigint out
,@BinaryColumn binary(100) out
,@ImageColumn image 
,@VarBinaryColumn varbinary(100) out
,@BitColumn bit out
,@CharColumn char(100) out
,@NCharColumn nchar(100) out
,@NTextColumn ntext 
,@NVarCharColumn nvarchar(100) out
,@TextColumn text 
,@VarCharColumn varchar(100) out
,@XmlColumn xml out
,@DateTimeColumn datetime out
,@SmallDateTimeColumn smalldatetime out
,@DateColumn date out
,@TimeColumn time out
,@DateTime2Column datetime2 out
,@DecimalColumn decimal out
,@MoneyColumn money out
,@SmallMoneyColumn smallmoney out
,@FloatColumn float out
,@IntColumn int out
,@RealColumn real out
,@UniqueIdentifierColumn uniqueidentifier out
,@SmallIntColumn smallint  out
,@TinyIntColumn tinyint out
,@DateTimeOffsetColumn datetimeoffset(7) out
,@GeometryColumn geometry out 
,@GeographyColumn geography out
,@HierarchyIDColumn Hierarchyid 
,@EnumColumn nvarchar(20) out
) As 

Set @BigIntColumn = @BigIntColumn + 1 
Set @SmallIntColumn = @SmallIntColumn + 1


Go


Create Table IdentityTable 
(IntColumn int not null IDENTITY(1,1)
,NVarCharColumn nvarchar(100)
)

Go

ALTER TABLE [dbo].[IdentityTable] ADD CONSTRAINT [PK_IdentityTable] 
PRIMARY KEY NONCLUSTERED ([IntColumn])

GO


Create Procedure IdentityTableInsert
(@IntColumn Int output
,@NVarCharColumn NVarChar (100)
) As

declare @InsertedTable table(IntColumn Int);

insert into [IdentityTable]
([NVarCharColumn]
)
output inserted.IntColumn into @InsertedTable
values
(@NVarCharColumn
)
select @IntColumn = IntColumn from @InsertedTable

Go


Create Table RowGuidColTable 
(RowGuidColumn uniqueidentifier not null ROWGUIDCOL Default NEWSEQUENTIALID()
,NVarCharColumn nvarchar(100)
)

Go

ALTER TABLE [dbo].[RowGuidColTable] ADD CONSTRAINT [PK_RowGuidColTable] 
PRIMARY KEY CLUSTERED ([RowGuidColumn])

GO



Create Procedure RowGuidColTableInsert
(@RowGuidColumn UniqueIdentifier output
,@NVarCharColumn NVarChar (100)
) As

declare @InsertedTable table(RowGuidColumn UniqueIdentifier);

insert into [RowGuidColTable]
([NVarCharColumn]
)
output inserted.RowGuidColumn into @InsertedTable
values
(@NVarCharColumn
)
select @RowGuidColumn = RowGuidColumn from @InsertedTable

Go




Create Table MultiPkTable 
(BigIntColumn bigint not null
,IntColumn int not null
,FloatColumn float not null
,BinaryColumn binary(100)
,TimestampColumn timestamp
,VarBinaryColumn varbinary(100)
,BitColumn bit
,NCharColumn nchar(100)
,NTextColumn ntext
,NVarCharColumn nvarchar(100)
)

Go

ALTER TABLE [dbo].[MultiPkTable] ADD CONSTRAINT [PK_MultiPkTable] 
PRIMARY KEY NONCLUSTERED ([BigIntColumn],[IntColumn],[FloatColumn])

GO

Create Procedure Usp_SelectMultiTable 
As

select * from AllDataTypeTable with(nolock)
select * from IdentityTable with(nolock)
select * from RowGuidColTable with(nolock)
select * from MultiPkTable with(nolock)

Go
