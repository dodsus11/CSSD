Imports DbLibs
Namespace dao
    Public Class CSSDOrderDao
        Public Property db As DbConn.ClsDbConn

#Region "GUDANG"

        Public Function GetAllGudangByKode(ByVal KodeGudang As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_GudangGetAllByKode", New Object() {KodeGudang})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetInventoryOnGudang(ByVal KodeGudang As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_GetInventoryOnGudang", New Object() {KodeGudang})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetNoTrackingOnGudang(ByVal KodeGudang As String, ByVal NoTracing As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_GetNoTrackingOnGudang", New Object() {KodeGudang, NoTracing})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAllMasterGudang() As DataTable
            Try
                Dim retVal As DataTable

                'retVal = db.execQuery("CSSD_MasterGudangGetAll")
                retVal = db.execQuery("CSSD_MasterGudangGetAll_Rev1")
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function SaveToGudangSteril(ByVal data As model.CSSD_GudangSteril) As String
        '    Try
        '        Dim retVal As String = String.Empty

        '        retVal = db.execScalar("CSSD_GudangSterilSave", New Object() {
        '                                        data.NoTracing,
        '                                        data.NoInventory,
        '                                        data.KodeAlat,
        '                                        data.KodeGudang,
        '                                        data.UserPengirim,
        '                                        data.UserPenerima
        '                                     })
        '        Return retVal

        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function SaveToGudangSteril(ByVal data As List(Of model.CSSD_GudangSteril)) As Long
            Try

                Dim id_group_transfer As Long = db.execScalar("CSSD_Gen_GroupTrans")

                For Each item As model.CSSD_GudangSteril In data
                    'db.execScalar("CSSD_GudangSterilSave", New Object()
                    db.execScalar("CSSD_GudangSterilSave_rev1", New Object() {item.NoTracing,
                                                                         item.NoInventory,
                                                                         item.KodeAlat,
                                                                         item.KodeGudang,
                                                                         item.UserPengirim,
                                                                         item.UserPengirim_2,
                                                                         item.UserPenerima,
                                                                         item.KodeGudangAsal,
                                                                         item.KodePetugasSterilisasi1,
                                                                         item.KodePetugasSterilisasi2,
                                                                         id_group_transfer})
                Next
                
                Return id_group_transfer

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "MASTER ORDER STERILISASI"

        Public Function GetJmlBarangDiGudang(ByVal NoTracing As String, ByVal KodeGudang As String) As Integer
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_jmlAlatDiGudangByTracingNo", New Object() {
                                                NoTracing, KodeGudang
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ValidateProcess(ByVal NoTracing As String, ByVal jenis As String) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_ValidateProses", New Object() {
                                                NoTracing,
                                                jenis
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveMasterOrder(ByVal data As model.CSSD_MasterOrder) As model.CSSD_MasterOrder
            Try
                Dim dt As DataTable
                Dim resultItem As New model.CSSD_MasterOrder
                'dt = db.execQuery("CSSD_MasterOrderSave", New Object()
                dt = db.execQuery("CSSD_MasterOrderSave_rev1", New Object() {
                                                data.PetugasOrder,
                                                data.Poly.polyCode,
                                                data.Telp,
                                                data.UserInput,
                                                data.TglDatang,
                                                data.jenisBarang,
                                                data.type_order,
                                                data.PetugasSterilisasi
                                             })

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        resultItem.IdOrder = .Item("IdOrder")
                        resultItem.NoOrder = .Item("NoOrder").ToString()
                    End With

                End If

                Return resultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAllMasterOrder(ByVal dateFrom As Date, ByVal dateTo As Date, ByVal type_order As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_MasterOrderGetAll_rev1", New Object() {dateFrom, dateTo, type_order})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewMasterOrder(ByVal NoOrder As String) As model.CSSD_MasterOrder
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_MasterOrder

                dt = db.execQuery("CSSD_MasterOrderView", New Object() {NoOrder})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.NoOrder = .Item("NoOrder").ToString()
                        ResultItem.PetugasOrder = .Item("PetugasOrder").ToString()
                        ResultItem.Poly.polyName = .Item("polyName").ToString()
                        ResultItem.Telp = .Item("Telp").ToString()
                        ResultItem.TglDatang = .Item("TglDatang").ToString()
                        ResultItem.Poly.polyCode = .Item("Poly").ToString()
                        ResultItem.IdOrder = .Item("IdOrder").ToString()
                        ResultItem.jenisBarang = .Item("jenis_barang").ToString()
                        ResultItem.type_order = .Item("type_order").ToString()
                        ResultItem.PetugasSterilisasi = .Item("NamaPetugas").ToString()
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Function SetTanggalDatang(ByVal NoOrder As String, ByVal TglDatang As DateTime) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_SetTanggalDatang", New Object() {
                                                NoOrder,
                                                TglDatang
                                             })

                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteOrderAll(ByVal NoOrder As String, ByVal cancel_by As String) As String
            Try

                Return Me.db.execScalar("CSSD_DeleteOrderAll", New Object() {NoOrder, cancel_by})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateMasterOrder(ByVal data As model.CSSD_MasterOrder) As String
            Try

                Return Me.db.execScalar("CSSD_MasterOrderUpdate_rev1", New Object() {
                                                data.NoOrder,
                                                data.PetugasOrder,
                                                data.Poly.polyCode,
                                                data.Telp,
                                                data.update_by,
                                                data.TglDatang,
                                                data.jenisBarang,
                                                data.type_order,
                                                data.PetugasSterilisasi
                                             })
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ValidateProcessOrder(ByVal NoTracing As String) As String
            Try

                Return Me.db.execScalar("CSSD_ValidateProcessOrder", New Object() {NoTracing})


            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ValidateNonSterilisasi(ByVal NoTracing As String) As String
            Try

                Return Me.db.execScalar("CSSD_ValidateNonSterilisasi", New Object() {NoTracing})


            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ValidateOrder(ByVal NoInventory As String, ByVal KodeIdentifikasi As String) As String
            Try

                Return Me.db.execScalar("CSSD_ValidateOrder", New Object() {NoInventory, KodeIdentifikasi})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "DETAIL ORDER STERILISASI"
        Public Function SaveDetailOrder(ByVal data As model.CSSD_DetailOrder) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_DetailOrderSave", New Object() {
                                                data.IdOrder,
                                                data.NoInventory,
                                                data.QtyTerima,
                                                data.Berat,
                                                data.KodeSatuan,
                                                data.Keterangan,
                                                "ORDER",
                                                data.IdJenisAlat,
                                                data.create_by,
                                                data.JenisReuse,
                                                data.KodeIdentifikasi
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewDetailOrder(ByVal NoOrder As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_DetailOrderView", New Object() {NoOrder})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewTracingDetail(ByVal NoTracing As String) As model.CSSD_TracingDetailView
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_TracingDetailView

                dt = db.execQuery("CSSD_TracingDetailView", New Object() {NoTracing})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.IdDetailOrder = .Item("IdDetailOrder")
                        ResultItem.NoTracing = .Item("NoTracing").ToString()
                        ResultItem.NoInventory = .Item("NoInventory").ToString()
                        ResultItem.KodeAlat = .Item("KodeAlat").ToString()
                        ResultItem.NamaAlat = .Item("NamaAlat").ToString()
                        ResultItem.IdJenisAlat = .Item("IdJenisAlat")
                        ResultItem.Jenis = .Item("JenisAlat")
                        ResultItem.Kode_Identifikasi_Alat = .Item("Kode_Identifikasi_Alat")
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateDetailOrder(ByVal data As model.CSSD_DetailOrder) As String
            Try
                Return Me.db.execScalar("CSSD_DetailOrderUpdate", New Object() {
                                                                                data.IdDetailOrder,
                                                                                data.QtyTerima,
                                                                                data.Berat,
                                                                                data.Keterangan,
                                                                                data.update_by
                                                                              })
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteDetailOrder(ByVal IdDetailOrder As Long, ByVal cancel_by As String) As String
            Try

                Return Me.db.execScalar("CSSD_DetailOrderDelete", New Object() {IdDetailOrder, cancel_by})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetSingleReuse(ByVal NoInventory As String) As DataTable
            Try

                Return db.execQuery("CSSD_InventoryGetSingleReuse", New Object() {NoInventory})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAlatByJenis(ByVal idJenisAlat As Integer) As DataTable
            Try

                Return db.execQuery("CSSD_AlatGetByIdJenis", New Object() {idJenisAlat})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "DETAIL ORDER HISTORY STERILISASI"

        Public Function SetNextLoadMesin(ByVal KodeMesin As String) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetNextLoadMesin", New Object() {
                                                KodeMesin
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveDetailOrderHistory(ByVal data As model.CSSD_DetailOrderHistory) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_DetailOrderHistorySave", New Object() {
                                                data.IdDetailOrder,
                                                data.KodeMesin,
                                                data.KodePetugas,
                                                data.jenis,
                                                data.StatusOrder,
                                                data.NoLoad,
                                                data.create_by
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewDetailOrderHistory(ByVal data As model.CSSD_DetailOrderHistory) As model.CSSD_DetailOrderHistoryView
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_DetailOrderHistoryView

                dt = db.execQuery("CSSD_DetailOrderHistoryView", New Object() {data.NoTrace, data.jenis})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.KodePetugas = .Item("KodePetugas").ToString()
                        ResultItem.NamaPetugas = .Item("NamaPetugas").ToString()
                        ResultItem.KodeMesin = .Item("KodeMesin").ToString()
                        ResultItem.NamaMesin = .Item("NamaMesin").ToString()
                        ResultItem.Jenis = .Item("Jenis").ToString()
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "SETTING PACKING"
        Public Function GetDetailForSettingPacking(ByVal NoInventory As String) As DataTable
            Try
                Dim retVal As DataTable

                'retVal = db.execQuery("CSSD_GetDetailForSettingPacking", New Object() {NoInventory})
                retVal = db.execQuery("CSSD_GetDetailForSettingPacking_Rev1", New Object() {NoInventory})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveSettingPackingDetail(ByVal data As model.CSSD_DetailSetting) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SettingPackingSave", New Object() {
                                                data.IdInduk,
                                                data.KodeAlat,
                                                data.QtyPacking,
                                                data.Keterangan,
                                                data.IdJenisAlat,
                                                data.iddetailorder
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetJenisAlat(ByVal NoTracing As String) As String
            Try

                Return Me.db.execScalar("CSSD_GetJenisAlat", New Object() {NoTracing})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetSumProcess(ByVal StatusOrder As String) As String
            Try

                Return Me.db.execScalar("CSSD_GetSumProcess", New Object() {StatusOrder})

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "LAPORAN"

        Public Function GetLaporanPelayananInstrumenDenganMesin(ByVal dtFrom As String, ByVal dtTo As String, ByVal KodeMesin As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_LaporanPelayananInstrumenDenganMesin", New Object() {dtFrom, dtTo, KodeMesin})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportMachine(ByVal dtFrom As String, ByVal dtTo As String, ByVal GroupMesin As Integer, ByVal KodeMesin As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_GetReportMachine", New Object() {dtFrom, dtTo, GroupMesin, KodeMesin})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetMesin(ByVal GroupMesin As Integer) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_GetMesin", New Object() {GroupMesin})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetGroupMesin() As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_GetGroupMesin")
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportBuktiOrder(ByVal NoOrder As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_ReportBuktiOrder", New Object() {NoOrder})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportBuktiDistribusi(ByVal IdDistribusi As Long) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_ReportBuktiDistribusi", New Object() {IdDistribusi})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportTransferGudang(ByVal id_group_transfer As Long) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_ReportTransferGudang", New Object() {id_group_transfer})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportNoTracing(ByVal NoOrder As String, ByVal label_type As String) As DataTable
            Try
                Dim retVal As DataTable

                'retVal = db.execQuery("CSSD_ReportNoTracing", New Object() {NoOrder, label_type})
                retVal = db.execQuery("CSSD_ReportNoTracing_Rev1", New Object() {NoOrder, label_type})

                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportNoTracing_ByItem(ByVal IdDetailOrder As Long) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_ReportNoTracing_ByItem", New Object() {IdDetailOrder})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportNoReuse(ByVal NoOrder As String, ByVal JenisReuse As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_ReportNoReuse", New Object() {NoOrder, JenisReuse})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportNoReuse_ByItem(ByVal IdDetailOrder As Long) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_ReportNoReuse_ByItem", New Object() {IdDetailOrder})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportTracingOrderMaster(ByVal FromDate As Date, ByVal ToDate As Date, ByVal Poly As String, ByVal Status As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_TracingOrderGetAll", New Object() {FromDate, ToDate, Poly, Status})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetStatusAll() As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_GetStatusAll")
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetTracingOrderDetail(ByVal NoTracing As String) As model.CSSD_TracingOrderDetail
            Try

                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_TracingOrderDetail

                'dt = db.execQuery("CSSD_TracingOrderDetail", New Object() {NoTracing})
                dt = db.execQuery("CSSD_TracingOrderDetail_Rev1", New Object() {NoTracing})
                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.IdDetailOrder = .Item("IdDetailOrder")
                        ResultItem.NoOrder = .Item("NoOrder")
                        ResultItem.NoTracing = .Item("NoTracing")
                        ResultItem.PetugasOrder = .Item("PetugasOrder")
                        ResultItem.poly_name = .Item("NamaUnit")
                        ResultItem.Telp = .Item("Telp")
                        ResultItem.TglInput = .Item("TglInput").ToString

                        ResultItem.KodeAlat = .Item("KodeAlat")
                        ResultItem.NamaAlat = .Item("NamaAlat")
                        ResultItem.JenisAlat = .Item("JenisAlat")
                        ResultItem.Kode_Identifikasi_Alat = .Item("Kode_Identifikasi_Alat")
                        ResultItem.standar_reuse = .Item("standar_reuse")
                        ResultItem.jml_reuse = .Item("jml_reuse")

                        ResultItem.TglPencucian = .Item("TglPencucian").ToString
                        ResultItem.KodePetugasCuci = .Item("KodePetugasCuci").ToString
                        ResultItem.NamaPetugasCuci = .Item("NamaPetugasCuci").ToString
                        ResultItem.KodeMesinCuci = .Item("KodeMesinCuci").ToString
                        ResultItem.NamaMesinCuci = .Item("NamaMesinCuci").ToString
                        ResultItem.NamaGroupMesinCuci = .Item("NamaGroupMesinCuci").ToString
                        ResultItem.TipeCuci = .Item("TipeCuci").ToString

                        ResultItem.TglSettingPacking = .Item("TglSettingPacking").ToString
                        ResultItem.KodePetugasSetting1 = .Item("KodePetugasSetting1").ToString
                        ResultItem.PetugasSetting1 = .Item("PetugasSetting1").ToString
                        ResultItem.KodePetugasSetting2 = .Item("KodePetugasSetting2").ToString
                        ResultItem.PetugasSetting2 = .Item("PetugasSetting2").ToString

                        ResultItem.TglSterilisasi = .Item("TglSterilisasi").ToString
                        ResultItem.KodePetugasSteril = .Item("KodePetugasSteril").ToString
                        ResultItem.PetugasSteril = .Item("PetugasSteril").ToString
                        ResultItem.KodePetugasSteril2 = .Item("KodePetugasSteril2").ToString
                        ResultItem.PetugasSteril2 = .Item("PetugasSteril2").ToString

                        ResultItem.KodeMesinSteril = .Item("KodeMesinSteril").ToString
                        ResultItem.NamaMesinSteril = .Item("NamaMesinSteril").ToString
                        ResultItem.NamaGroupMesinSteril = .Item("NamaGroupMesinSteril").ToString
                        ResultItem.TipeSteril = .Item("TipeSteril").ToString
                        ResultItem.TglmasukGudang = .Item("TglmasukGudang").ToString
                        ResultItem.NamaGudang = .Item("NamaGudang").ToString
                        ResultItem.TglDistribusi = .Item("TglDistribusi").ToString
                        ResultItem.StatusOrder = .Item("StatusOrder").ToString
                        ResultItem.idJenisAlat = .Item("idJenisAlat")
                        ResultItem.type_order = .Item("type_order")
                        ResultItem.tglKadaluarsa = .Item("Tgl_Kadaluarsa")
                        ResultItem.Petugas_gudang_cssd = .Item("petugas_gudang_cssd")
                        ResultItem.Petugas_input_cssd = .Item("user_input")
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetReportCekLIst(ByVal idJenisAlat As Integer, ByVal NoTrace As String) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_ReportCeklist", New Object() {idJenisAlat, NoTrace})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function execProcedure(ByVal spName As String, ByVal values() As Object) As DataTable
            Try

                Return db.execQuery(spName, values)

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetReportKinerjaPetugasCSSD(ByVal tglfrom As Date, ByVal tglto As Date) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_Laporan_Kinerja", New Object() {tglfrom, tglto})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "DISTRIBUSI"

        Public Function GetDetailDistribusi(ByVal idOrder As Long) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_DistribusiDetailView", New Object() {idOrder})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAllPasienOperasi() As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_PasienOperasiGet")
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetAllDistribusiAlat(ByVal tglAwal As Date, tglAkhir As Date) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_DistribusiAlatOperasiGetAll", New Object() {tglAwal, tglAkhir})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewPasienOperasi(ByVal IdOperasi As Long, ByVal NoRegister As Long) As model.CSSD_PasienOperasiView
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_PasienOperasiView

                dt = db.execQuery("CSSD_PasienOperasiView", New Object() {IdOperasi, NoRegister})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.id = .Item("id").ToString()
                        ResultItem.NoRegister = .Item("NoRegister").ToString()
                        ResultItem.Nama = .Item("Nama").ToString()
                        ResultItem.Umur = .Item("Umur").ToString()
                        ResultItem.ruang = .Item("ruang").ToString()
                        ResultItem.diagnosa = .Item("diagnosa").ToString()
                        ResultItem.tindakan = .Item("tindakan").ToString()
                        ResultItem.OperatorUser = .Item("OperatorUser").ToString()
                        ResultItem.StaffUser = .Item("StaffUser").ToString()
                        ResultItem.theater_name = .Item("theater_name").ToString()
                        ResultItem.theater_location = .Item("theater_location").ToString()
                        ResultItem.TanggalOperasi = .Item("TanggalOperasi").ToString()
                        ResultItem.JamOperasi = .Item("JamOperasi").ToString()
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveOrderAlatHeader(ByVal data As model.CSSD_OrderAlatOperasiHeader) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_OrderAlatHeaderSave", New Object() {
                                                data.IdOperasi,
                                                data.NoRegister,
                                                data.Status,
                                                data.UserInput})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ValidateJenisBarang(ByVal noTracking As String) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_OrderValidateJenisBarang", New Object() {noTracking})

                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveOrderAlatDetail(ByVal data As model.CSSD_OrderAlatOperasiDetail) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_OrderAlatDetailSave", New Object() {
                                                data.IdOrder,
                                                data.NoTracing,
                                                data.NoInventory,
                                                data.Keterangan
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveDistribusi(ByVal data As model.CSSD_Distribusi) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_DistribusiSave_rev1", New Object() {
                                                data.IdOrder,
                                                data.UserInput,
                                                data.UserPenerima,
                                                data.PetugasSterilisasi
                                                }
                                            )


                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetPasienMasihDirawat() As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_getPasienMasihDirawat")
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAllDistribusiRuangan(ByVal tglAwal As Date, tglAkhir As Date) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_DistribusiRuanganGetAll", New Object() {tglAwal, tglAkhir})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAllDistribusiLangsung(ByVal tglAwal As Date, tglAkhir As Date) As DataTable
            Try
                Dim retVal As DataTable

                retVal = db.execQuery("CSSD_DistribusiLangsungGetAll", New Object() {tglAwal, tglAkhir})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function BatalDistribusi(ByVal data As model.CSSD_OrderAlatOperasiDetail) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_BatalDistribusi", New Object() {
                                                data.IdOrderDetail,
                                                data.IdOrder,
                                                data.userEntry
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        
#End Region

    End Class

End Namespace
