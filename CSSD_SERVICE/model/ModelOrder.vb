Imports System.Runtime.Serialization

Namespace model

    Public Class Poly
        <DataMember()>
        Public polyCode As String
        <DataMember()>
        Public polyName As String
    End Class

    <DataContract()>
    Public Class CSSD_MasterOrder
        <DataMember()>
        Public IdOrder As Long 'bigint
        <DataMember()>
        Public NoOrder As String 'varchar(20)
        <DataMember()>
        Public PetugasOrder As String 'varchar(100)
        <DataMember()>
        Public Poly As Poly
        <DataMember()>
        Public Telp As String 'varchar(20)
        <DataMember()>
        Public TglDatang As String 'datetime
        <DataMember()>
        Public TglDiambil As DateTime 'datetime
        <DataMember()>
        Public OrderFinishFlag As String 'char(1)
        <DataMember()>
        Public ReorderFlag As String 'char(1)
        <DataMember()>
        Public UserInput As String
        <DataMember()>
        Public TglInput As String
        <DataMember()>
        Public cancel_by As String
        <DataMember()>
        Public update_by As String
        <DataMember()>
        Public tgltransfer As DateTime
        <DataMember()>
        Public userTransfer As String
        <DataMember()>
        Public userTerima As String
        <DataMember()>
        Public jenisBarang As String
        <DataMember()>
        Public type_order As String
        <DataMember()>
        Public PetugasSterilisasi As String


        Public Sub New()
            Poly = New Poly()
        End Sub

    End Class

    <DataContract()>
    Public Class CSSD_DetailOrder
        <DataMember()>
        Public IdDetailOrder As Long 'bigint
        <DataMember()>
        Public IdOrder As Long 'bigint
        <DataMember()>
        Public NoInventory As String 'int
        <DataMember()>
        Public QtyTerima As Integer 'int
        <DataMember()>
        Public KodeSatuan As String 'varchar(10)
        <DataMember()>
        Public Berat As Double 'numeric(10,2)
        <DataMember()>
        Public Keterangan As String 'varchar(100)
        <DataMember()>
        Public TglPencucian As DateTime 'datetime
        <DataMember()>
        Public TglSettingPacking As DateTime 'datetime
        <DataMember()>
        Public TglSterilisasi As DateTime 'datetime
        <DataMember()>
        Public StatusOrder As String 'varchar(20)

        <DataMember()>
        Public KodeSetInstrumen As String 'varchar(20)

        <DataMember()>
        Public create_by As String
        <DataMember()>
        Public cancel_by As String
        <DataMember()>
        Public update_by As String
        <DataMember()>
        Public IdJenisAlat As Integer
        <DataMember()>
        Public JenisReuse As String
        <DataMember()>
        Public KodeIdentifikasi As String
    End Class

    <DataContract()>
    Public Class CSSD_DetailOrderHistoryView
        <DataMember()>
        Public KodePetugas As String
        <DataMember()>
        Public NamaPetugas As String
        <DataMember()>
        Public KodeMesin As String
        <DataMember()>
        Public NamaMesin As String
        <DataMember()>
        Public Jenis As String
    End Class

    Public Class CSSD_TracingOrderDetail
        <DataMember()>
        Public IdDetailOrder As Long
        <DataMember()>
        Public NoOrder As String = String.Empty 'varchar(20)
        <DataMember()>
        Public NoInventory As String = String.Empty 'varchar(50)
        <DataMember()>
        Public NoTracing As String = String.Empty 'varchar(50)
        <DataMember()>
        Public PetugasOrder As String = String.Empty 'varchar(100)
        <DataMember()>
        Public poly_name As String = String.Empty 'varchar(50)
        <DataMember()>
        Public Telp As String = String.Empty 'varchar(20)
        <DataMember()>
        Public TglInput As String 'datetime(8)
        <DataMember()>
        Public KodeAlat As String = String.Empty 'varchar(10)
        <DataMember()>
        Public NamaAlat As String = String.Empty 'varchar(100)

        <DataMember()>
        Public JenisAlat As String
        <DataMember()>
        Public Kode_Identifikasi_Alat As String
        <DataMember()>
        Public standar_reuse As String
        <DataMember()>
        Public jml_reuse As String

        <DataMember()>
        Public TglPencucian As String 'datetime(8)
        <DataMember()>
        Public KodePetugasCuci As String = String.Empty 'varchar(10)
        <DataMember()>
        Public NamaPetugasCuci As String = String.Empty 'varchar(100)
        <DataMember()>
        Public KodeMesinCuci As String = String.Empty 'varchar(10)
        <DataMember()>
        Public NamaMesinCuci As String = String.Empty 'varchar(100)
        <DataMember()>
        Public NamaGroupMesinCuci As String = String.Empty 'varchar(50)
        <DataMember()>
        Public TipeCuci As String = String.Empty 'varchar(50)
        <DataMember()>
        Public TglSettingPacking As String 'datetime(8)
        <DataMember()>
        Public KodePetugasSetting1 As String = String.Empty 'varchar(10)
        <DataMember()>
        Public PetugasSetting1 As String = String.Empty 'varchar(100)
        <DataMember()>
        Public KodePetugasSetting2 As String = String.Empty 'varchar(10)
        <DataMember()>
        Public PetugasSetting2 As String = String.Empty 'varchar(100)
        <DataMember()>
        Public TglSterilisasi As String 'datetime(8)
        <DataMember()>
        Public KodePetugasSteril As String = String.Empty 'varchar(10)
        <DataMember()>
        Public PetugasSteril As String = String.Empty 'varchar(100)
        <DataMember()>
        Public KodePetugasSteril2 As String = String.Empty 'varchar(10)
        <DataMember()>
        Public PetugasSteril2 As String = String.Empty 'varchar(100)

        <DataMember()>
        Public KodeMesinSteril As String = String.Empty 'varchar(10)
        <DataMember()>
        Public NamaMesinSteril As String = String.Empty 'varchar(100)
        <DataMember()>
        Public NamaGroupMesinSteril As String = String.Empty 'varchar(50)
        <DataMember()>
        Public TipeSteril As String = String.Empty 'varchar(50)
        <DataMember()>
        Public TglmasukGudang As String = String.Empty 'datetime(8)
        <DataMember()>
        Public NamaGudang As String = String.Empty
        <DataMember()>
        Public TglDistribusi As String = String.Empty
        <DataMember()>
        Public StatusOrder As String = String.Empty 'varchar(20)

        <DataMember()>
        Public idJenisAlat As Integer
        <DataMember()>
        Public type_order As String

        <DataMember()>
        Public tglKadaluarsa As String

        <DataMember()>
        Public Petugas_gudang_cssd As String
        <DataMember()>
        Public Petugas_input_cssd As String


    End Class

    <DataContract()>
    Public Class CSSD_DetailOrderHistory
        <DataMember()>
        Public IdDetailHistory As Long 'bigint
        <DataMember()>
        Public IdDetailOrder As Long 'varchar(50)
        <DataMember()>
        Public KodeMesin As String 'varchar(10)
        <DataMember()>
        Public KodePetugas As String 'varchar(10)
        <DataMember()>
        Public jenis As String 'varchar(20)
        <DataMember()>
        Public StatusOrder As String
        <DataMember()>
        Public NoLoad As Long
        <DataMember()>
        Public NoTrace As String
        <DataMember()>
        Public create_by As String
    End Class

    <DataContract()>
    Public Class CSSD_TracingDetailView
        <DataMember()>
        Public IdDetailOrder As String 'string
        <DataMember()>
        Public NoTracing As String 'string
        <DataMember()>
        Public NoInventory As String 'int
        <DataMember()>
        Public KodeAlat As String 'varchar(20)
        <DataMember()>
        Public NamaAlat As String 'string
        <DataMember()>
        Public Jenis As String 'string
        <DataMember()>
        Public IdJenisAlat As Integer 'int
        <DataMember()>
        Public Kode_Identifikasi_Alat As String
    End Class

    <DataContract()>
    Public Class CSSD_DetailSetting
        <DataMember()>
        Public KodeAlat As String 'varchar(10)
        <DataMember()>
        Public IdInduk As String
        <DataMember()>
        Public Qty As Integer 'int
        <DataMember()>
        Public QtyPacking As Integer
        <DataMember()>
        Public Keterangan As String
        <DataMember()>
        Public IdJenisAlat As Integer
        <DataMember()>
        Public iddetailorder As Integer

    End Class

    Public Class CSSD_GudangSteril
        <DataMember()>
        Public NoTracing As String 'varchar(30)
        <DataMember()>
        Public NoInventory As String 'varchar(20)
        <DataMember()>
        Public KodeAlat As String 'varchar(20)
        <DataMember()>
        Public TglInput As DateTime
        <DataMember()>
        Public KodeGudang As String 'varchar(5)
        <DataMember()>
        Public UserCSSD As String 'varchar(5)
        <DataMember()>
        Public UserIBS As String 'varchar(5)

        <DataMember()>
        Public UserPengirim As String 'varchar(5)
        <DataMember()>
        Public UserPengirim_2 As String
        <DataMember()>
        Public UserPenerima As String 'varchar(5)
        <DataMember()>
        Public KodeGudangAsal As String 'varchar(5)
        <DataMember()>
        Public id_group_transfer As Long
        <DataMember()>
        Public KodePetugasSterilisasi1 As String
        <DataMember()>
        Public KodePetugasSterilisasi2 As String


    End Class

    Public Class CSSD_Distribusi
        <DataMember()>
        Public IdDistribusi As Long
        <DataMember()>
        Public IdOrder As Long
        <DataMember()>
        Public TglDistribusi As DateTime
        <DataMember()>
        Public UserInput As Integer
        <DataMember()>
        Public PetugasSterilisasi As String
        <DataMember()>
        Public UserPenerima As String

    End Class

    Public Class CSSD_OrderAlatOperasiHeader
        <DataMember()>
        Public IdOrder As Long
        <DataMember()>
        Public IdOperasi As Long
        <DataMember()>
        Public NoRegister As Long
        <DataMember()>
        Public Status As String
        <DataMember()>
        Public TglOrder As DateTime
        <DataMember()>
        Public UserInput As Integer
        <DataMember()>
        Public UserPenerima As String
        <DataMember()>
        Public PetugasSterilisasi As String
    End Class

    Public Class CSSD_OrderAlatOperasiDetail
        <DataMember()>
        Public IdOrderDetail As Long
        <DataMember()>
        Public IdOrder As Long
        <DataMember()>
        Public NoTracing As String
        <DataMember()>
        Public NoInventory As String
        <DataMember()>
        Public Keterangan As String
        <DataMember()>
        Public userEntry As String
        <DataMember()>
        Public idjenisalat As Integer
    End Class

    Public Class CSSD_PasienOperasiView
        <DataMember()>
        Public id As Long
        <DataMember()>
        Public NoRegister As Long
        <DataMember()>
        Public Nama As String
        <DataMember()>
        Public Umur As String
        <DataMember()>
        Public ruang As String
        <DataMember()>
        Public diagnosa As String
        <DataMember()>
        Public tindakan As String
        <DataMember()>
        Public OperatorUser As String
        <DataMember()>
        Public StaffUser As String
        <DataMember()>
        Public theater_name As String
        <DataMember()>
        Public theater_location As String
        <DataMember()>
        Public TanggalOperasi As String
        <DataMember()>
        Public JamOperasi As String

    End Class

End Namespace
