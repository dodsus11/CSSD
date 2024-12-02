Imports System.Runtime.Serialization

Namespace model

    <DataContract()>
    Public Class CSSD_MasterInstrumen
        <DataMember()>
        Public IdInstrumen As String 'varchar(10)
        <DataMember()>
        Public KodeInstrumen As String 'varchar(10)
        <DataMember()>
        Public NamaInstrumen As String 'varchar(100)
        <DataMember()>
        Public Berat As Double 'numeric(10,2)
        <DataMember()>
        Public Satuan As CSSD_MasterSatuan 'CSSD_MasterSatuan
        <DataMember()>
        Public PathFoto As String 'varchar(255)
        <DataMember()>
        Public UserInput As Integer 'int(10)
        <DataMember()>
        Public TglInput As DateTime 'datetime
        <DataMember()>
        Public UserUpdate As Integer 'int(10)
        <DataMember()>
        Public TglUpdate As DateTime 'datetime

        Public Sub New()
            Satuan = New CSSD_MasterSatuan()
        End Sub
    End Class

    <DataContract()>
    Public Class CSSD_MasterSatuan
        <DataMember()>
        Public KodeSatuan As String 'varchar(10)
        <DataMember()>
        Public NamaSatuan As String 'varchar(10)
    End Class

    <DataContract()>
    Public Class CSSD_Petugas
        <DataMember()>
        Public KodePetugas As String 'varchar(10)
        <DataMember()>
        Public NamaPetugas As String 'varchar(100)
        <DataMember()>
        Public Nip As String 'varchar(30)
        <DataMember()>
        Public UserInput As Integer 'int(10)
        <DataMember()>
        Public TglInput As DateTime 'datetime
        <DataMember()>
        Public UserUpdate As Integer 'int(10)
        <DataMember()>
        Public TglUpdate As DateTime 'datetime
    End Class

    <DataContract()>
    Public Class CSSD_GroupMesin
        <DataMember()>
        Public IdGroupMesin As Integer 'int(10)
        <DataMember()>
        Public NamaGroupMesin As String 'varchar(50)
        <DataMember()>
        Public Tipe As String 'varchar(50)
        <DataMember()>
        Public UserInput As Integer 'int(10)
        <DataMember()>
        Public TglInput As DateTime 'datetime
        <DataMember()>
        Public UserUpdate As Integer 'int(10)
        <DataMember()>
        Public TglUpdate As DateTime 'datetime
    End Class

    <DataContract()>
    Public Class CSSD_Mesin
        <DataMember()>
        Public KodeMesin As String 'varchar(10)
        <DataMember()>
        Public NamaMesin As String 'varchar(100)
        <DataMember()>
        Public Merk As String 'varchar(50)
        <DataMember()>
        Public NamaVendor As String 'varchar(100)
        <DataMember()>
        Public TglPengadaan As String
        <DataMember()>
        Public tgl_pengadaan As Date
        <DataMember()>
        Public GroupMesin As CSSD_GroupMesin 'CSSD_GroupMesin
        <DataMember()>
        Public UserInput As Integer 'int(10)
        <DataMember()>
        Public TglInput As DateTime 'datetime
        <DataMember()>
        Public UserUpdate As Integer 'int(10)
        <DataMember()>
        Public TglUpdate As DateTime 'datetime
        <DataMember()>
        Public LoadMesin As Long 'bigint

        Public Sub New()
            GroupMesin = New CSSD_GroupMesin()
        End Sub
    End Class

    <DataContract()>
    Public Class CSSD_MasterSetInstrumen
        <DataMember()>
        Public IdSetInstrumen As Integer 'int(10)
        <DataMember()>
        Public KodeSetInstrumen As String 'varchar(10)
        <DataMember()>
        Public NamaSetInstrumen As String 'varchar(100)
        <DataMember()>
        Public Berat As Double 'numeric(10,2)
        <DataMember()>
        Public Satuan As CSSD_MasterSatuan 'CSSD_MasterSatuan
        <DataMember()>
        Public StandarKasa As Integer 'int(10)
        <DataMember()>
        Public PathFoto As String 'varchar(255)
        <DataMember()>
        Public Keterangan As String 'varchar(100)
        <DataMember()>
        Public UserInput As Integer 'int(10)
        <DataMember()>
        Public TglInput As DateTime 'datetime
        <DataMember()>
        Public UserUpdate As Integer 'int(10)
        <DataMember()>
        Public TglUpdate As DateTime 'datetime
        <DataMember()>
        Public ExpiredDate As String 'date
        <DataMember()>
        Public TglRevisi As DateTime 'date
        <DataMember()>
        Public RevisiCount As Integer 'date

        Public Sub New()
            Satuan = New CSSD_MasterSatuan()
        End Sub
    End Class

    <DataContract()>
    Public Class CSSD_DetailSetInstrumen
        <DataMember()>
        Public IdDetailSetInstrumen As Integer 'int(10)
        <DataMember()>
        Public KodeSetInstrumen As String 'varchar(10)
        <DataMember()>
        Public IdInstrumen As String 'CSSD_MasterInstrumen
        <DataMember()>
        Public Qty As Integer 'int
        <DataMember()>
        Public QtyPacking As Integer
        <DataMember()>
        Public Keterangan As String
        <DataMember()>
        Public flag As String

    End Class

    <DataContract()>
    Public Class CSSD_JenisAlat
        <DataMember()>
        Public IdJenisAlat As Integer 'int
        <DataMember()>
        Public NamaJenis As String 'varchar(20)
    End Class

    <DataContract()>
    Public Class CSSD_Inventory
        <DataMember()>
        Public NoInventory As String
        <DataMember()>
        Public KodeAlat As String 'varchar(20)
        <DataMember()>
        Public IdJenisAlat As Integer 'int
        <DataMember()>
        Public standar_reuse As Integer
    End Class

    <DataContract()>
    Public Class CSSD_MasterGudang
        <DataMember()>
        Public KodeGudang As String
        <DataMember()>
        Public NamaGudang As String
        <DataMember()>
        Public Telp As String
    End Class

    Public Class CSSD_MappingUserGudang
        <DataMember()>
        Public IdUser As Long
        <DataMember()>
        Public KodeGudang As String
        <DataMember()>
        Public NamaGudang As String
        <DataMember()>
        Public TimeGranted As String
        <DataMember()>
        Public UserEntry As Long
    End Class

End Namespace
