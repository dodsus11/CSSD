Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface ICSSDSetupService

#Region "Inventory"
        <OperationContract()>
        Function SaveInventory(ByVal data As model.CSSD_Inventory) As String
        <OperationContract()>
        Function GetInventoryByJenis(ByVal idJenisAlat As Integer) As DataTable
        <OperationContract()>
        Function DeleteInventory(ByVal NoInventory As String) As String
        <OperationContract()>
        Function GetInstrumenByJenis(ByVal idJenisAlat As Integer) As DataTable
#End Region

#Region "Alat"
        <OperationContract()>
        Function GetJenisAlat() As DataTable
#End Region

#Region "Other"
        <OperationContract()>
        Function getPolyRoomByType(ByVal poliType As String) As DataTable
        <OperationContract()>
        Function GetUserHMIS() As DataTable
        <OperationContract()>
        Function ViewUserTerdaftarGudang(ByVal IdUser As Long) As model.CSSD_MappingUserGudang
        <OperationContract()>
        Function SaveMappingUserGudang(ByVal data As model.CSSD_MappingUserGudang) As String
#End Region

#Region "Satuan"
        '----------------------------- Setup Satuan
        <OperationContract()>
        Function GetAllSetupSatuan() As DataTable
        <OperationContract()>
        Function SaveSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String
        <OperationContract()>
        Function UpdateSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String
        <OperationContract()>
        Function DeleteSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String
        <OperationContract()>
        Function ViewSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As model.CSSD_MasterSatuan

        '----------------------------- EOC Setup Satuan
#End Region

#Region "Master Instrumen"
        '----------------------------- Setup Master Instrumen
        <OperationContract()>
        Function GetAllSetupMasterInstrumen() As DataTable
        <OperationContract()>
        Function SaveSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String
        <OperationContract()>
        Function UpdateSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String
        <OperationContract()>
        Function DeleteSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String
        <OperationContract()>
        Function ViewSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As model.CSSD_MasterInstrumen
        <OperationContract()>
        Function UpdatePathFotoInstrumen(ByVal idInstrumen As String, ByVal PathFoto As String) As String

        '----------------------------- EOC Setup Master Instrumen
#End Region

#Region "Petugas"
        '----------------------------- Setup Petugas
        <OperationContract()>
        Function GetAllSetupPetugas() As DataTable
        <OperationContract()>
        Function SaveSetupPetugas(ByVal data As model.CSSD_Petugas) As String
        <OperationContract()>
        Function UpdateSetupPetugas(ByVal data As model.CSSD_Petugas) As String
        <OperationContract()>
        Function DeleteSetupPetugas(ByVal data As model.CSSD_Petugas) As String
        <OperationContract()>
        Function ViewSetupPetugas(ByVal data As model.CSSD_Petugas) As model.CSSD_Petugas

        '----------------------------- EOC Setup Petugas
#End Region

#Region "Group Mesin"
        '----------------------------- Group Mesin
        <OperationContract()>
        Function GetAllSetupGroupMesin() As DataTable
        <OperationContract()>
        Function SaveSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String
        <OperationContract()>
        Function UpdateSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String
        <OperationContract()>
        Function DeleteSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String
        <OperationContract()>
        Function ViewSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As model.CSSD_GroupMesin

        '----------------------------- EOC Group Mesin
#End Region

#Region " Mesin"
        '-----------------------------  Mesin 
        <OperationContract()>
        Function GetAllSetupMesin() As DataTable
        <OperationContract()>
        Function SaveSetupMesin(ByVal data As model.CSSD_Mesin) As String
        <OperationContract()>
        Function UpdateSetupMesin(ByVal data As model.CSSD_Mesin) As String
        <OperationContract()>
        Function DeleteSetupMesin(ByVal data As model.CSSD_Mesin) As String
        <OperationContract()>
        Function ViewSetupMesin(ByVal data As model.CSSD_Mesin) As model.CSSD_Mesin

        '----------------------------- EOC  Mesin 
#End Region

#Region "MasterSetInstrumen"
        '-----------------------------  Master Set Instrumen
        <OperationContract()>
        Function GetAllMasterSetInstrumen() As DataTable
        <OperationContract()>
        Function SaveMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String
        <OperationContract()>
        Function SaveDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String
        <OperationContract()>
        Function SaveMasterDetailSetInstrumen(ByVal dataMaster As model.CSSD_MasterSetInstrumen,
                                           ByVal dataDetail As List(Of model.CSSD_DetailSetInstrumen)) As String
        <OperationContract()>
        Function ViewMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As model.CSSD_MasterSetInstrumen
        <OperationContract()>
        Function ViewInstrumenNonSet(ByVal data As model.CSSD_MasterSetInstrumen) As model.CSSD_MasterSetInstrumen
        <OperationContract()>
        Function ViewDetailMasterSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As DataTable
        <OperationContract()>
        Function DeleteMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String
        <OperationContract()>
        Function DeleteDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String
        <OperationContract()>
        Function UpdateDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String
        <OperationContract()>
        Function UpdateMasterDetailSetInstrumen(ByVal dataMaster As model.CSSD_MasterSetInstrumen,
                                           ByVal dataDetail As List(Of model.CSSD_DetailSetInstrumen)) As String
        <OperationContract()>
        Function UpdateMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String

#End Region

#Region " Master Gudang"
        '-----------------------------  Master Gudang 
        <OperationContract()>
        Function GetAllSetupMasterGudang() As DataTable
        <OperationContract()>
        Function GetAllpoly() As DataTable
        <OperationContract()>
        Function SaveSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String
        <OperationContract()>
        Function UpdateSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String
        <OperationContract()>
        Function DeleteSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String
        <OperationContract()>
        Function ViewSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As model.CSSD_MasterGudang
        <OperationContract()>
        Function GetPoly() As DataTable

        '----------------------------- EOC  Master Gudang 
#End Region


    End Interface
End Namespace


