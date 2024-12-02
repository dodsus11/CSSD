Imports System.ServiceModel
Imports KernelEngine
Imports Ninject
Imports DbLibs
Imports RockUtil
Imports System.IO
Imports CSSD_SERVICE.CSSDSettings

Namespace service
    <ServiceBehavior(IncludeExceptionDetailInFaults:=True, AddressFilterMode:=AddressFilterMode.Any)>
    Public Class CSSDSetupService
        Implements ICSSDSetupService

        Private kernel As IKernel = ClsKernel.createKernel()
        Private db As DbConn.ClsDbConn
        Private cssdDao As dao.CSSDSetupDao

        Public Sub New()
            db = New DbConn.ClsDbConn(System.Configuration.ConfigurationManager.AppSettings("STR_CSSD").ToString)
            cssdDao = kernel.Get(Of dao.CSSDSetupDao)()
            cssdDao.db = db
        End Sub

#Region "Satuan"
        Public Function DeleteSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String Implements ICSSDSetupService.DeleteSetupSatuan
            Try

                If data.KodeSatuan = String.Empty Then
                    Return "ERROR : Kode Satuan wajib di isi!"
                End If

                Return cssdDao.DeleteSetupSatuan(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteSetupSatuan:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllSetupSatuan() As System.Data.DataTable Implements ICSSDSetupService.GetAllSetupSatuan
            Try

                Return cssdDao.GetAllSetupSatuan

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllSetupSatuan:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String Implements ICSSDSetupService.SaveSetupSatuan
            Try

                'If data.KodeSatuan = String.Empty Then
                '    Return "ERROR : Kode Satuan wajib di isi!"
                'End If

                If data.NamaSatuan = String.Empty Then
                    Return "ERROR : nama Satuan wajib di isi!"
                End If

                Return cssdDao.SaveSetupSatuan(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveSetupSatuan:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As String Implements ICSSDSetupService.UpdateSetupSatuan
            Try
                If data.KodeSatuan = String.Empty Then
                    Return "ERROR : Kode Satuan wajib di isi!"
                End If

                If data.NamaSatuan = String.Empty Then
                    Return "ERROR : nama Satuan wajib di isi!"
                End If

                Return cssdDao.UpdateSetupSatuan(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateSetupSatuan:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewSetupSatuan(ByVal data As model.CSSD_MasterSatuan) As model.CSSD_MasterSatuan Implements ICSSDSetupService.ViewSetupSatuan
            Try

                Return cssdDao.ViewSetupSatuan(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewSetupSatuan:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
#End Region

#Region "Master Instrumen"
        Public Function DeleteSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String Implements ICSSDSetupService.DeleteSetupMasterInstrumen
            Try

                Dim MasterInstrumen As New model.CSSD_MasterInstrumen

                MasterInstrumen = Me.ViewSetupMasterInstrumen(data)

                'If MasterInstrumen.PathFoto <> String.Empty Then
                '    Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                '    File.Delete(SettingPath.INSTRUMEN_IMAGE_PATH & MasterInstrumen.PathFoto)
                '    'Util.CloseNetLogin("172.16.1.69\d$\CSSD\Instrumen")
                'End If

                Return cssdDao.DeleteSetupMasterInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteSetupMasterInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllSetupMasterInstrumen() As System.Data.DataTable Implements ICSSDSetupService.GetAllSetupMasterInstrumen
            Try

                Return cssdDao.GetAllSetupMasterInstrumen()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllSetupMasterInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String Implements ICSSDSetupService.SaveSetupMasterInstrumen
            Try
                If data.NamaInstrumen = String.Empty Then
                    Return "ERROR : Nama Instrumen wajib di isi!"
                End If

                Me.db.beginTransaction()

                Dim retVal As String = String.Empty
                Dim sourcePath As String = data.PathFoto
                Dim ImageName As String = String.Empty
                Dim imageFullName As String = String.Empty

                retVal = cssdDao.SaveSetupMasterInstrumen(data)

                If InStr(retVal, "ERROR") Then
                    Me.db.rollBackTrans()
                    Return retVal
                End If

                If data.PathFoto <> String.Empty Then
                    ImageName = Path.GetFileNameWithoutExtension(data.PathFoto) & "-" & retVal & Path.GetExtension(data.PathFoto)
                    imageFullName = ImageName

                    data.PathFoto = imageFullName
                End If

                retVal = cssdDao.UpdatePathFotoInstrumen(retVal, data.PathFoto)

                If Not InStr(retVal, "ERROR") Then
                    'upload image

                    'If data.PathFoto <> String.Empty Then
                    '    Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                    '    File.Copy(sourcePath, SettingPath.INSTRUMEN_IMAGE_PATH & ImageName, True)
                    '    'Util.CloseNetLogin("172.16.1.69\d$\CSSD\Instrumen")
                    'End If

                    Me.db.commitTrans()
                    Return ImageName
                Else
                    Me.db.rollBackTrans()
                    Return retVal
                End If

            Catch ex As Exception
                Me.db.rollBackTrans()
                LoggingLibs.LogApp.error("SaveSetupMasterInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As String Implements ICSSDSetupService.UpdateSetupMasterInstrumen
            Try

                If data.IdInstrumen = String.Empty Then
                    Return "ERROR : Id Instrumen wajib di isi!"
                End If

                If data.NamaInstrumen = String.Empty Then
                    Return "ERROR : Nama Instrumen wajib di isi!"
                End If

                Dim retVal As String = String.Empty
                Me.db.beginTransaction()

                Dim MasterInstrumen As New model.CSSD_MasterInstrumen
                MasterInstrumen = Me.ViewSetupMasterInstrumen(data)

                Dim sourcePath As String = data.PathFoto
                Dim ImageName As String = String.Empty
                Dim imageFullName As String = String.Empty

                If data.PathFoto <> String.Empty Then
                    ImageName = Path.GetFileNameWithoutExtension(data.PathFoto) & "-" & data.IdInstrumen & Path.GetExtension(data.PathFoto)
                    imageFullName = ImageName

                    data.PathFoto = imageFullName
                ElseIf sourcePath = String.Empty Then
                    data.PathFoto = MasterInstrumen.PathFoto
                End If

                retVal = cssdDao.UpdateSetupMasterInstrumen(data)



                If retVal = String.Empty Then
                    'upload image

                    If sourcePath <> String.Empty Then

                        'If MasterInstrumen.PathFoto <> String.Empty Then
                        '    Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                        '    File.Delete(SettingPath.INSTRUMEN_IMAGE_PATH & MasterInstrumen.PathFoto)
                        '    'Util.CloseNetLogin("172.16.1.69\d$\CSSD\Instrumen")
                        'End If

                        'Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                        'File.Copy(sourcePath, SettingPath.INSTRUMEN_IMAGE_PATH & ImageName, True)
                        ''Util.CloseNetLogin("172.16.1.69\d$\CSSD\Instrumen")
                    End If

                    Me.db.commitTrans()
                    Return ImageName
                Else
                    Me.db.rollBackTrans()
                    Return retVal
                End If

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateSetupMasterInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewSetupMasterInstrumen(ByVal data As model.CSSD_MasterInstrumen) As model.CSSD_MasterInstrumen Implements ICSSDSetupService.ViewSetupMasterInstrumen
            Try

                Return cssdDao.ViewSetupMasterInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewSetupMasterInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
#End Region

#Region "Petugas"
        Public Function DeleteSetupPetugas(ByVal data As model.CSSD_Petugas) As String Implements ICSSDSetupService.DeleteSetupPetugas
            Try

                If data.KodePetugas = String.Empty Then
                    Return "ERROR : Kode Petugas wajib di isi!"
                End If

                Return cssdDao.DeleteSetupPetugas(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteSetupPetugas:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllSetupPetugas() As System.Data.DataTable Implements ICSSDSetupService.GetAllSetupPetugas
            Try

                Return cssdDao.GetAllSetupPetugas

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllSetupPetugas:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveSetupPetugas(ByVal data As model.CSSD_Petugas) As String Implements ICSSDSetupService.SaveSetupPetugas
            Try

                If data.KodePetugas = String.Empty Then
                    Return "ERROR : Kode petugas wajib di isi!"
                End If

                If data.NamaPetugas = String.Empty Then
                    Return "ERROR : nama petugas wajib di isi!"
                End If

                Return cssdDao.SaveSetupPetugas(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveSetupPetugas:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateSetupPetugas(ByVal data As model.CSSD_Petugas) As String Implements ICSSDSetupService.UpdateSetupPetugas
            Try

                If data.KodePetugas = String.Empty Then
                    Return "ERROR : Kode petugas wajib di isi!"
                End If

                If data.NamaPetugas = String.Empty Then
                    Return "ERROR : nama petugas wajib di isi!"
                End If

                Return cssdDao.UpdateSetupPetugas(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateSetupPetugas:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewSetupPetugas(ByVal data As model.CSSD_Petugas) As model.CSSD_Petugas Implements ICSSDSetupService.ViewSetupPetugas
            Try

                Return cssdDao.ViewSetupPetugas(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewSetupPetugas:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
#End Region

#Region "Group mesin"
        Public Function DeleteSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String Implements ICSSDSetupService.DeleteSetupGroupMesin
            Try

                If data.IdGroupMesin = 0 Then
                    Return "ERROR : IdGroupMesin wajib di isi!"
                End If

                Return cssdDao.DeleteSetupGroupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteSetupGroupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllSetupGroupMesin() As System.Data.DataTable Implements ICSSDSetupService.GetAllSetupGroupMesin
            Try

                Return cssdDao.GetAllSetupGroupMesin

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllSetupGroupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String Implements ICSSDSetupService.SaveSetupGroupMesin
            Try

                If data.NamaGroupMesin = String.Empty Then
                    Return "ERROR : Nama Group Mesin wajib di isi!"
                End If

                Return cssdDao.SaveSetupGroupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveSetupGroupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As String Implements ICSSDSetupService.UpdateSetupGroupMesin
            Try

                If data.NamaGroupMesin = String.Empty Then
                    Return "ERROR : Nama Group Mesin wajib di isi!"
                End If

                Return cssdDao.UpdateSetupGroupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateSetupGroupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewSetupGroupMesin(ByVal data As model.CSSD_GroupMesin) As model.CSSD_GroupMesin Implements ICSSDSetupService.ViewSetupGroupMesin
            Try

                Return cssdDao.ViewSetupGroupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewSetupGroupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

#End Region

#Region "Mesin "
        Public Function DeleteSetupMesin(ByVal data As model.CSSD_Mesin) As String Implements ICSSDSetupService.DeleteSetupMesin
            Try

                If data.KodeMesin = String.Empty Then
                    Return "ERROR : Kode Mesin wajib di isi!"
                End If

                Return cssdDao.DeleteSetupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteSetupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function


        Public Function GetAllSetupMesin() As System.Data.DataTable Implements ICSSDSetupService.GetAllSetupMesin
            Try

                Return cssdDao.GetAllSetupMesin

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllSetupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function


        Public Function SaveSetupMesin(ByVal data As model.CSSD_Mesin) As String Implements ICSSDSetupService.SaveSetupMesin
            Try

                If data.KodeMesin = String.Empty Then
                    Return "ERROR : Kode Mesin wajib di isi!"
                End If

                If data.NamaMesin = String.Empty Then
                    Return "ERROR : nama Mesin wajib di isi!"
                End If

                If CStr(data.GroupMesin.IdGroupMesin) = "" Then
                    Return "ERROR : kelompok mesin wajib di isi!"
                End If

                Return cssdDao.SaveSetupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveSetupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function


        Public Function UpdateSetupMesin(ByVal data As model.CSSD_Mesin) As String Implements ICSSDSetupService.UpdateSetupMesin
            Try

                If data.KodeMesin = String.Empty Then
                    Return "ERROR : Kode Mesin wajib di isi!"
                End If

                If data.NamaMesin = String.Empty Then
                    Return "ERROR : nama Mesin wajib di isi!"
                End If

                If CStr(data.GroupMesin.IdGroupMesin) = "" Then
                    Return "ERROR : kelompok mesin wajib di isi!"
                End If

                Return cssdDao.UpdateSetupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateSetupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function


        Public Function ViewSetupMesin(ByVal data As model.CSSD_Mesin) As model.CSSD_Mesin Implements ICSSDSetupService.ViewSetupMesin
            Try

                Return cssdDao.ViewSetupMesin(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewSetupMesin:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
#End Region

#Region "MasterSetInstrumen"

        Public Function GetAllMasterSetInstrumen() As System.Data.DataTable Implements ICSSDSetupService.GetAllMasterSetInstrumen
            Try

                Return cssdDao.GetAllMasterSetInstrumen()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllMasterSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String Implements ICSSDSetupService.SaveMasterSetInstrumen
            Try

                'If data.KodeSetInstrumen = String.Empty Then
                '    Return "ERROR : Kode Set Instrumen wajib di isi!"
                'End If

                'If data.NamaSetInstrumen = String.Empty Then
                '    Return "ERROR : Nama Set instrumen wajib di isi!"
                'End If

                'If data.Berat = String.Empty Or Not IsNumeric(data.Berat) Then
                '    Return "ERROR : Berat wajib di isi dan harus angka !"
                'End If

                'If data.Satuan.KodeSatuan = String.Empty Then
                '    Return "ERROR : Satuan wajib di isi!"
                'End If

                'If data.StandarKasa = String.Empty Or Not IsNumeric(data.StandarKasa) Then
                '    Return "ERROR : Standar Kasa wajib di isi dan harus angka !"
                'End If

                Return cssdDao.SaveMasterSetInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveMasterSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String Implements ICSSDSetupService.SaveDetailSetInstrumen
            Try

                If data.KodeSetInstrumen = String.Empty Then
                    Return "ERROR : Kode set instrumen wajib di isi!"
                End If

                If data.IdInstrumen = String.Empty Then
                    Return "ERROR : Id Instrumen wajib di isi!"
                End If

                If data.Qty < 1 Then
                    Return "ERROR : Id Instrumen : " & data.IdInstrumen & " - Qty wajib di isi, tidak boleh kurang dari 1!"
                End If

                Return cssdDao.SaveDetailSetInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveDetailSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveMasterDetailSetInstrumen(ByVal dataMaster As model.CSSD_MasterSetInstrumen,
                                                  ByVal dataDetail As List(Of model.CSSD_DetailSetInstrumen)) As String Implements ICSSDSetupService.SaveMasterDetailSetInstrumen
            Dim retValMaster As String = String.Empty
            Dim retValDetail As String = String.Empty
            Dim retVal As String = String.Empty
            Try

                Me.db.beginTransaction()

                Dim sourcePath As String = dataMaster.PathFoto
                Dim ImageName As String = String.Empty
                Dim imageFullName As String = String.Empty

                If dataMaster.PathFoto <> String.Empty Then
                    ImageName = Path.GetFileNameWithoutExtension(dataMaster.PathFoto) & "-" & dataMaster.KodeSetInstrumen & Path.GetExtension(dataMaster.PathFoto)
                    imageFullName = ImageName

                    dataMaster.PathFoto = imageFullName
                End If

                retValMaster = Me.SaveMasterSetInstrumen(dataMaster)

                If InStr(retValMaster, "ERROR") Then
                    Me.db.rollBackTrans()
                    Return retValMaster
                End If

                If dataMaster.PathFoto <> String.Empty Then
                    'Util.NetLogin("172.16.1.69\d$\CSSD\SetInstrumen", "", "Administrator", "RSkariadi2011@")
                    'File.Copy(sourcePath, "\\172.16.1.69\d$\CSSD\SetInstrumen\" & ImageName, True)
                    'Util.CloseNetLogin("172.16.1.69\d$\CSSD\SetInstrumen")
                End If

                For Each item In dataDetail
                    item.KodeSetInstrumen = retValMaster
                    retValDetail = Me.SaveDetailSetInstrumen(item)
                    If InStr(retValDetail, "ERROR") Then
                        Me.db.rollBackTrans()
                        Return retValDetail
                    End If
                Next

                If retValDetail.Trim = "" Then
                    If dataMaster.PathFoto <> String.Empty Then
                        retVal = ImageName
                    Else
                        retVal = "NO_UPLOAD"
                    End If

                    Me.db.commitTrans()
                End If

            Catch ex As Exception
                Me.db.rollBackTrans()
                LoggingLibs.LogApp.error("SaveMasterDetailSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
            Return retVal
        End Function

        Public Function ViewMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As model.CSSD_MasterSetInstrumen Implements ICSSDSetupService.ViewMasterSetInstrumen
            Try

                Return cssdDao.ViewMasterSetInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewMasterSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewInstrumenNonSet(ByVal data As model.CSSD_MasterSetInstrumen) As model.CSSD_MasterSetInstrumen Implements ICSSDSetupService.ViewInstrumenNonSet
            Try

                Return cssdDao.ViewInstrumenNonSet(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewInstrumenNonSet:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewDetailMasterSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As DataTable Implements ICSSDSetupService.ViewDetailMasterSetInstrumen
            Try

                Return cssdDao.ViewDetailMasterSetInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewDetailMasterSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function DeleteMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String Implements ICSSDSetupService.DeleteMasterSetInstrumen
            Try
                Dim MasterSetInstrumen As New model.CSSD_MasterSetInstrumen

                MasterSetInstrumen = Me.ViewMasterSetInstrumen(data)

                'If MasterSetInstrumen.PathFoto <> String.Empty Then
                '    Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                '    File.Delete(SettingPath.SET_INSTRUMEN_IMAGE_PATH & MasterSetInstrumen.PathFoto)
                '    'Util.CloseNetLogin("172.16.1.69\d$\CSSD\SetInstrumen")
                'End If

                Return cssdDao.DeleteMasterSetInstrumen(data)
            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteMasterSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function DeleteDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String Implements ICSSDSetupService.DeleteDetailSetInstrumen
            Try

                Return cssdDao.DeleteDetailSetInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteDetailSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateDetailSetInstrumen(ByVal data As model.CSSD_DetailSetInstrumen) As String Implements ICSSDSetupService.UpdateDetailSetInstrumen
            Try
                If data.KodeSetInstrumen = String.Empty Then
                    Return "ERROR : Kode set instrumen wajib di isi!"
                End If

                If data.IdInstrumen = String.Empty Then
                    Return "ERROR : Id Instrumen wajib di isi!"
                End If

                If data.Qty < 1 Then
                    Return "ERROR : Id Instrumen : " & data.IdInstrumen & " - Qty wajib di isi, tidak boleh kurang dari 1!"
                End If
                Return cssdDao.UpdateDetailSetInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateDetailSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateMasterDetailSetInstrumen(ByVal dataMaster As model.CSSD_MasterSetInstrumen, ByVal dataDetail As System.Collections.Generic.List(Of model.CSSD_DetailSetInstrumen)) As String Implements ICSSDSetupService.UpdateMasterDetailSetInstrumen
            Dim retValMaster As String = String.Empty
            Dim retValDetail As String = String.Empty
            Dim retVal As String = String.Empty
            Try

                Me.db.beginTransaction()

                Dim MasterSetInstrumen As New model.CSSD_MasterSetInstrumen
                MasterSetInstrumen = Me.ViewMasterSetInstrumen(dataMaster)

                Dim sourcePath As String = dataMaster.PathFoto
                Dim ImageName As String = String.Empty
                Dim imageFullName As String = String.Empty

                If dataMaster.PathFoto <> String.Empty Then
                    ImageName = Path.GetFileNameWithoutExtension(dataMaster.PathFoto) & "-" & dataMaster.KodeSetInstrumen & Path.GetExtension(dataMaster.PathFoto)
                    imageFullName = ImageName

                    dataMaster.PathFoto = imageFullName
                ElseIf sourcePath = String.Empty Then
                    dataMaster.PathFoto = MasterSetInstrumen.PathFoto
                End If

                retValMaster = Me.UpdateMasterSetInstrumen(dataMaster)


                If InStr(retValMaster, "ERROR") Then
                    Me.db.rollBackTrans()
                    Return retValMaster
                End If

                'If dataDetail.Count = 0 Then
                '    Me.db.commitTrans()
                '    Return ""
                'End If

                For Each item In dataDetail

                    If item.flag = "D" Then
                        retValDetail = Me.DeleteDetailSetInstrumen(item)
                        If InStr(retValDetail, "ERROR") Then
                            Me.db.rollBackTrans()
                            Return retValDetail
                        End If
                    End If

                    If item.flag = "U" Then
                        retValDetail = Me.UpdateDetailSetInstrumen(item)
                        If InStr(retValDetail, "ERROR") Then
                            Me.db.rollBackTrans()
                            Return retValDetail
                        End If
                    End If

                    If item.flag = "A" Then
                        retValDetail = Me.SaveDetailSetInstrumen(item)
                        If InStr(retValDetail, "ERROR") Then
                            Me.db.rollBackTrans()
                            Return retValDetail
                        End If
                    End If

                Next

                If retValDetail.Trim = "" Then

                    If sourcePath <> String.Empty Then

                        'If MasterSetInstrumen.PathFoto <> String.Empty Then
                        '    Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                        '    File.Delete(SettingPath.SET_INSTRUMEN_IMAGE_PATH & MasterSetInstrumen.PathFoto)
                        '    'Util.CloseNetLogin("172.16.1.69\d$\CSSD\SetInstrumen")
                        'End If

                        'Util.NetLogin("172.16.1.69\d$\CSSD\SetInstrumen", "", "Administrator", "RSkariadi2011@")
                        'File.Copy(sourcePath, "\\172.16.1.69\d$\CSSD\SetInstrumen\" & ImageName, True)
                        'Util.CloseNetLogin("172.16.1.69\d$\CSSD\SetInstrumen")
                        retVal = ImageName
                    Else
                        retVal = "NO_UPLOAD"
                    End If

                    Me.db.commitTrans()
                End If

            Catch ex As Exception
                Me.db.rollBackTrans()
                LoggingLibs.LogApp.error("UpdateMasterDetailSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
            Return retVal
        End Function

        Public Function UpdateMasterSetInstrumen(ByVal data As model.CSSD_MasterSetInstrumen) As String Implements ICSSDSetupService.UpdateMasterSetInstrumen
            Try

                If data.KodeSetInstrumen = String.Empty Then
                    Return "ERROR : Kode Set Instrumen wajib di isi!"
                End If

                If data.NamaSetInstrumen = String.Empty Then
                    Return "ERROR : Nama Set instrumen wajib di isi!"
                End If

                Return cssdDao.UpdateMasterSetInstrumen(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateMasterSetInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

#End Region

#Region "Inventory"
        Public Function SaveInventory(ByVal data As model.CSSD_Inventory) As String Implements ICSSDSetupService.SaveInventory
            Try

                Return Me.cssdDao.SaveInventory(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveInventory:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetInventoryByJenis(ByVal idJenisAlat As Integer) As System.Data.DataTable Implements ICSSDSetupService.GetInventoryByJenis
            Try

                Return Me.cssdDao.GetInventoryByJenis(idJenisAlat)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetInventoryByJenis:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function DeleteInventory(ByVal NoInventory As String) As String Implements ICSSDSetupService.DeleteInventory
            Try

                Return Me.cssdDao.DeleteInventory(NoInventory)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteInventory:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetInstrumenByJenis(ByVal idJenisAlat As Integer) As System.Data.DataTable Implements ICSSDSetupService.GetInstrumenByJenis
            Try

                Return Me.cssdDao.GetInstrumenByJenis(idJenisAlat)

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetInstrumenByJenis:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

#End Region

#Region "LAIN-LAIN"
        Public Function getPolyRoomByType(ByVal poliType As String) As System.Data.DataTable Implements ICSSDSetupService.getPolyRoomByType
            Try

                Return Me.cssdDao.getPolyRoomByType(poliType)

            Catch ex As Exception
                LoggingLibs.LogApp.error("getPolyRoomByType:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetJenisAlat() As System.Data.DataTable Implements ICSSDSetupService.GetJenisAlat
            Try

                Return Me.cssdDao.GetJenisAlat()

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetJenisAlat:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
#End Region

        Public Function DeleteSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String Implements ICSSDSetupService.DeleteSetupMasterGudang
            Try

                If data.KodeGudang = String.Empty Then
                    Return "ERROR : Kode Gudang wajib di isi!"
                End If

                Return cssdDao.DeleteSetupMasterGudang(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("DeleteSetupMasterGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllSetupMasterGudang() As System.Data.DataTable Implements ICSSDSetupService.GetAllSetupMasterGudang
            Try

                Return cssdDao.GetAllMasterGudang

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllSetupMasterGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetAllpoly() As System.Data.DataTable Implements ICSSDSetupService.GetAllpoly
            Try

                Return cssdDao.GetAllpoly

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetAllpoly:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String Implements ICSSDSetupService.SaveSetupMasterGudang
            Try

                If data.KodeGudang = String.Empty Then
                    Return "ERROR : Kode Ruang wajib di isi!"
                End If

                If data.NamaGudang = String.Empty Then
                    Return "ERROR : Nama Ruang wajib di isi!"
                End If

                Return cssdDao.SaveSetupMasterGudang(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveSetupMasterGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdateSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As String Implements ICSSDSetupService.UpdateSetupMasterGudang
            Try

                If data.KodeGudang = String.Empty Then
                    Return "ERROR : Kode Ruang wajib di isi!"
                End If

                If data.NamaGudang = String.Empty Then
                    Return "ERROR : Nama Ruang wajib di isi!"
                End If

                Return cssdDao.UpdateSetupMasterGudang(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdateSetupMasterGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewSetupMasterGudang(ByVal data As model.CSSD_MasterGudang) As model.CSSD_MasterGudang Implements ICSSDSetupService.ViewSetupMasterGudang
            Try

                Return cssdDao.ViewSetupMasterGudang(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewSetupMasterGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function UpdatePathFotoInstrumen(ByVal idInstrumen As String, ByVal PathFoto As String) As String Implements ICSSDSetupService.UpdatePathFotoInstrumen
            Try

                Return cssdDao.UpdatePathFotoInstrumen(idInstrumen, PathFoto)

            Catch ex As Exception
                LoggingLibs.LogApp.error("UpdatePathFotoInstrumen:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetUserHMIS() As System.Data.DataTable Implements ICSSDSetupService.GetUserHMIS
            Try

                Return cssdDao.GetUserHMIS

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetUserHMIS:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function SaveMappingUserGudang(ByVal data As model.CSSD_MappingUserGudang) As String Implements ICSSDSetupService.SaveMappingUserGudang
            Try

                Return cssdDao.SaveMappingUserGudang(data)

            Catch ex As Exception
                LoggingLibs.LogApp.error("SaveMappingUserGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function ViewUserTerdaftarGudang(ByVal IdUser As Long) As model.CSSD_MappingUserGudang Implements ICSSDSetupService.ViewUserTerdaftarGudang
            Try

                Return cssdDao.ViewUserTerdaftarGudang(IdUser)

            Catch ex As Exception
                LoggingLibs.LogApp.error("ViewUserTerdaftarGudang:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function

        Public Function GetPoly() As System.Data.DataTable Implements ICSSDSetupService.GetPoly
            Try

                Return cssdDao.GetPoly

            Catch ex As Exception
                LoggingLibs.LogApp.error("GetPoly:" + ex.Message)
                Throw New FaultException(ex.Message)
            End Try
        End Function
    End Class
End Namespace


