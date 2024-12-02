Imports System.ServiceModel

Namespace service
    <ServiceContract()>
    Public Interface ICSSDOrderService

#Region "Order Sterilisasi"
        <OperationContract()>
        Function SaveMasterOrder(ByVal data As model.CSSD_MasterOrder) As model.CSSD_MasterOrder
        <OperationContract()>
        Function SaveDetailOrder(ByVal data As model.CSSD_DetailOrder) As String
        <OperationContract()>
        Function GetAllMasterOrder(ByVal dateFrom As Date, ByVal dateTo As Date, ByVal type_order As String) As DataTable
        <OperationContract()>
        Function SaveOrder(ByVal dataMaster As model.CSSD_MasterOrder,
                                           ByVal dataDetail As List(Of model.CSSD_DetailOrder)) As String
        <OperationContract()>
        Function SaveDetailOrderHistory(ByVal KodeMesin As String, ByVal data As List(Of model.CSSD_DetailOrderHistory)) As String
        <OperationContract()>
        Function ViewMasterOrder(ByVal NoOrder As String) As model.CSSD_MasterOrder
        <OperationContract()>
        Function ViewDetailOrder(ByVal NoOrder As String) As DataTable
        <OperationContract()>
        Function SetTanggalDatang(ByVal NoOrder As String, ByVal TglDatang As DateTime) As String
        <OperationContract()>
        Function GetJmlBarangDiGudang(ByVal NoTracing As String, ByVal KodeGudang As String) As Integer
        <OperationContract()>
        Function DeleteOrderAll(ByVal NoOrder As String, ByVal cancel_by As String) As String
        <OperationContract()>
        Function UpdateMasterOrder(ByVal data As model.CSSD_MasterOrder) As String
        <OperationContract()>
        Function UpdateDetailOrder(ByVal data As model.CSSD_DetailOrder) As String
        <OperationContract()>
        Function DeleteDetailOrder(ByVal IdDetailOrder As Long, ByVal cancel_by As String) As String
        <OperationContract()>
        Function ValidateOrder(ByVal NoInventory As String, ByVal KodeIdentifikasi As String) As String
        <OperationContract()>
        Function GetSingleReuse(ByVal NoInventory As String) As DataTable
        <OperationContract()>
        Function GetAlatByJenis(ByVal idJenisAlat As Integer) As DataTable
#End Region

#Region "SETTING PACKING"
        <OperationContract()>
        Function GetDetailForSettingPacking(ByVal NoInventory As String) As DataTable
        <OperationContract()>
        Function ViewDetailOrderHistory(ByVal data As model.CSSD_DetailOrderHistory) As model.CSSD_DetailOrderHistoryView
        <OperationContract()>
        Function SaveSettingPackingDetail(ByVal data As model.CSSD_DetailSetting) As String
        <OperationContract()>
        Function SaveSettingPacking(ByVal dataPetugas1 As model.CSSD_DetailOrderHistory,
                                    ByVal dataPetugas2 As model.CSSD_DetailOrderHistory,
                                           ByVal dataDetail As List(Of model.CSSD_DetailSetting)) As String
        <OperationContract()>
        Function GetJenisAlat(ByVal NoTracing As String) As String
        <OperationContract()>
        Function GetSumProcess(ByVal StatusOrder As String) As String
#End Region
        
#Region "LAPORAN"
        <OperationContract()>
        Function GetLaporanPelayananInstrumenDenganMesin(ByVal dtFrom As String,
                                                         ByVal dtTo As String,
                                                         ByVal KodeMesin As String) As DataTable
        <OperationContract()>
        Function GetReportMachine(ByVal dtFrom As String, ByVal dtTo As String, ByVal GroupMesin As Integer, ByVal KodeMesin As String) As DataTable
        <OperationContract()>
        Function GetMesin(ByVal GroupMesin As Integer) As DataTable
        <OperationContract()>
        Function GetGroupMesin() As DataTable
        <OperationContract()>
        Function GetReportBuktiOrder(ByVal NoOrder As String) As DataTable
        <OperationContract()>
        Function GetReportBuktiDistribusi(ByVal IdDistribusi As Long) As DataTable
        <OperationContract()>
        Function GetReportTransferGudang(ByVal id_group_transfer As Long) As DataTable
        <OperationContract()>
        Function GetReportNoReuse(ByVal NoOrder As String, ByVal JenisReuse As String) As DataTable
        <OperationContract()>
        Function GetReportNoReuse_ByItem(ByVal IdDetailOrder As Long) As DataTable
        <OperationContract()>
        Function GetReportNoTracing_ByItem(ByVal IdDetailOrder As Long) As DataTable
        <OperationContract()>
        Function GetReportNoTracing(ByVal NoOrder As String, ByVal label_type As String) As DataTable
        <OperationContract()>
        Function GetReportTracingOrderMaster(ByVal FromDate As Date, ByVal ToDate As Date, ByVal Poly As String, ByVal Status As String) As DataTable
        <OperationContract()>
        Function GetStatusAll() As DataTable
        <OperationContract()>
        Function GetTracingOrderDetail(ByVal NoTracing As String) As model.CSSD_TracingOrderDetail
        <OperationContract()>
        Function GetReportCekLIst(ByVal idJenisAlat As Integer, ByVal NoTrace As String) As DataTable
        <OperationContract()>
        Function execProcedure(ByVal spName As String, ByVal values() As Object) As DataTable
#End Region
        
        <OperationContract()>
        Function ValidateProcess(ByVal NoTracing As String, ByVal jenis As String) As String
        '<OperationContract()>
        'Function SaveToGudangSteril(ByVal data As List(Of model.CSSD_GudangSteril)) As String
        <OperationContract()>
        Function SaveToGudangSteril(ByVal data As List(Of model.CSSD_GudangSteril)) As Long
        <OperationContract()>
        Function TracingDetailView(ByVal NoTracing As String) As model.CSSD_TracingDetailView
        <OperationContract()>
        Function GetAllMasterGudang() As DataTable
        <OperationContract()>
        Function GetAllGudangByKode(ByVal KodeGudang As String) As DataTable
        <OperationContract()>
        Function GetInventoryOnGudang(ByVal KodeGudang As String) As DataTable
        <OperationContract()>
        Function ValidateProcessOrder(ByVal NoTracing As String) As String
        <OperationContract()>
        Function ValidateNonSterilisasi(ByVal NoTracing As String) As String
        <OperationContract()>
        Function GetNoTrackingOnGudang(ByVal KodeGudang As String, ByVal NoTracing As String) As DataTable
       
#Region "DISTRIBUSI dan ORDER ALAT"
        <OperationContract()>
        Function GetAllPasienOperasi() As DataTable
        <OperationContract()>
        Function ViewPasienOperasi(ByVal IdOperasi As Long, ByVal NoRegister As Long) As model.CSSD_PasienOperasiView
        <OperationContract()>
        Function GetAllDistribusiAlat(ByVal tglAwal As Date, tglAkhir As Date) As DataTable
        '<OperationContract()>
        'Function SaveOrderAlatHeader(ByVal data As model.CSSD_OrderAlatOperasiHeader) As String
        '<OperationContract()>
        'Function SaveOrderAlatDetail(ByVal data As model.CSSD_OrderAlatOperasiDetail) As String
        '<OperationContract()>
        'Function SaveDistribusi(ByVal data As model.CSSD_Distribusi) As String
        <OperationContract()>
        Function SaveDistribusiLangsung(ByVal dataHeader As model.CSSD_OrderAlatOperasiHeader,
                                        ByVal dataDetail As List(Of model.CSSD_OrderAlatOperasiDetail)) As String

        <OperationContract()>
        Function BatalDistribusi(ByVal dataHeader As model.CSSD_OrderAlatOperasiDetail) As String
        <OperationContract()>
        Function GetDetailDistribusi(ByVal idOrder As Long) As DataTable

        <OperationContract()>
        Function GetPasienMasihDirawat() As DataTable

        <OperationContract()>
        Function ValidateJenisBarang(ByVal NoTracing As String) As String

        <OperationContract()>
        Function GetAllDistribusiRuangan(ByVal tglAwal As Date, tglAkhir As Date) As DataTable
        <OperationContract()>
        Function GetAllDistribusiLangsung(ByVal tglAwal As Date, tglAkhir As Date) As DataTable

#End Region
       
    End Interface

End Namespace



