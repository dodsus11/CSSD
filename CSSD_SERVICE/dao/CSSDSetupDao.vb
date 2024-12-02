Imports DbLibs
Namespace dao
    Public Class CSSDSetupDao
        Public Property db As DbConn.ClsDbConn

#Region "INVENTORY"

        Public Function SaveInventory(ByVal data As model.CSSD_Inventory) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_InventorySave", New Object() {
                                                data.KodeAlat,
                                                data.IdJenisAlat,
                                                data.standar_reuse
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetInventoryByJenis(ByVal idJenisAlat As Integer) As DataTable
            Try

                Return db.execQuery("CSSD_InventoryGetByIdJenis", New Object() {idJenisAlat})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteInventory(ByVal NoInventory As String) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_InventoryDelete", New Object() {
                                                NoInventory
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetInstrumenByJenis(ByVal idJenisAlat As Integer) As DataTable
            Try

                Return db.execQuery("CSSD_GetInstrumenByJenis", New Object() {idJenisAlat})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "LAIN - LAIN"
        Public Function getPolyRoomByType(ByVal poliType As String) As DataTable
            Try

                Return db.execQuery("CSSD_LookupPoly", New Object() {poliType})

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetJenisAlat() As DataTable
            Try

                Return db.execQuery("CSSD_JenisAlatGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetUserHMIS() As DataTable
            Try

                Return db.execQuery("CSSD_GetUserHMIS")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "SATUAN"
        Public Function GetAllSetupSatuan() As DataTable
            Try

                Return db.execQuery("CSSD_SetupSatuanGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupSatuanSave", New Object() {
                                                data.NamaSatuan
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupSatuanUpdate", New Object() {
                                                data.KodeSatuan,
                                                data.NamaSatuan
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_SetupSatuanDelete", New Object() {
                                                data.KodeSatuan
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As model.CSSD_MasterSatuan
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_MasterSatuan

                dt = db.execQuery("CSSD_SetupSatuanView", New Object() {data.KodeSatuan})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.KodeSatuan = .Item("KodeSatuan")
                        ResultItem.NamaSatuan = .Item("NamaSatuan")
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "MASTER INSTRUMEN"

        Public Function UpdatePathFotoInstrumen(ByVal idInstrumen As String, ByVal PathFoto As String) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_UpdatePathFotoInstrumen", New Object() {
                                                idInstrumen, PathFoto
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAllSetupMasterInstrumen() As DataTable
            Try

                Return db.execQuery("CSSD_SetupMasterInstrumenGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupMasterInstrumenSave", New Object() {
                                       data.KodeInstrumen,
                                       data.NamaInstrumen,
                                       data.Berat,
                                       data.Satuan.KodeSatuan,
                                       data.PathFoto,
                                       data.UserInput})

                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupMasterInstrumenUpdate", New Object() {
                                               data.IdInstrumen,
                                               data.KodeInstrumen,
                                               data.NamaInstrumen,
                                               data.Berat,
                                               data.Satuan.KodeSatuan,
                                               data.PathFoto,
                                               data.UserUpdate})
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_SetupMasterInstrumenDelete", New Object() {
                                                data.IdInstrumen
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As model.CSSD_MasterInstrumen
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_MasterInstrumen

                dt = db.execQuery("CSSD_SetupMasterInstrumenView", New Object() {data.IdInstrumen})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.IdInstrumen = .Item("IdInstrumen").ToString()
                        ResultItem.KodeInstrumen = .Item("KodeInstrumen").ToString()
                        ResultItem.NamaInstrumen = .Item("NamaInstrumen").ToString()
                        ResultItem.Berat = .Item("Berat")
                        ResultItem.Satuan.KodeSatuan = .Item("KodeSatuan").ToString()
                        ResultItem.Satuan.NamaSatuan = .Item("NamaSatuan").ToString()
                        ResultItem.PathFoto = .Item("PathFoto").ToString()
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "PETUGAS"
        Public Function GetAllSetupPetugas() As DataTable
            Try

                Return db.execQuery("CSSD_SetupPetugasGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveSetupPetugas(ByVal data As model.CSSD_Petugas) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupPetugasSave", New Object() {
                                                data.KodePetugas,
                                                data.NamaPetugas,
                                                data.Nip,
                                                data.UserInput
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateSetupPetugas(ByVal data As model.CSSD_Petugas) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupPetugasUpdate", New Object() {
                                                data.KodePetugas,
                                                data.NamaPetugas,
                                                data.Nip,
                                                data.UserUpdate
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteSetupPetugas(ByVal data As model.CSSD_Petugas) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_SetupPetugasDelete", New Object() {
                                                data.KodePetugas
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewSetupPetugas(ByVal data As model.CSSD_Petugas) As model.CSSD_Petugas
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_Petugas

                dt = db.execQuery("CSSD_SetupPetugasView", New Object() {data.KodePetugas})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.KodePetugas = .Item("KodePetugas")
                        ResultItem.NamaPetugas = .Item("NamaPetugas")
                        ResultItem.Nip = .Item("NIP").ToString

                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "KELOMPOK MESIN"
        Public Function GetAllSetupGroupMesin() As DataTable
            Try

                Return db.execQuery("CSSD_SetupGroupMesinGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupGroupMesinSave", New Object() {
                                                data.NamaGroupMesin,
                                                data.Tipe,
                                                data.UserInput
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupGroupMesinUpdate", New Object() {
                                                data.IdGroupMesin,
                                                data.NamaGroupMesin,
                                                data.Tipe,
                                                data.UserUpdate
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_SetupGroupMesinDelete", New Object() {
                                                data.IdGroupMesin
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As model.CSSD_GroupMesin
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_GroupMesin

                dt = db.execQuery("CSSD_SetupGroupMesinView", New Object() {data.IdGroupMesin})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        data.IdGroupMesin = .Item("IdGroupMesin")
                        data.NamaGroupMesin = .Item("NamaGroupMesin")
                        data.Tipe = .Item("Tipe")

                    End With
                End If

                Return data

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "MESIN"
        Public Function GetAllSetupMesin() As DataTable
            Try

                Return db.execQuery("CSSD_SetupMesinGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveSetupMesin(ByVal data As model.CSSD_Mesin) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupMesinSave", New Object() {
                                                data.KodeMesin,
                                                data.NamaMesin,
                                                data.Merk,
                                                data.NamaVendor,
                                                data.TglPengadaan,
                                                data.GroupMesin.IdGroupMesin,
                                                data.UserInput
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateSetupMesin(ByVal data As model.CSSD_Mesin) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupMesinUpdate", New Object() {
                                                data.KodeMesin,
                                                data.NamaMesin,
                                                data.Merk,
                                                data.NamaVendor,
                                                data.TglPengadaan,
                                                data.GroupMesin.IdGroupMesin,
                                                data.UserUpdate
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteSetupMesin(ByVal data As model.CSSD_Mesin) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_SetupMesinDelete", New Object() {
                                                data.KodeMesin
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewSetupMesin(ByVal data As model.CSSD_Mesin) As model.CSSD_Mesin
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_Mesin

                dt = db.execQuery("CSSD_SetupMesinView", New Object() {data.KodeMesin})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.KodeMesin = .Item("KodeMesin")
                        ResultItem.NamaMesin = .Item("NamaMesin")
                        ResultItem.Merk = .Item("Merk").ToString
                        ResultItem.NamaVendor = .Item("NamaVendor").ToString
                        ResultItem.TglPengadaan = .Item("TglPengadaan").ToString
                        'ResultItem.tgl_pengadaan = .Item("tgl_pengadaan")
                        ResultItem.GroupMesin.IdGroupMesin = .Item("IdGroupMesin").ToString
                        ResultItem.GroupMesin.NamaGroupMesin = .Item("NamaGroupMesin").ToString
                        ResultItem.GroupMesin.Tipe = .Item("Tipe").ToString
                        ResultItem.LoadMesin = .Item("LoadMesin")

                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "MASTER SET INSTRUMEN (TROMOL)"
        Public Function GetAllMasterSetInstrumen() As DataTable
            Try

                Return db.execQuery("CSSD_SetupMasterSetInstrumenGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_MasterSetInstrumenSave", New Object() {
                                                data.KodeSetInstrumen,
                                                data.NamaSetInstrumen,
                                                data.Berat,
                                                data.Satuan.KodeSatuan,
                                                data.StandarKasa,
                                                data.PathFoto,
                                                data.Keterangan,
                                                data.UserInput,
                                                data.TglRevisi,
                                                data.RevisiCount
                                             })
                Return retVal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_MasterSetInstrumenUpdate", New Object() {
                                                data.KodeSetInstrumen,
                                                data.NamaSetInstrumen,
                                                data.Berat,
                                                data.Satuan.KodeSatuan,
                                                data.StandarKasa,
                                                data.PathFoto,
                                                data.Keterangan,
                                                data.UserUpdate,
                                                data.TglRevisi,
                                                data.RevisiCount
                                             })
                Return retVal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_DetailSetInstrumenSave", New Object() {
                                                data.KodeSetInstrumen,
                                                data.IdInstrumen,
                                                data.Qty
                                             })
                Return retVal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_DetailSetInstrumenUpdate", New Object() {
                                                data.KodeSetInstrumen,
                                                data.IdInstrumen,
                                                data.Qty
                                             })
                Return retVal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_DetailSetInstrumenDelete", New Object() {
                                                data.KodeSetInstrumen,
                                                data.IdInstrumen
                                             })
                Return retVal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As model.CSSD_MasterSetInstrumen
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_MasterSetInstrumen

                dt = db.execQuery("CSSD_MasterSetInstrumenView", New Object() {data.KodeSetInstrumen})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.IdSetInstrumen = .Item("IdSetInstrumen").ToString
                        ResultItem.KodeSetInstrumen = .Item("KodeSetInstrumen").ToString
                        ResultItem.NamaSetInstrumen = .Item("NamaSetInstrumen").ToString
                        ResultItem.Berat = .Item("Berat")
                        ResultItem.Satuan.KodeSatuan = .Item("KodeSatuan").ToString
                        ResultItem.Satuan.NamaSatuan = .Item("NamaSatuan").ToString
                        ResultItem.StandarKasa = .Item("StandarKasa")
                        ResultItem.Keterangan = .Item("Keterangan").ToString
                        ResultItem.PathFoto = .Item("PathFoto").ToString
                        ResultItem.ExpiredDate = .Item("ExpiredDate").ToString
                        ResultItem.TglRevisi = .Item("TglRevisi").ToString
                        ResultItem.RevisiCount = .Item("RevisiCount")
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewInstrumenNonSet(ByVal data As model.CSSD_MasterSetInstrumen) As model.CSSD_MasterSetInstrumen
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_MasterSetInstrumen

                dt = db.execQuery("CSSD_InstrumenNonSetView", New Object() {data.KodeSetInstrumen})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.KodeSetInstrumen = .Item("KodeSetInstrumen").ToString
                        ResultItem.NamaSetInstrumen = .Item("NamaSetInstrumen").ToString
                        ResultItem.Berat = .Item("Berat")
                        ResultItem.Satuan.KodeSatuan = .Item("KodeSatuan").ToString
                        ResultItem.Satuan.NamaSatuan = .Item("NamaSatuan").ToString
                        ResultItem.StandarKasa = .Item("StandarKasa")
                        ResultItem.Keterangan = .Item("Keterangan").ToString
                        ResultItem.PathFoto = .Item("PathFoto").ToString
                        ResultItem.ExpiredDate = .Item("ExpiredDate").ToString
                        ResultItem.TglRevisi = .Item("TglRevisi").ToString
                        ResultItem.RevisiCount = .Item("RevisiCount")
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewDetailMasterSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As DataTable
            Try
                Dim dt As New DataTable

                dt = db.execQuery("CSSD_DetailMasterSetInstrumenView", New Object() {data.KodeSetInstrumen})

                Return dt

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_MasterSetInstrumenDelete", New Object() {data.KodeSetInstrumen})

                Return retVal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "MASTER GUDANG"
        Public Function GetAllMasterGudang() As DataTable
            Try

                Return db.execQuery("CSSD_SetupGudangGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetAllpoly() As DataTable
            Try

                Return db.execQuery("CSSD_GetAllpoly")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SaveSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupGudangSave", New Object() {
                                                data.KodeGudang,
                                                data.NamaGudang,
                                                data.Telp
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SetupGudangUpdate", New Object() {
                                                data.KodeGudang,
                                                data.NamaGudang,
                                                data.Telp
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DeleteSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String
            Try
                Dim retVal As String = String.Empty
                retVal = db.execScalar("CSSD_SetupGudangDelete", New Object() {
                                                data.KodeGudang
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As model.CSSD_MasterGudang
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_MasterGudang

                dt = db.execQuery("CSSD_SetupGudangView", New Object() {data.KodeGudang})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.KodeGudang = .Item("KodeGudang")
                        ResultItem.NamaGudang = .Item("NamaGudang")
                        ResultItem.Telp = .Item("Telp")
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetPoly() As DataTable
            Try

                Return db.execQuery("CSSD_GetPoly")

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region


#Region "Mapping User Gudang"
        Public Function SaveMappingUserGudang(ByVal data As model.CSSD_MappingUserGudang) As String
            Try
                Dim retVal As String = String.Empty

                retVal = db.execScalar("CSSD_SaveMappingUserGudang", New Object() {
                                                data.IdUser,
                                                data.KodeGudang,
                                                data.UserEntry
                                             })
                Return retVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ViewUserTerdaftarGudang(ByVal IdUser As Long) As model.CSSD_MappingUserGudang
            Try
                Dim dt As New DataTable
                Dim ResultItem As New model.CSSD_MappingUserGudang

                dt = db.execQuery("CSSD_GetUserTerdaftarGudang", New Object() {IdUser})

                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        ResultItem.IdUser = .Item("IdUser")
                        ResultItem.KodeGudang = .Item("KodeGudang")
                        ResultItem.NamaGudang = .Item("NamaGudang")
                    End With
                End If

                Return ResultItem

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region



    End Class
End Namespace

