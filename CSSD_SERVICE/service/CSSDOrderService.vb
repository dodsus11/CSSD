Imports System.ServiceModel
Imports KernelEngine
Imports Ninject
Imports DbLibs
Imports RockUtil
Imports System.IO

Namespace service
    <ServiceBehavior(IncludeExceptionDetailInFaults:=True, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class CSSDOrderService
        Implements ICSSDOrderService

        Private kernel As IKernel = ClsKernel.createKernel()
        Private db As DbConn.ClsDbConn
        Private cssdDao As dao.CSSDOrderDao

        Public Sub New()
            db = New DbConn.ClsDbConn(System.Configuration.ConfigurationManager.AppSettings("STR_CSSD").ToString)
            cssdDao = kernel.Get(Of dao.CSSDOrderDao)()
            cssdDao.db = db
        End Sub


#Region "ORDER STERILISASI"

        Public Function SetTanggalDatang(ByVal NoOrder As String, ByVal TglDatang As DateTime) As String Implements ICSSDOrderService.SetTanggalDatang
            Try

                Return cssdDao.SetTanggalDatang(NoOrder, TglDatang)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SetTanggalDatang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveMasterOrder(ByVal data As model.CSSD_MasterOrder) As model.CSSD_MasterOrder Implements ICSSDOrderService.SaveMasterOrder
            Try

                Return cssdDao.SaveMasterOrder(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveMasterOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveDetailOrder(ByVal data As model.CSSD_DetailOrder) As String Implements ICSSDOrderService.SaveDetailOrder
            Try

                If data.NoInventory = String.Empty Then
                    Return "ERROR : No. Inventory wajib di isi!"
                End If

                'If data.Berat = 0 Then
                '    Return "ERROR : Berat Alat wajib di isi!"
                'End If

                If data.QtyTerima < 1 Then
                    Return "ERROR : Kode Inventory : " & data.NoInventory & " - Qty wajib di isi, tidak boleh kurang dari 1!"
                End If

                Return cssdDao.SaveDetailOrder(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveDetailOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ValidateJenisBarang(ByVal notracking As String) As String Implements ICSSDOrderService.ValidateJenisBarang
            Try

                Return cssdDao.ValidateJenisBarang(notracking)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ValidateJenisBarang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function


        Public Function GetAllMasterOrder(ByVal dateFrom As Date, ByVal dateTo As Date, ByVal type_order As String) As System.Data.DataTable Implements ICSSDOrderService.GetAllMasterOrder
            Try

                Return cssdDao.GetAllMasterOrder(dateFrom, dateTo, type_order)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllMasterOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveOrder(ByVal dataMaster As model.CSSD_MasterOrder, ByVal dataDetail As System.Collections.Generic.List(Of model.CSSD_DetailOrder)) As String Implements ICSSDOrderService.SaveOrder
            Dim retValMaster As New model.CSSD_MasterOrder
            Dim retValDetail As String = String.Empty
            Dim retVal As String = String.Empty
            Try

                Me.db.beginTransaction()

                If dataMaster.PetugasOrder = String.Empty Then
                    Return "ERROR : Petugas Order wajib di isi!"
                End If

                If dataMaster.jenisBarang = String.Empty Then
                    Return "ERROR : Jenis Barang wajib di isi!"
                End If

                retValMaster = Me.SaveMasterOrder(dataMaster)

                If retValMaster Is Nothing Then
                    Me.db.rollBackTrans()
                    Return "ERROR: not saving master order"
                End If

                For Each item In dataDetail
                    item.IdOrder = retValMaster.IdOrder
                    retValDetail = Me.SaveDetailOrder(item)
                    If InStr(retValDetail, "ERROR") Then
                        Me.db.rollBackTrans()
                        Return retValDetail
                    End If
                Next

                If retValDetail.Trim = "" Then
                    Me.db.commitTrans()
                    retVal = retValMaster.NoOrder
                End If

            Catch ex As Exception
                Me.db.rollBackTrans()
                LoggingLibs.LogApp.error("SaveOrder:" + ex.Message)
                retVal = ("SERVICE_ERROR:" & ex.ToString)
            End Try
            Return retVal
        End Function

        Public Function SaveDetailOrderHistory(ByVal KodeMesin As String,
                                               ByVal data As List(Of model.CSSD_DetailOrderHistory)
                                               ) As String Implements ICSSDOrderService.SaveDetailOrderHistory
            Dim retVal As String = String.Empty
            Dim NextLoadMesin As Long
            Try
                Me.db.beginTransaction()

                If KodeMesin <> "MANUAL" And KodeMesin <> "-" Then
                    NextLoadMesin = cssdDao.SetNextLoadMesin(KodeMesin)

                    If InStr(NextLoadMesin, "ERROR") Then
                        Me.db.rollBackTrans()
                        Return NextLoadMesin
                    End If

                End If

                For Each item In data

                    If KodeMesin <> "MANUAL" And KodeMesin <> "-" Then
                        item.NoLoad = Convert.ToInt64(NextLoadMesin)
                    Else
                        item.NoLoad = 0
                    End If

                    retVal = cssdDao.SaveDetailOrderHistory(item)

                    If InStr(retVal, "ERROR") Then
                        Me.db.rollBackTrans()
                        Return retVal
                    End If

                Next

                If retVal.Trim = "" Then
                    Me.db.commitTrans()
                End If

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveDetailOrderHistory:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try

            Return retVal
        End Function

        Public Function ViewDetailOrder(ByVal NoOrder As String) As System.Data.DataTable Implements ICSSDOrderService.ViewDetailOrder
            Try

                Return cssdDao.ViewDetailOrder(NoOrder)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewDetailOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewMasterOrder(ByVal NoOrder As String) As model.CSSD_MasterOrder Implements ICSSDOrderService.ViewMasterOrder
            Try

                Return cssdDao.ViewMasterOrder(NoOrder)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewMasterOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewDetailOrderHistory(ByVal data As model.CSSD_DetailOrderHistory) As model.CSSD_DetailOrderHistoryView Implements ICSSDOrderService.ViewDetailOrderHistory
            Try

                Return cssdDao.ViewDetailOrderHistory(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewDetailOrderHistory:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ValidateProcess(ByVal NoTracing As String, ByVal jenis As String) As String Implements ICSSDOrderService.ValidateProcess
            Try

                Return cssdDao.ValidateProcess(NoTracing, jenis)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ValidateProcess:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function TracingDetailView(ByVal NoTracing As String) As model.CSSD_TracingDetailView Implements ICSSDOrderService.TracingDetailView
            Try

                Return cssdDao.ViewTracingDetail(NoTracing)

            Catch ex As Exception
                LoggingLibs.LogApp.error("TracingDetailView:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function DeleteOrderAll(ByVal NoOrder As String, ByVal cancel_by As String) As String Implements ICSSDOrderService.DeleteOrderAll
            Try

                Return cssdDao.DeleteOrderAll(NoOrder, cancel_by)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteOrderAll:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateMasterOrder(ByVal data As model.CSSD_MasterOrder) As String Implements ICSSDOrderService.UpdateMasterOrder
            Try

                Return cssdDao.UpdateMasterOrder(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateMasterOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateDetailOrder(ByVal data As model.CSSD_DetailOrder) As String Implements ICSSDOrderService.UpdateDetailOrder
            Try

                Return cssdDao.UpdateDetailOrder(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateDetailOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function DeleteDetailOrder(ByVal IdDetailOrder As Long, ByVal cancel_by As String) As String Implements ICSSDOrderService.DeleteDetailOrder
            Try

                Return cssdDao.DeleteDetailOrder(IdDetailOrder, cancel_by)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteDetailOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ValidateProcessOrder(ByVal NoTracing As String) As String Implements ICSSDOrderService.ValidateProcessOrder
            Try

                Return cssdDao.ValidateProcessOrder(NoTracing)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ValidateProcessOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ValidateNonSterilisasi(ByVal NoTracing As String) As String Implements ICSSDOrderService.ValidateNonSterilisasi
            Try

                Return cssdDao.ValidateNonSterilisasi(NoTracing)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ValidateNonSterilisasi:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ValidateOrder(ByVal NoInventory As String, ByVal KodeIdentifikasi As String) As String Implements ICSSDOrderService.ValidateOrder
            Try

                Return cssdDao.ValidateOrder(NoInventory, KodeIdentifikasi)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ValidateOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetSingleReuse(ByVal NoInventory As String) As System.Data.DataTable Implements ICSSDOrderService.GetSingleReuse
            Try

                Return cssdDao.GetSingleReuse(NoInventory)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetSingleReuse:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAlatByJenis(ByVal idJenisAlat As Integer) As System.Data.DataTable Implements ICSSDOrderService.GetAlatByJenis
            Try

                Return cssdDao.GetAlatByJenis(idJenisAlat)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAlatByJenis:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

#End Region

#Region "SETTING PACKING"
        Public Function GetDetailForSettingPacking(ByVal NoInventory As String) As System.Data.DataTable Implements ICSSDOrderService.GetDetailForSettingPacking
            Try

                Return cssdDao.GetDetailForSettingPacking(NoInventory)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetDetailForSettingPacking:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveSettingPacking(ByVal dataPetugas1 As model.CSSD_DetailOrderHistory,
                                          ByVal dataPetugas2 As model.CSSD_DetailOrderHistory,
                                          ByVal dataDetail As System.Collections.Generic.List(Of model.CSSD_DetailSetting)) As String Implements ICSSDOrderService.SaveSettingPacking
            Dim retVal As String = String.Empty

            Try

                Me.db.beginTransaction()

                Dim listItem As New List(Of model.CSSD_DetailOrderHistory)
                Dim item As model.CSSD_DetailOrderHistory

                item = New model.CSSD_DetailOrderHistory
                item = dataPetugas1
                listItem.Add(item)

                item = New model.CSSD_DetailOrderHistory
                item = dataPetugas2
                listItem.Add(item)

                For Each item In listItem

                    item.NoLoad = 0

                    retVal = cssdDao.SaveDetailOrderHistory(item)

                    If InStr(retVal, "ERROR") Then
                        Me.db.rollBackTrans()
                        Return retVal
                    End If

                Next

                For Each itemdetail In dataDetail

                    retVal = Me.SaveSettingPackingDetail(itemdetail)
                    If InStr(retVal, "ERROR") Then
                        Me.db.rollBackTrans()
                        Return retVal
                    End If
                Next

                If retVal.Trim = "" Then
                    Me.db.commitTrans()

                End If

            Catch ex As Exception
                Me.db.rollBackTrans()
                LoggingLibs.LogApp.error("SaveSettingPacking:" + ex.Message)
                retVal = ("SERVICE_ERROR:" & ex.ToString)
            End Try
            Return retVal
        End Function

        Public Function SaveSettingPackingDetail(ByVal data As model.CSSD_DetailSetting) As String Implements ICSSDOrderService.SaveSettingPackingDetail
            Try

                'If data.QtyPacking < 1 Then
                '    Return "ERROR : Kode Alat : " & data.KodeAlat & " - Qty wajib di isi, tidak boleh kurang dari 1!"
                'End If

                Return cssdDao.SaveSettingPackingDetail(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveSettingPackingDetail:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetJenisAlat(ByVal NoTracing As String) As String Implements ICSSDOrderService.GetJenisAlat
            Try

                Return cssdDao.GetJenisAlat(NoTracing)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetJenisAlat:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetSumProcess(ByVal StatusOrder As String) As String Implements ICSSDOrderService.GetSumProcess
            Try

                Return cssdDao.GetSumProcess(StatusOrder)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetSumProcess:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

#End Region

#Region "LAPORAN"
        Public Function GetReportBuktiOrder(ByVal NoOrder As String) As System.Data.DataTable Implements ICSSDOrderService.GetReportBuktiOrder
            Try

                Return cssdDao.GetReportBuktiOrder(NoOrder)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportBuktiOrder:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportBuktiDistribusi(ByVal IdDistribusi As Long) As System.Data.DataTable Implements ICSSDOrderService.GetReportBuktiDistribusi
            Try

                Return cssdDao.GetReportBuktiDistribusi(IdDistribusi)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportBuktiDistribusi:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function


        Public Function GetReportTransferGudang(ByVal id_group_transfer As Long) As System.Data.DataTable Implements ICSSDOrderService.GetReportTransferGudang
            Try

                Return cssdDao.GetReportTransferGudang(id_group_transfer)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportTransferGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportNoTracing(ByVal NoOrder As String, ByVal label_type As String) As System.Data.DataTable Implements ICSSDOrderService.GetReportNoTracing
            Try

                Return cssdDao.GetReportNoTracing(NoOrder, label_type)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportNoTracing:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportNoTracing_ByItem(ByVal IdDetailOrder As Long) As System.Data.DataTable Implements ICSSDOrderService.GetReportNoTracing_ByItem
            Try

                Return cssdDao.GetReportNoTracing_ByItem(IdDetailOrder)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportNoTracing_ByItem:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportNoReuse(ByVal NoOrder As String, ByVal JenisReuse As String) As System.Data.DataTable Implements ICSSDOrderService.GetReportNoReuse
            Try

                Return cssdDao.GetReportNoReuse(NoOrder, JenisReuse)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportNoReuse:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportNoReuse_ByItem(ByVal IdDetailOrder As Long) As System.Data.DataTable Implements ICSSDOrderService.GetReportNoReuse_ByItem
            Try

                Return cssdDao.GetReportNoReuse_ByItem(IdDetailOrder)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportNoReuse_ByItem:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportTracingOrderMaster(ByVal FromDate As Date, ByVal ToDate As Date, ByVal Poly As String, ByVal Status As String) As System.Data.DataTable Implements ICSSDOrderService.GetReportTracingOrderMaster
            Try

                Return cssdDao.GetReportTracingOrderMaster(FromDate, ToDate, Poly, Status)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportTracingOrderMaster:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetStatusAll() As System.Data.DataTable Implements ICSSDOrderService.GetStatusAll
            Try

                Return cssdDao.GetStatusAll()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetStatusAll:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetTracingOrderDetail(ByVal NoTracing As String) As model.CSSD_TracingOrderDetail Implements ICSSDOrderService.GetTracingOrderDetail
            Try

                Return cssdDao.GetTracingOrderDetail(NoTracing)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetTracingOrderDetail:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportCekLIst(ByVal idJenisAlat As Integer, ByVal NoTrace As String) As System.Data.DataTable Implements ICSSDOrderService.GetReportCekLIst
            Try

                Return cssdDao.GetReportCekLIst(idJenisAlat, NoTrace)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportCekLIst:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetLaporanPelayananInstrumenDenganMesin(ByVal dtFrom As String, ByVal dtTo As String, ByVal KodeMesin As String) As System.Data.DataTable Implements ICSSDOrderService.GetLaporanPelayananInstrumenDenganMesin
            Try

                Return cssdDao.GetLaporanPelayananInstrumenDenganMesin(dtFrom, dtTo, KodeMesin)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetLaporanPelayananInstrumenDenganMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetReportMachine(ByVal dtFrom As String, ByVal dtTo As String, ByVal GroupMesin As Integer, ByVal KodeMesin As String) As System.Data.DataTable Implements ICSSDOrderService.GetReportMachine
            Try

                Return cssdDao.GetReportMachine(dtFrom, dtTo, GroupMesin, KodeMesin)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetReportMachine:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetMesin(ByVal GroupMesin As Integer) As System.Data.DataTable Implements ICSSDOrderService.GetMesin
            Try

                Return cssdDao.GetMesin(GroupMesin)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetGroupMesin() As System.Data.DataTable Implements ICSSDOrderService.GetGroupMesin
            Try

                Return cssdDao.GetGroupMesin()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetGroupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function execProcedure(ByVal spName As String, ByVal values() As Object) As System.Data.DataTable Implements ICSSDOrderService.execProcedure
            Try

                Return cssdDao.execProcedure(spName, values)

            Catch ex As Exception
                LoggingLibs.LogApp.error(String.Format("execProcedure : {0}; SPName = {1}", ex.Message, spName))
                Throw New FaultException(ex.Message)
            End Try
        End Function

#End Region

#Region "GUDANG"
        Public Function GetAllMasterGudang() As System.Data.DataTable Implements ICSSDOrderService.GetAllMasterGudang
            Try

                Return cssdDao.GetAllMasterGudang()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllMasterGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        'Public Function SaveToGudangSteril(ByVal data As List(Of model.CSSD_GudangSteril)) As String Implements ICSSDOrderService.SaveToGudangSteril
        '    Dim retVal As String = String.Empty
        '    Try
        '        Me.db.beginTransaction()
        '        For Each item In data

        '            retVal = cssdDao.SaveToGudangSteril(item)

        '            If InStr(retVal, "ERROR") Then
        '                Me.db.rollBackTrans()
        '                Return retVal
        '            End If

        '        Next

        '        If retVal.Trim = "" Then
        '            Me.db.commitTrans()

        '        End If

        '    Catch ex As Exception
        '        Me.db.rollBackTrans()
        '        LoggingLibs.LogApp.error("SaveToGudangSteril:" + ex.Message)
        '        Throw New FaultException(ex.Message)
        '    End Try
        '    Return retVal
        'End Function

        Public Function SaveToGudangSteril(ByVal data As List(Of model.CSSD_GudangSteril)) As Long Implements ICSSDOrderService.SaveToGudangSteril
            db.beginTransaction()

            Try
                Dim id_group_transfer As Long = Me.cssdDao.SaveToGudangSteril(data)
                db.commitTrans()
                Return id_group_transfer
            Catch ex As Exception
                db.rollBackTrans()
                LoggingLibs.LogApp.error("SaveToGudangSteril:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllGudangByKode(ByVal KodeGudang As String) As System.Data.DataTable Implements ICSSDOrderService.GetAllGudangByKode
            Try

                Return cssdDao.GetAllGudangByKode(KodeGudang)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllGudangByKode:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
#End Region

#Region "DISTRIBUSI DAN ORDER ALAT"
        Public Function GetAllPasienOperasi() As System.Data.DataTable Implements ICSSDOrderService.GetAllPasienOperasi
            Try

                Return cssdDao.GetAllPasienOperasi()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllPasienOperasi:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveDistribusiLangsung(ByVal dataHeader As model.CSSD_OrderAlatOperasiHeader,
                                        ByVal dataDetail As List(Of model.CSSD_OrderAlatOperasiDetail)) As String Implements ICSSDOrderService.SaveDistribusiLangsung
            Dim IdOrder As String
            Dim retValDetail As String = String.Empty
            Dim retVal As String = String.Empty
            Try

                Me.db.beginTransaction()

                IdOrder = cssdDao.SaveOrderAlatHeader(dataHeader)

                If InStr(IdOrder, "ERROR") Then
                    Me.db.rollBackTrans()
                    Return "ERROR: Failed to Save Order Alat Header"
                End If

                For Each item In dataDetail
                    item.IdOrder = IdOrder
                    retValDetail = cssdDao.SaveOrderAlatDetail(item)
                    If InStr(retValDetail, "ERROR") Then
                        Me.db.rollBackTrans()
                        Return retValDetail
                    End If
                Next

                If InStr(retValDetail, "ERROR") Then
                    Me.db.rollBackTrans()
                    retVal = "ERROR: Failed to Save Order Alat Detail "
                End If

                Dim distribusi As New model.CSSD_Distribusi
                distribusi.IdOrder = IdOrder
                distribusi.UserInput = dataHeader.UserInput
                distribusi.UserPenerima = dataHeader.UserPenerima
                distribusi.PetugasSterilisasi = dataHeader.PetugasSterilisasi
                retVal = cssdDao.SaveDistribusi(distribusi)

                If retVal.Trim <> "" Then
                    Me.db.commitTrans()
                Else
                    Me.db.rollBackTrans()
                End If

            Catch ex As Exception
                Me.db.rollBackTrans()
                LoggingLibs.LogApp.error("SaveDistribusiLangsung:" + ex.Message)
                retVal = ("SERVICE_ERROR:" & ex.ToString)
            End Try
            Return retVal
        End Function

        Public Function BatalDistribusi(ByVal dataHeader As model.CSSD_OrderAlatOperasiDetail) As String Implements ICSSDOrderService.BatalDistribusi
            Dim IdOrder As String
            Dim retValDetail As String = String.Empty
            Dim retVal As String = String.Empty
            Try

                IdOrder = cssdDao.BatalDistribusi(dataHeader)

                If InStr(IdOrder, "ERROR") Then
                    Return "ERROR: Failed to Batal Order"
                End If

            Catch ex As Exception
                LoggingLibs.LogApp.error("BatalDistribusi:" + ex.Message)
                retVal = ("SERVICE_ERROR:" & ex.ToString)
            End Try
            Return retVal
        End Function

#End Region

#Region "INVENTORY"
        Public Function GetInventoryOnGudang(ByVal KodeGudang As String) As System.Data.DataTable Implements ICSSDOrderService.GetInventoryOnGudang
            Try

                Return cssdDao.GetInventoryOnGudang(KodeGudang)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetInventoryOnGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetNoTrackingOnGudang(ByVal KodeGudang As String, ByVal NoTracing As String) As System.Data.DataTable Implements ICSSDOrderService.GetNoTrackingOnGudang
            Try

                Return cssdDao.GetNoTrackingOnGudang(KodeGudang, NoTracing)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetNoTrackingOnGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
#End Region

#Region "DISTRIBUSI"
        Public Function ViewPasienOperasi(ByVal IdOperasi As Long, ByVal NoRegister As Long) As model.CSSD_PasienOperasiView Implements ICSSDOrderService.ViewPasienOperasi
            Try

                Return cssdDao.ViewPasienOperasi(IdOperasi, NoRegister)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewPasienOperasi:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllDistribusiAlat(ByVal tglAwal As Date, ByVal tglAkhir As Date) As System.Data.DataTable Implements ICSSDOrderService.GetAllDistribusiAlat
            Try

                Return cssdDao.GetAllDistribusiAlat(tglAwal, tglAkhir)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllDistribusiAlat:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetDetailDistribusi(ByVal idOrder As Long) As System.Data.DataTable Implements ICSSDOrderService.GetDetailDistribusi
            Try

                Return cssdDao.GetDetailDistribusi(idOrder)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetDetailDistribusi:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllDistribusiRuangan(ByVal tglAwal As Date, ByVal tglAkhir As Date) As System.Data.DataTable Implements ICSSDOrderService.GetAllDistribusiRuangan
            Try

                Return cssdDao.GetAllDistribusiRuangan(tglAwal, tglAkhir)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllDistribusiRuangan:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllDistribusiLangsung(ByVal tglAwal As Date, ByVal tglAkhir As Date) As System.Data.DataTable Implements ICSSDOrderService.GetAllDistribusiLangsung
            Try

                Return cssdDao.GetAllDistribusiLangsung(tglAwal, tglAkhir)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllDistribusiLangsung:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

#End Region


        Public Function GetPasienMasihDirawat() As System.Data.DataTable Implements ICSSDOrderService.GetPasienMasihDirawat
            Try

                Return cssdDao.GetPasienMasihDirawat()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetPasienMasihDirawat:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetJmlBarangDiGudang(ByVal NoTracing As String, ByVal KodeGudang As String) As Integer Implements ICSSDOrderService.GetJmlBarangDiGudang
            Try

                Return cssdDao.GetJmlBarangDiGudang(NoTracing, KodeGudang)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetJmlBarangDiGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

    End Class
End Namespace
